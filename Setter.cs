
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;
using System.Collections;
using System.Data;
using System.Threading;

namespace Sudoku
{
    public partial class Setter : KryptonForm
    {
        int rand = 5;
        int level = 0;
       
        private CellMethods cellMethod = new CellMethods();
        DataTable dt;
        int[ , ] sudoku = new int[9, 9];
        int[ , ] originalSudoku = new int[9, 9];

        public Setter(int _level)
        {
            this.level = _level;
            dt = new DataTable();
            for (int i = 1; i <= 9; i++)
            {
                dt.Columns.Add("Column" + i.ToString(), typeof(string));
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

        #region Setter loading
        private void Setter_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.setterDataGridView.ReadOnly = false;
            DataBind();
            this.setterDataGridView.ClearSelection();

            LevelLabelText();
            SudokuBegin();
            this.setterTimer.Start();

            foreach (DataGridViewRow rows in this.setterDataGridView.Rows)
            {
                rows.Height = 55;
            }
            NewGame();
        }
        #endregion

        #region Initialize Sudoku
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

            bool mark = cellMethod.FillCell(cells, 0);// FillCells.FillCell(cells, 0);//fill the grids
            Cell cell;

            if (mark)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        cell = cells[i, j];
                        originalSudoku[i, j] = sudoku[i, j] = cell.ValueNumber;
                    }
                }
            }
        }
        #endregion

        #region Start game
        private void SudokuBegin()
        {
            this.setterTimer.Enabled = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dt.Rows[i][j] = sudoku[i, j].ToString();
                }
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

        #region Start a new game
        private void NewGame()
        {
            ResetTime();
            this.setterDataGridView.ReadOnly = false;
            if (level == 3)
            {
                InitializeSudoku();
                ExpertLevel();
                SudokuBegin();
            }
            else if (level == 2)
            {
                InitializeSudoku();
                NormalLevel();
                SudokuBegin();
            }
            else if (level == 1)
            {
                InitializeSudoku();
                EasyLevel();
                SudokuBegin();
            }

            InitDataGridView(sudoku);
        }
        #endregion

        #region Level label
        private void LevelLabelText()
        {
            if (level == 1)
            {
                this.levelLabel.Text = "Easy Puzzle";
            }
            else if (level == 2)
            {
                this.levelLabel.Text = "Normal Puzzle";
            }
            else if (level == 3)
            {
                this.levelLabel.Text = "Expert Puzzle";
            }
        }
        #endregion

        #region Easy Level
        private void EasyLevel()
        {
            List<int> _reduplicate = new List<int>();

            for (int i = 0; i < 81; i++)
            {
                _reduplicate.Add(i);
            }

            int x;
            int y;
            int n;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(20);
                n = _reduplicate[new Random().Next(0, _reduplicate.Count)];
                _reduplicate.Remove(n);

                x = n / 9;
                y = n % 9;

                sudoku[x, y] = 0;
            }
        }
        #endregion

        #region Normal Level
        private void NormalLevel()
        {
            List<int> _reduplicate = new List<int>();

            for (int i = 0; i < 81; i++)
            {
                _reduplicate.Add(i);
            }

            int x;
            int y;
            int n;

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(20);
                n = _reduplicate[new Random().Next(0, _reduplicate.Count)];
                _reduplicate.Remove(n);

                x = n / 9;
                y = n % 9;

                sudoku[x, y] = 0;
            }
        }
        #endregion

        #region Expert Level
        private void ExpertLevel()
        {
            List<int> _reduplicate = new List<int>();

            for (int i = 0; i < 81; i++)
            {
                _reduplicate.Add(i);
            }

            int x;
            int y;
            int n;

            for (int i = 0; i < 55; i++)
            {
                Thread.Sleep(20);
                n = _reduplicate[new Random().Next(0, _reduplicate.Count)];
                _reduplicate.Remove(n);

                x = n / 9;
                y = n % 9;

                sudoku[x, y] = 0;
            }
        }
        #endregion

        #region Initialize Data Grid View
        private void InitDataGridView(int[,] sudoku)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j] != 0)
                    {
                        this.setterDataGridView[j, i].ReadOnly = true;
                        this.setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        this.setterDataGridView[j, i].Style.Font = new Font("微软雅黑", 19);
                    }
                    else
                    {
                        this.setterDataGridView[j, i].ReadOnly = false;
                        this.setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(255,140,0);
                        this.setterDataGridView[j, i].Style.Font = new Font("微软雅黑", 19);
                    }

                    if (i <= 2)
                    {
                        if (j <= 2 || j >= 6)
                            this.setterDataGridView[j, i].Style.BackColor = Color.FromArgb(154 ,201 ,228);
                    }
                    else if (i >= 6)
                    {
                        if (j <= 2 || j >= 6)
                            this.setterDataGridView[j, i].Style.BackColor = Color.FromArgb(154, 201, 228);
                    }
                    else if (i >= 3 && i <= 5)
                    {
                        if (j >= 3 && j <= 5)
                            this.setterDataGridView[j, i].Style.BackColor = Color.FromArgb(154, 201, 228);
                    }
                }
            }
        }
        #endregion

        #region Data Binding as DataTable
        private void DataBind()
        {
            this.setterDataGridView.DataSource = dt;
        }
        #endregion

        #region Time format
        private string TimeFormat(int time)
        {
            if (time < 10)
                return "0" + time.ToString();
            else
                return time.ToString();
        }
        #endregion

        #region Reset time
        private void ResetTime()
        {
            this.lbcount.Text = "0";
        }
        #endregion

        #region Check whether finished game or not
        private bool IsFinish()
        {
            int[,] finishSudoku = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    finishSudoku[i, j] = Convert.ToInt32(this.setterDataGridView[j, i].Value.ToString() == "" ? "0" : this.setterDataGridView[j, i].Value.ToString());
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!IsValid(i, j, finishSudoku))
                        return false;
                }
            }
            return true;
        }
        #endregion

        #region Check the result valid
        private bool IsValid(int i, int j, int[,] _Sudoku)
        {
            try
            {
                int n = _Sudoku[i, j];
                if (n == 0)
                {
                    throw new FormatException("Please fill the blank grids");
                }
                int[] query = new int[] { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
                int t, u;
                for (t = 0; t < 9; t++)
                {
                    if ((t != i && _Sudoku[t, j] == n) || (t != j && _Sudoku[i, t] == n))
                    {
                        return false;
                    }
                }
                for (t = query[i]; t < query[i] + 3; t++)
                {
                    for (u = query[j]; u < query[j] + 3; u++)
                    {
                        if ((t != i || u != j) && _Sudoku[t, u] == n)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "SORRY");
                return false;
            }
        }
        #endregion
        
        #region Start a new game
        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        #endregion

        #region Restart game
        private void resetButton_Click(object sender, EventArgs e)
        {
            SudokuBegin();
        }
        #endregion

        #region Undo
        private void undoButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Finish game
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (IsFinish())
            {
                setterTimer.Stop();
                if (MessageBox.Show("You used finished" + this.levelLabel.Text + " puzzle\nUsed Time: " + this.timeLabel.Text + "\n\nDo you want to try another round ?", "CONGRATULATIONS !", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NewGame();
                }
                else
                {
                    this.setterTimer.Enabled = false;
                }
            }
            else
                MessageBox.Show("Please check your answers", "SORRY");
        }
        #endregion

        #region Form shakes
        private void Setter_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Timer tick
        private void setterTimer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddSeconds(Convert.ToInt32(lbcount.Text) + 1);
            this.timeLabel.Text = TimeFormat(datetime.Hour) + ":" + TimeFormat(datetime.Minute) + ":" + TimeFormat(datetime.Second);
            this.lbcount.Text = (Convert.ToInt32(this.lbcount.Text) + 1).ToString();
        }
        #endregion

        //-----------------EVENTS---------------

        #region Cell end edit Check input 1-9
        private void setterDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int i = 1;
                if ((!int.TryParse(this.setterDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out i)) || (int.TryParse(this.setterDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out i) && i > 9))
                {
                    this.setterDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
                }
            }
        }
        #endregion

        #region Cell double click clear number
        private void CellMouseNumberEmpty(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.setterDataGridView[e.ColumnIndex, e.RowIndex].Value = "";
        }
        #endregion

        #region Cell mouse enter
        Color currentBgColor;
        private void setterDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentBgColor = this.setterDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor;
            this.setterDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(255, 215, 0);
        }
        #endregion

        #region Cell mouse leave
        private void CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.setterDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = currentBgColor;
        }
        #endregion

        #region Keyboard 
        private void KeyboardPressUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        #endregion

        #region Highlighting
        private void highlighting1_Click(object sender, EventArgs e)
        {
            Highlighting(1);
        }

        private void highlighting2_Click(object sender, EventArgs e)
        {
            Highlighting(2);
        }

        private void highlighting3_Click(object sender, EventArgs e)
        {
            Highlighting(3);
        }

        private void highlighting4_Click(object sender, EventArgs e)
        {
            Highlighting(4);
        }

        private void highlighting5_Click(object sender, EventArgs e)
        {
            Highlighting(5);
        }

        private void highlighting6_Click(object sender, EventArgs e)
        {
            Highlighting(6);
        }

        private void highlighting7_Click(object sender, EventArgs e)
        {
            Highlighting(7);
        }

        private void highlighting8_Click(object sender, EventArgs e)
        {
            Highlighting(8);
        }

        private void highlighting9_Click(object sender, EventArgs e)
        {
            Highlighting(9);
        }

        private void highlightingOff_Click(object sender, EventArgs e)
        {
            DefaultVisual();
        }

        public void Highlighting(int hightlightNo)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    if (setterDataGridView[j, i].Value.ToString().CompareTo(hightlightNo + "") == 0)
                        setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
        }

        public void DefaultVisual()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!this.setterDataGridView[j, i].ReadOnly)
                    {
                        this.setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(255, 140, 0);
                    }
                    else
                    {
                        setterDataGridView[j, i].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                }
            }
        }

        private void highlighting1_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(1);
        }

        private void highlighting1_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting1.Checked)
            DefaultVisual();
        }

        private void highlighting2_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(2);
        }

        private void highlighting2_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting2.Checked)
            DefaultVisual();
        }

        private void highlighting3_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(3);
        }

        private void highlighting3_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting3.Checked)
            DefaultVisual();
        }

        private void highlighting4_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(4);
        }

        private void highlighting4_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting4.Checked)
            DefaultVisual();
        }

        private void highlighting5_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(5);
        }

        private void highlighting5_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting5.Checked)
            DefaultVisual();
        }

        private void highlighting6_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(6);
        }

        private void highlighting6_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting6.Checked)
            DefaultVisual();
        }

        private void highlighting7_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(7);
        }

        private void highlighting7_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting7.Checked)
            DefaultVisual();
        }

        private void highlighting8_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(8);
        }

        private void highlighting8_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting8.Checked)
            DefaultVisual();
        }

        private void highlighting9_MouseEnter(object sender, EventArgs e)
        {
            Highlighting(9);
        }

        private void highlighting9_MouseLeave(object sender, EventArgs e)
        {
            if (!highlighting9.Checked)
            DefaultVisual();
        }

        private void highlightingOff_MouseEnter(object sender, EventArgs e)
        {
            DefaultVisual();
        }
        #endregion
    }
}
