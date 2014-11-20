using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Grid
    {
        private int gridRow = 0;
        private int gridCol = 0;
        private List<int> gridCandidateValue;

        public Grid()
        {
            gridCandidateValue = new List<int> { };
        }

        public int GridRow
        {
            get
            {
                return gridRow;
            }
            set
            {
                gridRow = value;
            }
        }

        public int GridCol
        {
            get
            {
                return gridCol;
            }
            set
            {
                gridCol = value;
            }
        }

        public List<int> GridCandidateValue
        {
            get
            {
                return gridCandidateValue;
            }
            set
            {
                gridCandidateValue = value;
            }
        }
    }
}
