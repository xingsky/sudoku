using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Sudoku
{
    public class Cell 
    {
        private int valueNumber;
        private Dictionary<int, int> duplicateDelete;
        private List<int> candidate;
        private bool setCell;
        private string color;

        public Cell()
        {
            candidate = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        }

        // value
        public int ValueNumber
        {
            get
            {
                return valueNumber;
            }
            set
            {
                valueNumber = value;
            }
        }

        // candidates
        public List<int> Candidate
        {
            get
            {
                if (candidate == null)
                {
                    candidate = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
                }
                return candidate;
            }
            set
            {
                candidate = value;
            }
        }

        public void UpdataCandidate(int index, int value)
        {
            candidate.RemoveAt(index);
            candidate.Insert(index, value);
        }

        public void RemoveCandidate(int value)
        {
            candidate.Remove(value);
        }

        public void AddCandidate(int value)
        {
            candidate.Add(value);
        }

        // For recover number
        public Dictionary<int, int> DuplicateDelete
        {
            get
            {
                if (duplicateDelete == null)
                {
                    duplicateDelete = new Dictionary<int, int>();
                }
                return duplicateDelete;
            }
            set
            {
                duplicateDelete = value;
            }
        }

        // Is cell set value
        public bool IsSet
        {
            get
            {
                return setCell;
            }
            set
            {
                setCell = value;
            }
        }

        // color operates
        public string BgColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
    }
}
