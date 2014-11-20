
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;
using System.Data;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace Sudoku
{
    
    public partial class Solver : KryptonForm
    {
        int rand = 5;
        private CellMethods cellMethod = new CellMethods();
        static int EMPTYGRID = 50;
        DataTable dt;
        Cell[,] sudoku = new Cell[9, 9];
        Cell[,] sudokuMirror = new Cell[9, 9];
        int[ , ] originalSudoku = new int[9, 9];
        float currentFontSize = 19;
        int currentValue;
        Color currentForeColor;

        int[] sub = new int[82];
        int i = 0, j = 0;
        int k = 0, subk = 0;

        public Solver()
        {
            dt = new DataTable();
            for (int i = 1; i <= 9; i++)
            {
                dt.Columns.Add("Column"+i.ToString(), typeof(string));
            }
            DataRow dr;
            for (int i = 1; i <= 9; i++)
            {
                dr = dt.NewRow();
                for (int j = 1; j <= dt.Columns.Count; j++)
                {
                    dr[j - 1] = "";
                }
                dt.Rows.Add(dr);
            }
                InitializeComponent();
        }

        #region Sover loading
        private void Solver_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.solverDataGridView.ReadOnly = false;
            this.solverDataGridView.AllowUserToAddRows = false;
            this.solverDataGridView.RowHeadersVisible = false;

            DataBind();
            this.solverDataGridView.ClearSelection();
            InitializeSudokuGrids();
            BuildSudoku();

            foreach (DataGridViewRow rows in this.solverDataGridView.Rows)
            {
                rows.Height = 55;
            }
            InitializeDataGridView(sudoku);
        }
        #endregion

        #region New Solver
        private void NewSolver()
        {
            this.solverDataGridView.ClearSelection();

            sudoku = new Cell[9, 9];
            sudokuMirror = new Cell[9, 9];
            originalSudoku = new int[9, 9];
            currentFontSize = 19;
            currentForeColor = new Color();

            sub = new int[82];
            i = 0;
            j = 0;
            k = 0;
            subk = 0;
            InitializeSudokuGrids();
            BuildSudoku();
            InitializeDataGridView(sudoku);
            CandidatesVisibleRadioButton.Checked = false;
        }
        #endregion

        #region Start Game & Build Sudoku
        private void BuildSudoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dt.Rows[i][j] = sudoku[i, j].ValueNumber;
                }
                IsCellSet();
            }

            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (dr[col.ColumnName].ToString() == "0")
                    dr[col.ColumnName] = "";
                }
            }
            DataBind();
        }
        #endregion

        #region Initialize Sudoku grids value as 0
        private void InitializeSudokuGrids()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = new Cell();
                    sudokuMirror[i, j] = new Cell();
                }
            }
        }
        #endregion
        
        #region Initialize dataGridView
        private void InitializeDataGridView(Cell[,] sudoku)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.solverDataGridView[j, i].ReadOnly = false; // for regenerate new grid
                    if (sudoku[i, j].ValueNumber != 0)
                    {
                        this.solverDataGridView[j, i].ReadOnly = true;
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(108, 123, 139);
                        this.solverDataGridView[j, i].Style.Font = new Font("微软雅黑", 19);
                    }
                    else
                    {
                        this.solverDataGridView[j, i].ReadOnly = false;
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        this.solverDataGridView[j, i].Style.Font = new Font("微软雅黑", 19);
                    }

                    if (i <= 2)
                    {
                        if (j <= 2 || j >= 6)
                            this.solverDataGridView[j, i].Style.BackColor = Color.FromArgb(154, 201, 228);
                    }
                    else if (i >= 6)
                    {
                        if (j <= 2 || j >= 6)
                            this.solverDataGridView[j, i].Style.BackColor = Color.FromArgb(154, 201, 228);
                    }
                    else if (i >= 3 && i <= 5)
                    {
                        if (j >= 3 && j <= 5)
                            this.solverDataGridView[j, i].Style.BackColor = Color.FromArgb(154, 201, 228);
                    }
                }
            }
        }
        #endregion

        #region Data Binding as DataTable
        private void DataBind()
        {
            this.solverDataGridView.DataSource = dt;
        }
        #endregion

        #region Initialize generate sudoku
        private void InitializeSudoku()
        {
            Cell[,] cells = new Cell[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
            bool mark = cellMethod.FillCell(cells, 0);//Fill the grids
            Cell cell;

            if (mark)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        cell = cells[i, j];
                        originalSudoku[i, j] = sudoku[i, j].ValueNumber = cell.ValueNumber;
                    }
                }
            }
        }
        #endregion

        #region Generate values
        private void Difficulty()
        {
            List<int> _reduplicate = new List<int>();

            for (int i = 0; i < 81; i++)
            {
                _reduplicate.Add(i);
            }

            int x;
            int y;
            int n;

            for (int i = 0; i < EMPTYGRID; i++)
            {
                Thread.Sleep(26);
                n = _reduplicate[new Random().Next(0, _reduplicate.Count)];
                _reduplicate.Remove(n);

                x = n / 9;
                y = n % 9;

                sudoku[x, y].ValueNumber = 0;
            }
        }
        #endregion

        #region Show candidates
        public void ShowCandidates()
        {
            PossibibleCandidates();
            //this.solverDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.solverDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].IsSet == false)
                    {
                        string temp = null;
                        this.solverDataGridView[j, i].Style.Font = new Font("微软雅黑", 10);
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(105,105 ,105);
                        for (int index = 0; index < sudoku[i, j].Candidate.Count; index++)
                        {
                            temp = temp + "" + sudoku[i, j].Candidate[index];
                            dt.Rows[i][j] = temp;
                        }
                    }
                }
            }
        }
        #endregion

        #region Possible candidates
        public void PossibibleCandidates()
        {
            for (int row = 0; row< 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // check all column candidates
                    if (sudoku[row, col].IsSet == true || sudoku[row, col].ValueNumber != 0) continue;
                    for (int t = 0; t < 9; t++)
                    {
                        if (sudoku[t, col].ValueNumber == 0) continue;
                        int num = sudoku[t, col].ValueNumber;
                        if (sudoku[row, col].Candidate.Contains(num) == true)
                            sudoku[row, col].RemoveCandidate(num);
                    }
                    // check all row candidates
                    for (int t = 0; t < 9; t++)
                    {
                        if (sudoku[row, t].ValueNumber == 0) continue;
                        int num = sudoku[row, t].ValueNumber;
                        if (sudoku[row, col].Candidate.Contains(num) == true)
                            sudoku[row, col].RemoveCandidate(num);
                    }
                    // check all box candidates
                    int subcol = 3 * (col / 3);
                    int subrow = 3 * (row / 3);
                    for (int m = subrow; m < subrow+ 3; m++)
                    {
                        for (int n = subcol; n < subcol+ 3; n++)
                        {
                            if (sudoku[m, n].ValueNumber == 0) continue;
                            int num = sudoku[m, n].ValueNumber;
                            if (sudoku[row, col].Candidate.Contains(num) == true)
                                sudoku[row, col].RemoveCandidate(num);
                        }
                    }
                }
            }
        }
        #endregion

        #region Real time candidates
        public void RealTimeCandidates()
        {
            IsCellSet();

            if (CandidatesVisibleRadioButton.Checked)
            {
                ShowCandidates();
            }
        }
        #endregion

        #region Is cell set
        public void IsCellSet()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].ValueNumber == 0)
                    {
                        sudoku[i, j].IsSet = false;
                    }
                    else
                        sudoku[i, j].IsSet = true;
                }
            }
        }
        #endregion

        #region Set setted display style
        public void SetSettedStyle(int row, int col)
        {
            this.solverDataGridView[col, row].Style.Font = new Font("微软雅黑", 19);
            this.solverDataGridView[col, row].Style.ForeColor = Color.FromArgb(255, 140, 0);
        }
        #endregion

        #region Set default display style
        public void SetDefaultStyle()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!this.solverDataGridView[j, i].ReadOnly)
                    {
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(255, 140, 0);
                    }
                    else
                    {
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                    this.solverDataGridView[j, i].Style.Font = new Font("微软雅黑", 19);
                }
            }
        }
        #endregion

        #region Check the rules
        public static bool CheckRules(int num, int i, int j, Cell[,] sudoku)
        {
            int c = 0, r = 0;
            for (c = 0; c < 9; c++)
            {
                if (sudoku[i, c].ValueNumber == num)
                {
                    return false;
                }
            }
            for (r = 0; r < 9; r++)
            {
                if (sudoku[r, j].ValueNumber == num)
                    return false;
            }

            if (i % 3 == 0)
            {
                if (j % 3 == 0)
                {
                    for (r = i; r < 3 + i; r++)
                    {
                        for (c = j; c < j + 3; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 == 1)
                {
                    for (r = i; r < 3 + i; r++)
                    {
                        for (c = j - 1; c < j + 2; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 == 2)
                {
                    for (r = i; r < 3 + i; r++)
                    {
                        for (c = j - 2; c < j + 1; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
            }
            if (i % 3 == 1)
            {
                if (j % 3 == 0)
                {
                    for (r = i - 1; r < 2 + i; r++)
                    {
                        for (c = j; c < j + 3; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 ==1)
                {
                    for(r = i-1; r < 2+i; r ++)
                    {
                        for (c = j-1; c < j+2; c ++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 == 2)
                {
                    for (r = i - 1; r < 2 + i; r++)
                    {
                        for (c = j - 2; c < j + 1; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
            }
            if (i % 3 == 2)
            {
                if (j % 3 == 0)
                {
                    for (r = i - 2; r < 1 + i; r++)
                    {
                        for (c = j; c < j + 3; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 == 1)
                {
                    for (r = i - 2; r < 1 + i; r++)
                    {
                        for (c = j - 1; c < j + 2; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
                if (j % 3 == 2)
                {
                    for (r = i - 2; r < 1 + i; r++)
                    {
                        for (c = j - 2; c < j + 1; c++)
                        {
                            if (sudoku[r, c].ValueNumber == num)
                                return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        #region Check puzzle valid 
        private void CheckValid_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    sudoku[a, b].ValueNumber = Convert.ToInt32(this.solverDataGridView[b, a].Value.ToString() == "" ? "0" : this.solverDataGridView[b, a].Value.ToString());
                }
            }

            int i = 0, j = 0, k = 0;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].ValueNumber > 0)
                        k++;
                }
            }
            if (k < 17)
            {
                if (MessageBox.Show("This sudoku hasn't a unique solution\nWould you want continue ?", "CAUTION !", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bruteForceButton.Enabled = true;
                }
                else
                {
                    bruteForceButton.Enabled = false;
                }
            }
            else
            {
                bruteForceButton.Enabled = true;
            }
        }
        #endregion

        #region Check puzzle finish
        public bool CheckPuzzleFinish()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!sudoku[i, j].IsSet)
                        return false;
                }
            }
            return true;
        }
        #endregion

        #region Solving Recording
        public void SolvingRecording()
        {

        }
        #endregion
        //=============SOLUTIONS=============

        #region Brute Force
        public void BruteForce()
        {
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].ValueNumber == 0)
                    {
                        sub[k] = i * 9 + j;
                        k++;
                    }
                }
            }
            subk = 0;
            ResultsFillInCell(subk, k, sudoku, sub);

            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }

        // Fill the cells
        public static void ResultsFillInCell(int subk, int k, Cell[,] sudoku, int[] sub)
        {
            int num, i, j;

            while (subk < k && subk >= 0)
            {
                i = sub[subk] / 9;
                j = sub[subk] % 9;
                int mark = 0;
                for (num = (sudoku[i, j].ValueNumber) + 1; num <= 9; num++)
                {
                    if (CheckRules(num, i, j, sudoku))
                    {
                        sudoku[i, j].ValueNumber = num;
                        mark = 1;
                        break;
                    }
                }
                if (mark == 0)
                {
                    mark = 0;
                    for (int sb = subk; sb < k; sb++)
                    {
                        i = sub[sb] / 9;
                        j = sub[sb] % 9;
                        sudoku[i, j].ValueNumber = 0;
                    }
                    subk--;
                    ResultsFillInCell(subk, k, sudoku, sub);
                    return;
                }
                subk++;
            }
        }
        #endregion

        #region Naked Single
        public void NakedSingle()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].Candidate.Count == 1)
                    {
                        sudoku[i, j].ValueNumber = sudoku[i, j].Candidate[0];
                        SetSettedStyle(i, j);
                        IsCellSet();
                    }
                }
            }
            RealTimeCandidates();
        }
        #endregion

        #region Hidden Single
        public void HiddenSingle()
        {
            for (int containNumber = 1; containNumber < 10; containNumber++)
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        //check the col
                        int appearTimeA = 0, hiddenSingleRow = 0, hiddenSingleValueA = 0;
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[t, col].IsSet)
                            {
                                if (sudoku[t, col].Candidate.Contains(containNumber) && sudoku[t, col].Candidate.Count > 1)
                                {
                                    appearTimeA++;
                                    hiddenSingleRow = t;
                                    hiddenSingleValueA = containNumber;
                                }
                            }
                        }
                        if (appearTimeA == 1) // if this number appear once only, then set the grid value as this number
                        {
                            sudoku[hiddenSingleRow, col].ValueNumber = hiddenSingleValueA;
                            SetSettedStyle(hiddenSingleRow, col);
                        }

                        //check the row
                        int appearTimeB = 0, hiddenSingleCol = 0, hiddenSingleValueB = 0;
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[row, t].IsSet)
                            {
                                if (sudoku[row, t].Candidate.Contains(containNumber) && sudoku[row, t].Candidate.Count > 1)
                                {
                                    appearTimeB++;
                                    hiddenSingleCol = t;
                                    hiddenSingleValueB = containNumber;
                                }
                            }
                        }
                        if (appearTimeB == 1)
                        {
                            sudoku[row, hiddenSingleCol].ValueNumber = hiddenSingleValueB;
                            SetSettedStyle(row, hiddenSingleCol);
                        }

                        //check the subgrid
                        int subcol = 3 * (col / 3);
                        int subrow = 3 * (row / 3);
                        int appearTimeC = 0, hiddenSingleSubgridRow = 0, hiddenSingleSubgridCol = 0, hiddenSingleValueC = 0;
                        for (int m = subrow; m < subrow + 3; m++)
                        {
                            for (int n = subcol; n < subcol + 3; n++)
                            {
                                if (!sudoku[m, n].IsSet)
                                {
                                    if (sudoku[m, n].Candidate.Contains(containNumber) && sudoku[m, n].Candidate.Count > 1)
                                    {
                                        appearTimeC++;
                                        hiddenSingleSubgridRow = m;
                                        hiddenSingleSubgridCol = n;
                                        hiddenSingleValueC = containNumber;
                                    }
                                }
                            }
                        }
                        if (appearTimeC == 1)
                        {
                            sudoku[hiddenSingleSubgridRow, hiddenSingleSubgridCol].ValueNumber = hiddenSingleValueC;
                            SetSettedStyle(hiddenSingleSubgridRow, hiddenSingleSubgridCol);
                        }
                    }
                }
            }
            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }
        #endregion

        #region Naked Pair
        public void NakedPair()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // check the col
                    List<Grid> nakedPairGridCol = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        if (!sudoku[t, col].IsSet && sudoku[t, col].Candidate.Count == 2)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = t;
                            grid.GridCol = col;
                            grid.GridCandidateValue.Add(sudoku[t, col].Candidate[0]);
                            grid.GridCandidateValue.Add(sudoku[t, col].Candidate[1]);
                            nakedPairGridCol.Add(grid); // pick up all the girds which only has 2 candidate values
                        }
                    }
                    for (int i = 0; i < nakedPairGridCol.Count; i++)
                    {
                        for (int j = 0; j < nakedPairGridCol.Count; j++)
                        {
                            if (i != j) //check if there has a just one grid contains exactly the same candidate values
                                if (nakedPairGridCol[i].GridCandidateValue.Contains(nakedPairGridCol[j].GridCandidateValue[0])
                                    && nakedPairGridCol[i].GridCandidateValue.Contains(nakedPairGridCol[j].GridCandidateValue[1]))
                                {
                                    for (int m = 0; m < 9; m++)
                                    {
                                        if (m != nakedPairGridCol[i].GridRow)
                                        {// remove pair values with all grids in current column 
                                            sudoku[m, nakedPairGridCol[i].GridCol].RemoveCandidate(nakedPairGridCol[i].GridCandidateValue[0]);
                                            sudoku[m, nakedPairGridCol[i].GridCol].RemoveCandidate(nakedPairGridCol[i].GridCandidateValue[1]);
                                        }
                                    } // add pair values for naked pair grids
                                    sudoku[nakedPairGridCol[i].GridRow, nakedPairGridCol[i].GridCol].AddCandidate(nakedPairGridCol[i].GridCandidateValue[0]);
                                    sudoku[nakedPairGridCol[i].GridRow, nakedPairGridCol[i].GridCol].AddCandidate(nakedPairGridCol[i].GridCandidateValue[1]);
                                }
                        }
                    }

                    //check the row
                    List<Grid> nakedPairGridRow = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        if (!sudoku[row, t].IsSet && sudoku[row, t].Candidate.Count == 2)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = row;
                            grid.GridCol = t;
                            grid.GridCandidateValue.Add(sudoku[row, t].Candidate[0]);
                            grid.GridCandidateValue.Add(sudoku[row, t].Candidate[1]);
                            nakedPairGridRow.Add(grid);
                        }
                    }
                    for (int i = 0; i < nakedPairGridRow.Count; i++)
                    {
                        for (int j = 0; j < nakedPairGridRow.Count; j++)
                        {
                            if (i != j)
                                if (nakedPairGridRow[i].GridCandidateValue.Contains(nakedPairGridRow[j].GridCandidateValue[0])
                                    && nakedPairGridRow[i].GridCandidateValue.Contains(nakedPairGridRow[j].GridCandidateValue[1]))
                                {
                                    for (int m = 0; m < 9; m++)
                                    {
                                        if (m != nakedPairGridRow[i].GridCol)
                                        {
                                            sudoku[nakedPairGridRow[i].GridRow, m].RemoveCandidate(nakedPairGridRow[i].GridCandidateValue[0]);
                                            sudoku[nakedPairGridRow[i].GridRow, m].RemoveCandidate(nakedPairGridRow[i].GridCandidateValue[1]);
                                        }
                                    }
                                    sudoku[nakedPairGridRow[i].GridRow, nakedPairGridRow[i].GridCol].AddCandidate(nakedPairGridRow[i].GridCandidateValue[0]);
                                    sudoku[nakedPairGridRow[i].GridRow, nakedPairGridRow[i].GridCol].AddCandidate(nakedPairGridRow[i].GridCandidateValue[1]);
                                }
                        }
                    }

                    //check the box
                    List<Grid> nakedPairGridBox = new List<Grid> { };
                    int subcol = 3 * (col / 3);
                    int subrow = 3 * (row / 3);
                    for (int m = subrow; m < subrow + 3; m++)
                    {
                        for (int n = subcol; n < subcol + 3; n++)
                        {
                            if (!sudoku[m, n].IsSet && sudoku[m, n].Candidate.Count == 2)
                            {
                                Grid grid = new Grid();
                                grid.GridRow = m;
                                grid.GridCol = n;
                                grid.GridCandidateValue.Add(sudoku[m, n].Candidate[0]);
                                grid.GridCandidateValue.Add(sudoku[m, n].Candidate[1]);
                                nakedPairGridBox.Add(grid);
                            }
                        }
                        for (int i = 0; i < nakedPairGridBox.Count; i++)
                        {
                            for (int j = 0; j < nakedPairGridBox.Count; j++)
                            {
                                if (i != j)
                                    if (nakedPairGridBox[i].GridCandidateValue.Contains(nakedPairGridBox[j].GridCandidateValue[0])
                                        && nakedPairGridBox[i].GridCandidateValue.Contains(nakedPairGridBox[j].GridCandidateValue[1]))
                                    {
                                        int subcolB = 3 * (col / 3);
                                        int subrowB = 3 * (row / 3);
                                        for (int mB = subrow; mB < subrow + 3; mB++)
                                        {
                                            for (int nB = subcol; nB < subcol + 3; nB++)
                                            {
                                                {
                                                    sudoku[mB, nB].RemoveCandidate(nakedPairGridBox[i].GridCandidateValue[0]);
                                                    sudoku[mB, nB].RemoveCandidate(nakedPairGridBox[i].GridCandidateValue[1]);
                                                }
                                            }
                                        }
                                        sudoku[nakedPairGridBox[i].GridRow, nakedPairGridBox[i].GridCol].AddCandidate(nakedPairGridBox[i].GridCandidateValue[0]);
                                        sudoku[nakedPairGridBox[i].GridRow, nakedPairGridBox[i].GridCol].AddCandidate(nakedPairGridBox[i].GridCandidateValue[1]);
                                        sudoku[nakedPairGridBox[j].GridRow, nakedPairGridBox[j].GridCol].AddCandidate(nakedPairGridBox[j].GridCandidateValue[0]);
                                        sudoku[nakedPairGridBox[j].GridRow, nakedPairGridBox[j].GridCol].AddCandidate(nakedPairGridBox[j].GridCandidateValue[1]);
                                    }
                            }
                        }
                    }
                }
            }
            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }
        #endregion

        #region Hidden Pair
        public void HiddenPair()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // check the col
                    List<Grid> hiddenPairGridCol = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        if (!sudoku[t, col].IsSet)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = t;
                            grid.GridCol = col;
                            for (int i = 0; i < sudoku[t, col].Candidate.Count; i++)
                            {
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[i]);
                            }
                            hiddenPairGridCol.Add(grid);
                        }
                    }

                    // search number from 1 - 9
                    for (int containNumber = 1; containNumber < 10; containNumber++)
                    {
                        int containNumberAppear = 0;

                        for (int i = 0; i < hiddenPairGridCol.Count; i++)
                        {
                            for (int j = 0; j < hiddenPairGridCol[i].GridCandidateValue.Count; j++)
                            {
                                if (hiddenPairGridCol[i].GridCandidateValue[j] == containNumber)
                                {
                                    containNumberAppear++;
                                }
                            }
                        }
                        if (containNumberAppear != 2) // if this number appearing not equal twice then delete it 
                        {
                            for (int i = 0; i < hiddenPairGridCol.Count; i++)
                            {
                                for (int j = 0; j < hiddenPairGridCol[i].GridCandidateValue.Count; j++)
                                {
                                    hiddenPairGridCol[i].GridCandidateValue.Remove(containNumber);
                                }
                            }
                        }
                    }

                    // delete single candidate number
                    for (int i = 0; i < hiddenPairGridCol.Count; i++)
                    {
                        if (hiddenPairGridCol[i].GridCandidateValue.Count < 2)
                        {
                            hiddenPairGridCol[i].GridCandidateValue.Clear();
                        }
                    }

                    //search hidden pair number
                    for (int i = 0; i < hiddenPairGridCol.Count; i++)
                    {
                        for (int j = 0; j < hiddenPairGridCol.Count; j++)
                        {
                            if (i != j && hiddenPairGridCol[i].GridCandidateValue.Count != 0 && hiddenPairGridCol[j].GridCandidateValue.Count != 0)
                                for (int m = 0; m < hiddenPairGridCol[i].GridCandidateValue.Count; m++)
                                { 
                                    // if there has two grids appear as hidden pair conditions, remove the rest of candidate values of this grid
                                    if (hiddenPairGridCol[i].GridCandidateValue.Contains(hiddenPairGridCol[j].GridCandidateValue[0]) 
                                        && hiddenPairGridCol[i].GridCandidateValue.Contains(hiddenPairGridCol[j].GridCandidateValue[1])) 
                                    {
                                        sudoku[hiddenPairGridCol[i].GridRow, hiddenPairGridCol[i].GridCol].Candidate.Clear();
                                        sudoku[hiddenPairGridCol[i].GridRow, hiddenPairGridCol[i].GridCol].Candidate.AddRange(hiddenPairGridCol[i].GridCandidateValue);
                                        sudoku[hiddenPairGridCol[j].GridRow, hiddenPairGridCol[j].GridCol].Candidate.Clear();
                                        sudoku[hiddenPairGridCol[j].GridRow, hiddenPairGridCol[j].GridCol].Candidate.AddRange(hiddenPairGridCol[j].GridCandidateValue);
                                    }
                                }
                        }
                    }

                     // check the row
                        List<Grid> hiddenPairGridRow = new List<Grid> { };
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[row, t].IsSet)
                            {
                                Grid grid = new Grid();
                                grid.GridRow = row;
                                grid.GridCol = t;
                                for (int i = 0; i < sudoku[row, t].Candidate.Count; i++)
                                {
                                    grid.GridCandidateValue.Add(sudoku[row, t].Candidate[i]);
                                }
                                hiddenPairGridRow.Add(grid);
                            }
                        }
                        // search number from 1 - 9
                        for (int containNumber = 1; containNumber < 10; containNumber++)
                        {
                            int containNumberAppear = 0;

                            for (int i = 0; i < hiddenPairGridRow.Count; i++)
                            {
                                for (int j = 0; j < hiddenPairGridRow[i].GridCandidateValue.Count; j++)
                                {
                                    if (hiddenPairGridRow[i].GridCandidateValue[j] == containNumber)
                                    {
                                        containNumberAppear++;
                                    }
                                }
                            }
                            if (containNumberAppear != 2) // if this number appearing not equals 2 then delete it 
                            {
                                for (int i = 0; i < hiddenPairGridRow.Count; i++)
                                {
                                    for (int j = 0; j < hiddenPairGridRow[i].GridCandidateValue.Count; j++)
                                    {
                                        hiddenPairGridRow[i].GridCandidateValue.Remove(containNumber);
                                    }
                                }
                            }
                        }

                        // delete single candidate number
                        for (int i = 0; i < hiddenPairGridRow.Count; i++)
                        {
                            if (hiddenPairGridRow[i].GridCandidateValue.Count < 2)
                            {
                                hiddenPairGridRow[i].GridCandidateValue.Clear();
                            }
                        }

                        //search hidden pair number
                        for (int i = 0; i < hiddenPairGridRow.Count; i++)
                        {
                            for (int j = 0; j < hiddenPairGridRow.Count; j++)
                            {
                                if (i != j && hiddenPairGridRow[i].GridCandidateValue.Count != 0 && hiddenPairGridRow[j].GridCandidateValue.Count != 0)
                                    for (int m = 0; m < hiddenPairGridRow[i].GridCandidateValue.Count; m++)
                                    {
                                        if (hiddenPairGridRow[i].GridCandidateValue.Contains(hiddenPairGridRow[j].GridCandidateValue[0]) && hiddenPairGridRow[i].GridCandidateValue.Contains(hiddenPairGridRow[j].GridCandidateValue[1]))
                                        {
                                            sudoku[hiddenPairGridRow[i].GridRow, hiddenPairGridRow[i].GridCol].Candidate.Clear();
                                            sudoku[hiddenPairGridRow[i].GridRow, hiddenPairGridRow[i].GridCol].Candidate.AddRange(hiddenPairGridRow[i].GridCandidateValue);
                                            sudoku[hiddenPairGridRow[j].GridRow, hiddenPairGridRow[j].GridCol].Candidate.Clear();
                                            sudoku[hiddenPairGridRow[j].GridRow, hiddenPairGridRow[j].GridCol].Candidate.AddRange(hiddenPairGridRow[j].GridCandidateValue);
                                        }
                                    }
                            }
                        }

                    // check the box
                    List<Grid> nakedPairGridBox = new List<Grid> { };
                    int subcol = 3 * (col / 3);
                    int subrow = 3 * (row / 3);
                    for (int m = subrow; m < subrow + 3; m++)
                    {
                        for (int n = subcol; n < subcol + 3; n++)
                        {
                            if (!sudoku[m, n].IsSet)
                            {
                                Grid grid = new Grid();
                                grid.GridRow = m;
                                grid.GridCol = n;
                                for (int i = 0; i < sudoku[m, n].Candidate.Count; i++)
                                {
                                    grid.GridCandidateValue.Add(sudoku[m, n].Candidate[i]);
                                }
                                nakedPairGridBox.Add(grid);
                            }
                        }
                    }
                    // search number from 1 - 9
                    for (int containNumber = 1; containNumber < 10; containNumber++)
                    {
                        int containNumberAppear = 0;

                        for (int i = 0; i < nakedPairGridBox.Count; i++)
                        {
                            for (int j = 0; j < nakedPairGridBox[i].GridCandidateValue.Count; j++)
                            {
                                if (nakedPairGridBox[i].GridCandidateValue[j] == containNumber)
                                {
                                    containNumberAppear++;
                                }
                            }
                        }
                        if (containNumberAppear != 2) // if this number appearing not equal twice then delete it 
                        {
                            for (int i = 0; i < nakedPairGridBox.Count; i++)
                            {
                                for (int j = 0; j < nakedPairGridBox[i].GridCandidateValue.Count; j++)
                                {
                                    nakedPairGridBox[i].GridCandidateValue.Remove(containNumber);
                                }
                            }
                        }
                    }

                    // delete single candidate number
                    for (int i = 0; i < nakedPairGridBox.Count; i++)
                    {
                        if (nakedPairGridBox[i].GridCandidateValue.Count < 2)
                        {
                            nakedPairGridBox[i].GridCandidateValue.Clear();
                        }
                    }

                    //search hidden pair number
                    for (int i = 0; i < nakedPairGridBox.Count; i++)
                    {
                        for (int j = 0; j < nakedPairGridBox.Count; j++)
                        {
                            if (i != j && nakedPairGridBox[i].GridCandidateValue.Count != 0 && nakedPairGridBox[j].GridCandidateValue.Count != 0)
                                for (int m = 0; m < nakedPairGridBox[i].GridCandidateValue.Count; m++)
                                {
                                    if (nakedPairGridBox[i].GridCandidateValue.Contains(nakedPairGridBox[j].GridCandidateValue[0]) && nakedPairGridBox[i].GridCandidateValue.Contains(nakedPairGridBox[j].GridCandidateValue[1]))
                                    {
                                        sudoku[nakedPairGridBox[i].GridRow, nakedPairGridBox[i].GridCol].Candidate.Clear();
                                        sudoku[nakedPairGridBox[i].GridRow, nakedPairGridBox[i].GridCol].Candidate.AddRange(nakedPairGridBox[i].GridCandidateValue);
                                        sudoku[nakedPairGridBox[j].GridRow, nakedPairGridBox[j].GridCol].Candidate.Clear();
                                        sudoku[nakedPairGridBox[j].GridRow, nakedPairGridBox[j].GridCol].Candidate.AddRange(nakedPairGridBox[j].GridCandidateValue);
                                    }
                                }
                        }
                    }
                }
            }
            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }
        #endregion

        #region Naked Triple
        public void NakedTriple()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // check the col
                    List<Grid> nakedTripleGridCol = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        // if the candidate number !=1 & > 3 save it 
                        if (!sudoku[t, col].IsSet && sudoku[t, col].Candidate.Count < 4)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = t;
                            grid.GridCol = col;
                            for (int i = 0; i < sudoku[t, col].Candidate.Count; i++)
                            {
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[i]);
                            }
                            nakedTripleGridCol.Add(grid);
                        }
                    }

                    Array unionArray1 = new Array[] { };
                    int cell1 = 0, cell2 = 0, cell3 = 0;
                    List<int> nakedTripleRow = new List<int>();
                    for (int o = 0; o < nakedTripleGridCol.Count; o++)
                    {
                        for (int p = 0; p < nakedTripleGridCol.Count; p++)
                        {
                            for (int q = 0; q < nakedTripleGridCol.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the union of three grid candidate numbers
                                {
                                    IEnumerable<int> union = nakedTripleGridCol[o].GridCandidateValue.Union(nakedTripleGridCol[p].GridCandidateValue);
                                    union = union.Union(nakedTripleGridCol[q].GridCandidateValue);
                                    unionArray1 = union.ToArray();
                                    if (unionArray1.Length == 3)
                                    {
                                        cell1 = nakedTripleGridCol[o].GridRow;
                                        cell2 = nakedTripleGridCol[p].GridRow;
                                        cell3 = nakedTripleGridCol[q].GridRow;
                                        if (nakedTripleRow.Contains(cell1)
                                            || nakedTripleRow.Contains(cell2)
                                            || nakedTripleRow.Contains(cell3))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            nakedTripleRow.Add(cell1);
                                            nakedTripleRow.Add(cell2);
                                            nakedTripleRow.Add(cell3);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (nakedTripleRow.Count == 3 && unionArray1.Length != 0)
                    {
                        for (j = 0; j < 9; j++)
                        {
                            if (nakedTripleRow[0] != j && nakedTripleRow[1] != j && nakedTripleRow[2] != j && !sudoku[j, col].IsSet)
                            {
                                sudoku[j, col].RemoveCandidate((int)unionArray1.GetValue(0)); // remove other grid candidates
                                sudoku[j, col].RemoveCandidate((int)unionArray1.GetValue(1)); // remove other grid candidates
                                sudoku[j, col].RemoveCandidate((int)unionArray1.GetValue(2)); // remove other grid candidates
                            }
                        }
                    }

                    // check the row
                    List<Grid> nakedTripleGridRow = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        // if the candidate number !=1 & > 3 save it 
                        if (!sudoku[row, t].IsSet && sudoku[row, t].Candidate.Count < 4)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = row;
                            grid.GridCol = t;
                            for (int i = 0; i < sudoku[row, t].Candidate.Count; i++)
                            {
                                grid.GridCandidateValue.Add(sudoku[row, t].Candidate[i]);
                            }
                            nakedTripleGridRow.Add(grid);
                        }
                    }

                    Array unionArray2 = new Array[] { };
                    int cell4 = 0, cell5 = 0, cell6 = 0;
                    List<int> nakedTripleCol = new List<int>();
                    for (int o = 0; o < nakedTripleGridRow.Count; o++)
                    {
                        for (int p = 0; p < nakedTripleGridRow.Count; p++)
                        {
                            for (int q = 0; q < nakedTripleGridRow.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the union of three grid candidate numbers
                                {
                                    IEnumerable<int> union = nakedTripleGridRow[o].GridCandidateValue.Union(nakedTripleGridRow[p].GridCandidateValue);
                                    union = union.Union(nakedTripleGridRow[q].GridCandidateValue);
                                    unionArray2 = union.ToArray();
                                    if (unionArray2.Length == 3)
                                    {
                                        cell4 = nakedTripleGridRow[o].GridCol;
                                        cell5 = nakedTripleGridRow[p].GridCol;
                                        cell6 = nakedTripleGridRow[q].GridCol;
                                        if (nakedTripleCol.Contains(cell4)
                                            || nakedTripleCol.Contains(cell5)
                                            || nakedTripleCol.Contains(cell6))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            nakedTripleCol.Add(cell4);
                                            nakedTripleCol.Add(cell5);
                                            nakedTripleCol.Add(cell6);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (nakedTripleCol.Count == 3 && unionArray2.Length != 0)
                    {
                        for (j = 0; j < 9; j++)
                        {
                            if (nakedTripleCol[0] != j && nakedTripleCol[1] != j && nakedTripleCol[2] != j && !sudoku[row, j].IsSet)
                            {
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(0)); // remove other grid candidates
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(1)); // remove other grid candidates
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(2)); // remove other grid candidates
                            }
                        }
                    }

                    // check the box
                    List<Grid> nakedTripleGridBox = new List<Grid> { };
                    int subcol = 3 * (col / 3);
                    int subrow = 3 * (row / 3);
                    for (int m = subrow; m < subrow + 3; m++)
                    {
                        for (int n = subcol; n < subcol + 3; n++)
                        {
                            // if the candidate number !=1 & > 3 save it 
                            if (!sudoku[row, col].IsSet && sudoku[row, col].Candidate.Count < 4)
                            {
                                Grid grid = new Grid();
                                grid.GridRow = row;
                                grid.GridCol = col;
                                for (int i = 0; i < sudoku[row, col].Candidate.Count; i++)
                                {
                                    grid.GridCandidateValue.Add(sudoku[row, col].Candidate[i]);
                                }
                                nakedTripleGridBox.Add(grid);
                            }
                        }
                    }

                    Array unionArray3 = new Array[] { };
                    List<Grid> cellBox = new List<Grid>();
                    List<Grid> nakedTripleBox = new List<Grid>();
                    for (int o = 0; o < nakedTripleGridBox.Count; o++)
                    {
                        for (int p = 0; p < nakedTripleGridBox.Count; p++)
                        {
                            for (int q = 0; q < nakedTripleGridBox.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the union of three grid candidate numbers
                                {
                                    IEnumerable<int> union = nakedTripleGridBox[o].GridCandidateValue.Union(nakedTripleGridBox[p].GridCandidateValue);
                                    union = union.Union(nakedTripleGridBox[q].GridCandidateValue);
                                    unionArray3 = union.ToArray();
                                    if (unionArray3.Length == 3)
                                    {
                                        cellBox.Add(nakedTripleGridBox[o]);
                                        cellBox.Add(nakedTripleGridBox[p]);
                                        cellBox.Add(nakedTripleGridBox[q]);
                                        if (nakedTripleBox.Count == 0 
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[0].GridRow) // [0] need check again
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[1].GridRow)
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[2].GridRow))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            nakedTripleBox.Add(cellBox[0]);
                                            nakedTripleBox.Add(cellBox[1]);
                                            nakedTripleBox.Add(cellBox[2]);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (nakedTripleBox.Count == 3 && unionArray3.Length != 0)
                    {
                        int subcolB = 3 * (col / 3);
                        int subrowB = 3 * (row / 3);
                        for (int mB = subrow; mB < subrow + 3; mB++)
                        {
                            for (int nB = subcol; nB < subcol + 3; nB++)
                            {
                                if (nakedTripleBox[0].GridRow != mB && nakedTripleBox[0].GridCol !=nB &&
                                    nakedTripleBox[1].GridRow != mB && nakedTripleBox[1].GridCol !=nB &&
                                    nakedTripleBox[2].GridRow != mB && nakedTripleBox[2].GridCol !=nB &&
                                    !sudoku[row, col].IsSet)
                                {
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(0)); // remove other grid candidates
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(1)); // remove other grid candidates
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(2)); // remove other grid candidates
                                }
                            }
                        }
                    }
                }
            }
            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }
        #endregion

        #region Hidden Triple
        public void HiddenTriple()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // check the col
                    List<Grid> hiddenTripleGridCol = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        // if the candidate number !=1 & > 3 save it 
                        if (!sudoku[t, col].IsSet && sudoku[t, col].Candidate.Count < 4)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = t;
                            grid.GridCol = col;
                            for (int i = 0; i < sudoku[t, col].Candidate.Count; i++)
                            {
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[i]);
                            }
                            hiddenTripleGridCol.Add(grid);
                        }
                    }

                    Array intersectArray1 = new Array[] { };
                    int cell1 = 0, cell2 = 0, cell3 = 0;
                    List<int> hiddenTripleRow = new List<int>();
                    for (int o = 0; o < hiddenTripleGridCol.Count; o++)
                    {
                        for (int p = 0; p < hiddenTripleGridCol.Count; p++)
                        {
                            for (int q = 0; q < hiddenTripleGridCol.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the intersect of three grid candidate numbers
                                {
                                    IEnumerable<int> intersect = hiddenTripleGridCol[o].GridCandidateValue.Intersect(hiddenTripleGridCol[p].GridCandidateValue);
                                    intersect = intersect.Intersect(hiddenTripleGridCol[q].GridCandidateValue);
                                    intersectArray1 = intersect.ToArray();
                                    if (intersectArray1.Length == 3)
                                    {
                                        cell1 = hiddenTripleGridCol[o].GridRow;
                                        cell2 = hiddenTripleGridCol[p].GridRow;
                                        cell3 = hiddenTripleGridCol[q].GridRow;
                                        if (hiddenTripleRow.Contains(cell1)
                                            || hiddenTripleRow.Contains(cell2)
                                            || hiddenTripleRow.Contains(cell3))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            hiddenTripleRow.Add(cell1);
                                            hiddenTripleRow.Add(cell2);
                                            hiddenTripleRow.Add(cell3);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (hiddenTripleRow.Count == 3 && intersectArray1.Length != 0)
                    {
                        for (j = 0; j < 9; j++)
                        {
                            if (hiddenTripleRow[0] != j && hiddenTripleRow[1] != j && hiddenTripleRow[2] != j && !sudoku[j, col].IsSet)
                            {
                                sudoku[j, col].RemoveCandidate((int)intersectArray1.GetValue(0)); // remove other grid candidates
                                sudoku[j, col].RemoveCandidate((int)intersectArray1.GetValue(1)); // remove other grid candidates
                                sudoku[j, col].RemoveCandidate((int)intersectArray1.GetValue(2)); // remove other grid candidates
                            }
                        }
                    }

                    // check the row
                    List<Grid> nakedTripleGridRow = new List<Grid> { };
                    for (int t = 0; t < 9; t++)
                    {
                        // if the candidate number !=1 & > 3 save it 
                        if (!sudoku[row, t].IsSet && sudoku[row, t].Candidate.Count < 4)
                        {
                            Grid grid = new Grid();
                            grid.GridRow = row;
                            grid.GridCol = t;
                            for (int i = 0; i < sudoku[row, t].Candidate.Count; i++)
                            {
                                grid.GridCandidateValue.Add(sudoku[row, t].Candidate[i]);
                            }
                            nakedTripleGridRow.Add(grid);
                        }
                    }

                    Array unionArray2 = new Array[] { };
                    int cell4 = 0, cell5 = 0, cell6 = 0;
                    List<int> nakedTripleCol = new List<int>();
                    for (int o = 0; o < nakedTripleGridRow.Count; o++)
                    {
                        for (int p = 0; p < nakedTripleGridRow.Count; p++)
                        {
                            for (int q = 0; q < nakedTripleGridRow.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the union of three grid candidate numbers
                                {
                                    IEnumerable<int> union = nakedTripleGridRow[o].GridCandidateValue.Union(nakedTripleGridRow[p].GridCandidateValue);
                                    union = union.Union(nakedTripleGridRow[q].GridCandidateValue);
                                    unionArray2 = union.ToArray();
                                    if (unionArray2.Length == 3)
                                    {
                                        cell4 = nakedTripleGridRow[o].GridCol;
                                        cell5 = nakedTripleGridRow[p].GridCol;
                                        cell6 = nakedTripleGridRow[q].GridCol;
                                        if (nakedTripleCol.Contains(cell4)
                                            || nakedTripleCol.Contains(cell5)
                                            || nakedTripleCol.Contains(cell6))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            nakedTripleCol.Add(cell4);
                                            nakedTripleCol.Add(cell5);
                                            nakedTripleCol.Add(cell6);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (nakedTripleCol.Count == 3 && unionArray2.Length != 0)
                    {
                        for (j = 0; j < 9; j++)
                        {
                            if (nakedTripleCol[0] != j && nakedTripleCol[1] != j && nakedTripleCol[2] != j && !sudoku[row, j].IsSet)
                            {
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(0)); // remove other grid candidates
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(1)); // remove other grid candidates
                                sudoku[row, j].RemoveCandidate((int)unionArray2.GetValue(2)); // remove other grid candidates
                            }
                        }
                    }

                    // check the box
                    List<Grid> nakedTripleGridBox = new List<Grid> { };
                    int subcol = 3 * (col / 3);
                    int subrow = 3 * (row / 3);
                    for (int m = subrow; m < subrow + 3; m++)
                    {
                        for (int n = subcol; n < subcol + 3; n++)
                        {
                            // if the candidate number !=1 & > 3 save it 
                            if (!sudoku[row, col].IsSet && sudoku[row, col].Candidate.Count < 4)
                            {
                                Grid grid = new Grid();
                                grid.GridRow = row;
                                grid.GridCol = col;
                                for (int i = 0; i < sudoku[row, col].Candidate.Count; i++)
                                {
                                    grid.GridCandidateValue.Add(sudoku[row, col].Candidate[i]);
                                }
                                nakedTripleGridBox.Add(grid);
                            }
                        }
                    }

                    Array unionArray3 = new Array[] { };
                    List<Grid> cellBox = new List<Grid>();
                    List<Grid> nakedTripleBox = new List<Grid>();
                    for (int o = 0; o < nakedTripleGridBox.Count; o++)
                    {
                        for (int p = 0; p < nakedTripleGridBox.Count; p++)
                        {
                            for (int q = 0; q < nakedTripleGridBox.Count; q++)
                            {
                                if (o != p && o != q && p != q) //get the union of three grid candidate numbers
                                {
                                    IEnumerable<int> union = nakedTripleGridBox[o].GridCandidateValue.Union(nakedTripleGridBox[p].GridCandidateValue);
                                    union = union.Union(nakedTripleGridBox[q].GridCandidateValue);
                                    unionArray3 = union.ToArray();
                                    if (unionArray3.Length == 3)
                                    {
                                        cellBox.Add(nakedTripleGridBox[o]);
                                        cellBox.Add(nakedTripleGridBox[p]);
                                        cellBox.Add(nakedTripleGridBox[q]);
                                        if (nakedTripleBox.Count == 0
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[0].GridRow) // [0] need check again
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[1].GridRow)
                                            || nakedTripleBox[0].GridRow.Equals(cellBox[2].GridRow))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            nakedTripleBox.Add(cellBox[0]);
                                            nakedTripleBox.Add(cellBox[1]);
                                            nakedTripleBox.Add(cellBox[2]);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (nakedTripleBox.Count == 3 && unionArray3.Length != 0)
                    {
                        int subcolB = 3 * (col / 3);
                        int subrowB = 3 * (row / 3);
                        for (int mB = subrow; mB < subrow + 3; mB++)
                        {
                            for (int nB = subcol; nB < subcol + 3; nB++)
                            {
                                if (nakedTripleBox[0].GridRow != mB && nakedTripleBox[0].GridCol != nB &&
                                    nakedTripleBox[1].GridRow != mB && nakedTripleBox[1].GridCol != nB &&
                                    nakedTripleBox[2].GridRow != mB && nakedTripleBox[2].GridCol != nB &&
                                    !sudoku[row, col].IsSet)
                                {
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(0)); // remove other grid candidates
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(1)); // remove other grid candidates
                                    sudoku[mB, nB].RemoveCandidate((int)unionArray3.GetValue(2)); // remove other grid candidates
                                }
                            }
                        }
                    }
                }
            }
            PossibibleCandidates();
            IsCellSet();
            BuildSudoku();
            RealTimeCandidates();
        }
        #endregion

        #region Pointing Pair
        public void PointingPair()
        {
            
        }
        #endregion

        #region Pointing Triple
        public void PointingTriple()
        {

        }
        #endregion

        #region X Wing
        public void XWing()
        {
            for (int containNumber = 0; containNumber < 9; containNumber++)
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        //check the col
                        int appearTimeA = 0, appearXTimeA = 0;
                        int[] xWingRowA = new int[2];
                        int[] xWingColA = new int[2];
                        List<Grid> xWingGridColA = new List<Grid> { };
                        List<Grid> xWingGridColB = new List<Grid> { };
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[t, col].IsSet)
                            {
                                Grid grid = new Grid();
                                if (sudoku[t, col].Candidate.Contains(containNumber))
                                {
                                    appearTimeA++;
                                }
                                grid.GridRow = t;
                                grid.GridCol = col;
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[0]);
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[1]);
                                xWingGridColA.Add(grid);
                            }
                        }
                        if (appearTimeA == 2) // if this number appear twice, save the appear row position
                        {
                            xWingColA[0] = xWingGridColA[0].GridRow;
                            xWingColA[1] = xWingGridColA[1].GridRow;
                        }
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[t, col].IsSet && t == xWingColA[0])
                            {
                                Grid grid = new Grid();
                                // check if there has a grid's candidate contains this number
                                if (sudoku[t, col].Candidate.Contains(containNumber)) 
                                {
                                    appearXTimeA++;
                                }
                                grid.GridRow = t; // store the row, column number
                                grid.GridCol = col;
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[0]);
                                grid.GridCandidateValue.Add(sudoku[t, col].Candidate[1]);
                                xWingGridColB.Add(grid);
                            }
                        }
                        if (appearXTimeA == 2 &&
                            xWingGridColA[0].GridRow == xWingGridColB[0].GridRow &&
                            xWingGridColA[1].GridRow == xWingGridColB[1].GridRow) // if in the next column still have unique pair grids 
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                if (k != xWingGridColA[0].GridCol && k != xWingGridColB[0].GridCol) // if the pair grids still contains the same value
                                {
                                    sudoku[xWingGridColA[0].GridRow, k].RemoveCandidate(containNumber);
                                    sudoku[xWingGridColA[1].GridRow, k].RemoveCandidate(containNumber);
                                }
                            }
                        }

                        // check the row
                        int appearTimeB = 0, appearXTimeB = 0;
                        int[] xWingRowB = new int[2];
                        int[] xWingColB = new int[2];
                        List<Grid> xWingGridRowA = new List<Grid> { };
                        List<Grid> xWingGridRowB = new List<Grid> { };
                        for (int t = 0; t < 9; t++)
                        {
                            if (!sudoku[row, t].IsSet)
                            {
                                Grid grid = new Grid();
                                if (sudoku[row, t].Candidate.Contains(containNumber))
                                {
                                    appearTimeB++;
                                }
                                grid.GridRow = row;
                                grid.GridCol = t;
                                //grid.GridCandidateValue.Add(sudoku[row, t].Candidate[0]);
                                //grid.GridCandidateValue.Add(sudoku[row, t].Candidate[1]);
                                xWingGridRowA.Add(grid);
                            }
                        }
                        if (appearTimeB == 2)
                        {
                            xWingRowB[0] = xWingGridRowA[0].GridCol;
                            xWingRowB[1] = xWingGridRowA[1].GridCol;
                        }

                        for (int t = 0; t < 9; t++) // check the another row
                        {
                            if (!sudoku[row, t].IsSet && t == xWingRowB[0])
                            {
                                Grid grid = new Grid();
                                if (sudoku[row, t].Candidate.Contains(containNumber))
                                {
                                    appearXTimeB++;
                                }
                                grid.GridRow = row;
                                grid.GridCol = t;
                                //grid.GridCandidateValue.Add(sudoku[row, t].Candidate[0]);
                                //grid.GridCandidateValue.Add(sudoku[row, t].Candidate[1]);
                                xWingGridRowB.Add(grid);
                            }
                        }
                        if (appearXTimeB == 2 &&
                            xWingGridRowA[0].GridCol == xWingGridRowB[0].GridCol &&
                            xWingGridRowA[1].GridCol == xWingGridRowB[1].GridCol)
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                if (k != xWingGridRowA[0].GridRow && k != xWingGridRowB[0].GridRow)
                                {
                                    sudoku[k, xWingGridRowA[0].GridCol].RemoveCandidate(containNumber);
                                    sudoku[k, xWingGridRowA[1].GridCol].RemoveCandidate(containNumber);
                                }
                            }
                        }
                    }
                }
            }
            PossibibleCandidates();
            BuildSudoku();
        }
        #endregion

        //=============BUTTONS=============

        #region Generate button
        private void Generate_Click(object sender, EventArgs e)
        {
            this.solverDataGridView.ReadOnly = false;
            NewSolver();
            InitializeSudoku();
            Difficulty();
            BuildSudoku();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].ValueNumber != 0)
                    {
                        this.solverDataGridView[j, i].ReadOnly = true;
                    }
                    if (!this.solverDataGridView[j, i].ReadOnly)
                    {
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(255, 140, 0);
                    }
                    else
                    {
                        solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                }
            }
        }
        #endregion

        #region Candidates visible button
        private void CandidatesVisibleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CandidatesVisibleRadioButton.Checked)
            {
                ShowCandidates();
            }
            else
            {
                BuildSudoku();
                SetDefaultStyle();
            }
        }
        #endregion

        #region Brute Force button
        private void Solve_Click(object sender, EventArgs e)
        {
            BruteForce();
        }
        #endregion

        #region Naked Single button
        private void nakedSingleButton_Click(object sender, EventArgs e)
        {
            NakedSingle();
        }
        #endregion

        #region Hidden Single button
        private void hiddenSingleButton_Click(object sender, EventArgs e)
        {
            HiddenSingle();
        }
        #endregion

        #region Naked Pair button
        private void nakedPairButton_Click(object sender, EventArgs e)
        {
            NakedPair();
        }
        #endregion

        #region Hidden Pair button
        private void hiddenPairButton_Click(object sender, EventArgs e)
        {
            HiddenPair();
        }
        #endregion

        #region Naked Triple button
        private void nakedTripleButton_Click(object sender, EventArgs e)
        {
            NakedTriple();
        }
        #endregion

        #region Hidden Triple Button
        private void hiddenTripleButton_Click(object sender, EventArgs e)
        {
            HiddenTriple();
        }
        #endregion

        #region Pointing Pair Button
        private void pointingPairButton_Click(object sender, EventArgs e)
        {
            PointingPair();
        }
        #endregion

        #region Pointing Triple
        private void pointingTripleButton_Click(object sender, EventArgs e)
        {
            PointingTriple();
        }
        #endregion 

        #region X Wing Button
        private void xWingButton_Click(object sender, EventArgs e)
        {
            XWing();
        }
        #endregion

        #region Test Grid (example)
        private void TestGrid()
        {
            //int[,] sudokuExample = {{0,9,0,0,1,0,3,0,2}, 
            //                                      {6,0,1,0,0,0,0,0,0}, 
            //                                      {0,2,0,8,0,0,0,9,1}, 
            //                                      {0,0,8,0,0,0,0,0,7},
            //                                      {4,0,0,0,0,8,0,0,3}, 
            //                                      {0,0,0,0,3,1,8,5,0}, 
            //                                      {9,0,0,0,0,2,0,0,0},
            //                                      {0,0,2,0,0,5,0,4,9},
            //                                      {3,0,5,4,9,0,0,2,0}};// naked pair row
            int[,] sudokuExample = {{5,8,7,0,0,0,2,1,0},
                                                    {0,0,3,9,2,0,0,5,7},
                                                    {2,1,9,8,5,7,0,0,0},
                                                    {8,7,5,0,0,6,1,2,0,},
                                                    {0,0,1,5,7,2,3,9,8},
                                                    {0,0,2,1,8,0,0,6,5},
                                                    {7,0,0,0,3,8,9,4,1},
                                                    {1,3,0,0,6,9,5,0,0},
                                                    {0,2,8,0,0,5,6,7,3}}; //naked pair column
            //int[,] sudokuExample = {{4,6,5,0,8,0,3,2,0},
            //                                    {7,9,8,0,3,2,6,0,5},
            //                                    {1,2,3,5,6,0,0,9,8},
            //                                    {8,0,0,2,0,5,0,3,0},
            //                                    {0,0,2,0,0,0,5,0,0},
            //                                    {5,0,0,3,0,6,2,8,0},
            //                                    {0,8,4,0,5,3,1,7,2},
            //                                    {0,0,0,0,2,0,8,5,4},
            //                                    {2,5,7,0,1,0,9,6,3}}; // hidden pair row
            //int[,] sudokuExample = {{6,0,0,8,0,2,7,3,5},
            //                                    {7,0,2,3,5,6,9,4,0},
            //                                    {3,0,0,4,0,7,0,6,2},
            //                                    {1,0,0,9,7,5,0,2,4},
            //                                    {2,0,0,1,8,3,0,7,9},
            //                                    {0,7,9,6,2,4,0,0,3},
            //                                    {4,0,0,5,6,0,2,0,7},
            //                                    {0,6,7,2,4,0,3,0,0},
            //                                    {9,2,0,7,3,8,4,0,6}}; //naked triple col
            //int[,] sudokuExample ={{0,0,4,0,7,1,0,3,0},
            //                                    {2,3,1,0,9,0,0,0,0},
            //                                    {0,6,5,0,0,3,1,0,0},
            //                                    {6,7,8,9,2,4,3,0,0},
            //                                    {1,0,3,0,5,0,0,0,6},
            //                                    {0,0,0,1,3,6,7,0,0},
            //                                    {0,0,9,3,6,0,5,7,0},
            //                                    {0,0,6,0,1,9,8,4,3},
            //                                    {3,0,0,0,0,0,0,0,0}}; // hidden triple row
            //int[,] sudokuExample =  {{4,0,0,1,8,0,0,3,0},
            //                                     {0,3,0,4,0,6,1,0,8},
            //                                     {0,8,1,0,3,0,4,0,0},
            //                                     {2,6,9,3,4,5,7,8,1},
            //                                     {1,4,0,2,7,8,0,6,0},
            //                                     {0,0,8,9,6,1,0,4,2},
            //                                     {8,9,4,0,0,0,6,1,3},
            //                                     {0,0,0,8,1,4,0,7,0},
            //                                     {0,1,0,6,9,3,8,0,4}}; // pointing pair
            //int[,] sudokuExample = {{0,0,8,0,0,5,3,0,0},
            //                                    {0,5,0,0,1,0,7,9,0},
            //                                    {0,0,0,7,0,3,0,0,0},
            //                                    {1,0,0,0,3,0,9,0,7},
            //                                    {0,9,0,5,2,1,6,4,0},
            //                                    {4,0,0,9,7,0,0,0,2},
            //                                    {0,0,0,6,0,9,0,0,0},
            //                                    {0,3,0,1,8,2,0,7,6},
            //                                    {0,0,6,3,0,7,8,0,9}}; // pointing triple
            //int[,] sudokuExample ={{1,0,0,0,0,0,5,6,9},
            //                                    {4,9,2,0,5,6,1,0,8},
            //                                    {0,5,6,1,0,9,2,4,0},
            //                                    {0,0,9,6,4,0,8,0,1},
            //                                    {0,6,4,0,1,0,0,0,0},
            //                                    {2,1,8,0,3,5,6,0,4},
            //                                    {0,4,0,5,0,0,0,1,6},
            //                                    {9,0,5,0,6,1,4,0,2},
            //                                    {6,2,1,0,0,0,0,0,5}}; // X-wing col

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    sudoku[row, col].ValueNumber = sudokuExample[row, col];
                }
            }
            BuildSudoku();
            ShowCandidates();
        }
        #endregion

        //=============EVENTS=============

        #region Quit form animation
        private void Quit(object sender, EventArgs e)
        {
            int recordx = this.Left;
            int recordy = this.Top;
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(rand);
                int y = random.Next(rand);
                if (x % 2 == 0)
                {
                    this.Left = this.Left + x;
                }
                else
                {
                    this.Left = this.Left - x;
                }
                if (y % 2 == 0)
                {
                    this.Top = this.Top + y;
                }
                else
                {
                    this.Top = this.Top - y;
                }
                this.Left = recordx;
                this.Top = recordy;
            }
            this.Hide();
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
        }
        #endregion

        #region Keyborad responses
        private void KeyboardPressUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        #endregion

        #region Closing effect
        private void Solver_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form shake
            int recordx = this.Left;
            int recordy = this.Top;
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(rand);
                int y = random.Next(rand);
                if (x % 2 == 0)
                {
                    this.Left = this.Left + x;
                }
                else
                {
                    this.Left = this.Left - x;
                }
                if (y % 2 == 0)
                {
                    this.Top = this.Top + y;
                }
                else
                {
                    this.Top = this.Top - y;
                }
                this.Left = recordx;
                this.Top = recordy;
            }
            this.Hide();
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
        }
        #endregion

        #region Cell End Edit (Check user input 1-9 & set condition)
        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int i = 1;
                if ((!int.TryParse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out i))  // if input invalid value, set the grid as empty
                    || (int.TryParse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out i) && i > 9))
                {
                    this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
                }

                if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
                {
                    this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
                    sudoku[e.RowIndex, e.ColumnIndex].IsSet = false;
                    sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = 0;
                }
                else if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value != null && this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.Font.Size == 19)
                {
                    //dont change the big world which is given by program 
                    if (int.Parse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString()) == 0)
                    {
                        this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
                        sudoku[e.RowIndex, e.ColumnIndex].IsSet = false;
                        sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = 0;
                    }
                    else
                    {
                        sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = int.Parse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
                    }
                    sudoku[e.RowIndex, e.ColumnIndex].IsSet = true;
                    this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(255, 140, 0); // set user input value color
                }
                //DataSetShow.Text = "" + this.sudoku[e.RowIndex, e.ColumnIndex].IsSet
                //                                    + " \nrow " + e.RowIndex
                //                                    + " \ncol " + e.ColumnIndex
                //                                    + " \nval " + sudoku[e.RowIndex, e.ColumnIndex].ValueNumber;
            }
        }
        #endregion

        #region Cell mouse enter
        Color currentBgColor;
        private void CellMouseHightlight(object sender, DataGridViewCellEventArgs e)
        {
            currentBgColor = this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor;
            currentForeColor = this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor;
            this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(255, 215, 0);
        }
        #endregion

        #region Cell mouse leave
        private void CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = currentBgColor;
        }
        #endregion

        #region Cell click
        private void solverDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CandidatesVisibleRadioButton.Checked == true)
            {
                this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = currentForeColor;
                //if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.Font.Size == 19 &&  this.solverDataGridView[e.ColumnIndex, e.RowIndex].ReadOnly == true)
                //{
                //    this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(255, 140, 0);
                //}
                //else if ()

                //currentFontSize = this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.Font.Size;
                //currentForeColor = this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor;
                //// 格式不对！！
                //if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                //{
                //    currentValue = int.Parse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
                //}
            }

            RealTimeCandidates();
        }
        #endregion

        #region Cell double click
        private void solverDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sudoku[e.RowIndex, e.ColumnIndex].Candidate.Count == 1)
            {
                this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(0, 0, 0);
                this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.Font = new Font("微软雅黑", 19);
                if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == null)
                {
                    sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = 0;
                }
                else
                {
                    if (this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                    {
                        sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = int.Parse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
                        sudoku[e.RowIndex, e.ColumnIndex].IsSet = true;
                        this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(255, 140, 0);
                    }
                }
            }
        }
        #endregion

        #region Cell content click
        private void solverDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sudoku[e.RowIndex, e.ColumnIndex].Candidate.Count == 1)
            {
                this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(0, 0, 0);
                this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.Font = new Font("微软雅黑", 19);
                sudoku[e.RowIndex, e.ColumnIndex].ValueNumber = int.Parse(this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
        }
        #endregion

        #region Cell enter 无功能
        private void solverDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
        }
        #endregion 

        #region Cell leave 无功能
        private void solverDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //this.solverDataGridView[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.FromArgb(0, 0, 0);
        }
        #endregion

        #region Cell double click clear value (change to color mark?)
        private void CellMouseNumberEmpty(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this.solverDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
        }
        #endregion

        //=============TOOL TIP MENU=============

        #region new
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSolver();
        }
        #endregion

        #region load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String loadFile = String.Empty;
            openFileDialog1.Filter = "Text File | *.txt";
            openFileDialog1.Title = "Select a your puzzle";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader writer = new StreamReader(openFileDialog1.FileName);
                loadFile = writer.ReadToEnd();
                writer.Dispose();
                writer.Close();
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j].ValueNumber = Convert.ToInt32(loadFile.Substring(j,1).ToString()); // Data formate
                }
            }
        }
        #endregion

        #region save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String saveFile = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    saveFile += sudoku[i, j].ValueNumber+" ";
                }
            }
            saveFileDialog1.FileName = "My Puzzle.txt";
            saveFileDialog1.Filter = "Text File | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.WriteLine(saveFile);
                writer.Dispose();
                writer.Close();
            }
        }
        #endregion

        #region general option
        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General_Option generalOptionForm = new General_Option(true, true);
            generalOptionForm.Show();
        }
        #endregion

        #region solving option
        private void techniquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            General_Option generalOptionForm = new General_Option(false, true);
            generalOptionForm.Show();
        }
        #endregion

        #region general option
        private void showingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General_Option generalOptionForm = new General_Option(true, false);
            generalOptionForm.Show();
        }
        #endregion

        #region Solve Button // 
        private void solveButton_Click(object sender, EventArgs e)
        {
            bool finish = false;
            do
            {
                NakedSingle();
                HiddenSingle();
                NakedPair();
                HiddenPair();
                NakedTriple();
                HiddenTriple();
                PointingPair();
                PointingTriple();
                XWing();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (sudoku[i, j].IsSet)
                        {
                            finish = true;
                        }
                        else
                        {
                            finish = false;
                        }
                    }
                }
            }while(finish); // if all the puzzle are finished end the loop
        }
        #endregion

        private void examplePuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGrid();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.solverDataGridView.ReadOnly = false;
            NewSolver();
            InitializeSudoku();
            Difficulty();
            BuildSudoku();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].ValueNumber != 0)
                    {
                        this.solverDataGridView[j, i].ReadOnly = true;
                    }
                    if (!this.solverDataGridView[j, i].ReadOnly)
                    {
                        this.solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(255, 140, 0);
                    }
                    else
                    {
                        solverDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                }
            }
        }

        #region Color setting
        private void colorSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color_Setting styleSetting = new Color_Setting();
            styleSetting.Show();
        }
        #endregion




    }
}
