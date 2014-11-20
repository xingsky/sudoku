using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class CellMethods
    {
        private delegate bool RelativeCellMethod(Cell[,] table, int i, int j, int index);
        private int[] box = new int[9] { 0, 0, 0, 3, 3, 3, 6, 6, 6 };//box

        /// Set value for Cell
        public bool SetValue(Cell cell)
        {
            if (cell.ValueNumber != 0)
            {
                throw new InvalidOperationException("Can not set value for cell over two times");
            }
            if (cell.Candidate.Count == 0)
                return false;

            int series = new Random().Next(0, cell.Candidate.Count - 1);
            cell.ValueNumber = cell.Candidate[series];
            cell.Candidate.RemoveAt(series);
            return true;
        }

        /// Remove candidate number of cell
        private bool RemoveCellCandidate(Cell[,] table, int i, int j, int index)
        {
            int value = table[index / 9, index % 9].ValueNumber;
            bool mark = true;

            if (table[i, j].Candidate.Contains(value))
            {
                //If there have NUMBER in candidate, remove
                table[i, j].Candidate.Remove(value);

                if (table[i, j].Candidate.Count == 0 && table[i, j].ValueNumber == 0)
                {
                    //If after remove candidate number this cell do not got value and equal 0 then roll back
                    mark = false;
                }
            }
            else if (table[i, j].DuplicateDelete.ContainsKey(value))
            {
                //If there are no candiadte in this cell, however the duplicate dictionary have, set value ++
                table[i, j].DuplicateDelete[value]++;
            }
            else
            {
                //If there are no candate in this cell, however not existing in the duplicate dictionary, add value
                table[i, j].DuplicateDelete.Add(value, 1);
            }
            return mark;
        }

        /// Recovery candidate number
        private bool RecoverCellCandidate(Cell[,] table, int i, int j, int index)
        {
            int value = table[index / 9, index % 9].ValueNumber;
            bool mark = true;

            if (table[i, j].DuplicateDelete.ContainsKey(value))
            {
                //If the value is existing in duplicate dictionary, then set the value in the duplicate dictionary -1
                if (--table[i, j].DuplicateDelete[value] == 0)
                {
                    table[i, j].DuplicateDelete.Remove(value);
                }
            }
            else if (!table[i, j].Candidate.Contains(value))
            {
                //If this value not existing in cell candidate, then add it
                table[i, j].Candidate.Add(value);
            }
            return mark;
        }



        /// Set value if only one candidate number
        private bool SetUniqueCellCandidate(Cell[,] table, int i, int j, int index)
        {
            RelativeCellMethod removeCandidateMethod = new RelativeCellMethod(RemoveCellCandidate);
            RelativeCellMethod recoverCandidateMethod = new RelativeCellMethod(RecoverCellCandidate);

            bool mark = true;
            if (table[i, j].ValueNumber == 0 && table[i, j].Candidate.Count == 1)
            {//If when remove candidate number, onyl have one candidate number, then assignment this cell as the rest of candidate
                int oldValue = table[i, j].Candidate[0];//in case of failed
                mark &= SetValue(table[i, j]);
                mark &= DealRelativeCell(removeCandidateMethod, table, i * 9 + j);
                if (!mark)
                {//if remove candidate failed, rollback 
                    DealRelativeCell(recoverCandidateMethod, table, i * 9 + j);
                    table[i, j].Candidate.Add(oldValue);
                    mark &= false;
                }
            }
            return mark;
        }

        /// Deal relative cell
        private bool DealRelativeCell(RelativeCellMethod cellMethod, Cell[,] table, int index)
        {
            bool mark = true;
            Cell cell = table[index / 9, index % 9];
            for (int i = 0; i < 9; i++)
            {
                //same column
                if (i != index / 9)
                {
                    //cannot equal to current cell
                    mark &= cellMethod(table, i, index % 9, index);
                }

                //same row
                if (i != index % 9)
                {
                    //cannot equal to current cell
                    mark &= cellMethod(table, index / 9, i, index);
                }
            }

            //4 grids in the box
            for (int i = box[index / 9]; i < box[index / 9] + 3; i++)
            {
                for (int j = box[index % 9]; j < box[index % 9] + 3; j++)
                {
                    if (i != index / 9 && j != index % 9)
                    {
                        mark &= cellMethod(table, i, j, index);
                    }
                }
            }
            if (cellMethod == RecoverCellCandidate)
            {
                cell.ValueNumber = 0;
            }
            return mark;
        }

        /// deal relative cell
        private bool _DealRelativeCell(RelativeCellMethod cellMethod, Cell[,] table, int index)
        {
            bool isSetUniqueCellMethod = false;
            if (cellMethod == SetUniqueCellCandidate)
                isSetUniqueCellMethod = true;
            bool mark = true;
            Cell cell = table[index / 9, index % 9];
            for (int i = 0; i < 9; i++)
            {
                //same column
                if (i != index / 9)
                {//cannot equal to current cell
                    //if any one of value assignment failed, break the loop
                    if (isSetUniqueCellMethod && !mark) break;
                    mark &= cellMethod(table, i, index % 9, index);
                }
                //same row
                if (i != index % 9)
                {//cannot equal to current cell
                    if (isSetUniqueCellMethod && !mark) break;
                    mark &= cellMethod(table, index / 9, i, index);
                }
            }
            for (int i = box[index / 9]; i < box[index / 9] + 3; i++)
            {
                for (int j = box[index % 9]; j < box[index % 9] + 3; j++)
                {
                    if (i != index / 9 && j != index % 9)
                    {
                        if (isSetUniqueCellMethod && !mark) break;
                        mark &= cellMethod(table, i, j, index);
                    }
                }
            }
            if (cellMethod == RemoveCellCandidate && mark)
            {//If remove candidate success, then judement there has only one candidate, if has set the value
                RelativeCellMethod setCandidateMethod = new RelativeCellMethod(SetUniqueCellCandidate);
                mark &= DealRelativeCell(setCandidateMethod, table, index);
            }
            if (cellMethod == RecoverCellCandidate)
            {
                cell.ValueNumber = 0;
            }
            return mark;
        }

        /// Fill cells
        public bool FillCell(Cell[,] table, int index)
        {
            RelativeCellMethod removeCandidateMethod = new RelativeCellMethod(RemoveCellCandidate);
            RelativeCellMethod recoverCandidateMethod = new RelativeCellMethod(RecoverCellCandidate);

            if (index >= 81)
            {//if out of the index, means the sudoku generate successful
                return true;
            }
            if (table[index / 9, index % 9].ValueNumber != 0)
            {//if the index position grid already has value, go to the next index position
                return FillCell(table, index + 1);
            }
            bool mark = true;
            List<int> nextCandidates = new List<int>();
            //presotre the grids candidate order, if all the candidate cannnot use, then recover all the candidates
            nextCandidates.AddRange(table[index / 9, index % 9].Candidate);

            while (table[index / 9, index % 9].Candidate.Count > 0 && mark)
            {//if grids contains over 0 candidates, mark as true
                SetValue(table[index / 9, index % 9]);//set value to grids
                mark &= DealRelativeCell(removeCandidateMethod, table, index);//remove relevant grids
                if (!mark)
                {//if remove candidate failed, then recovery candidates, keep next loop
                    DealRelativeCell(recoverCandidateMethod, table, index);
                }
                else
                {//if remove candidate success, then try the next grid
                    mark &= FillCell(table, index + 1);
                    if (!mark)
                    {
                        DealRelativeCell(recoverCandidateMethod, table, index);
                    }
                    else
                    {//Sudoku generate success
                        return true;
                    }
                }
                mark = !mark;//set mark as negation, keep next loop
            }
            if (table[index / 9, index % 9].Candidate.Count == 0)
            {//if already tried all the candidates but failed, recover this grid candidate as initial values
                table[index / 9, index % 9].Candidate.AddRange(nextCandidates);
                return false;
            }
            return mark;
        }

        /// Show sudoku
        private void Show(Cell[,] table)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("{0,2}", table[i, j].ValueNumber);

                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");

        }

        /// Generate table
        public void StartFillTable()
        {
            Cell[,] table = new Cell[9, 9];
            while (true)
            {
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++) //Initialise sudoku table
                        table[i, j] = new Cell();

                bool mark = FillCell(table, 0);//Filling sudoku table
                if (mark)//If generate success then show it
                    Show(table);
                Console.ReadKey();
            }
        }
    }
}
