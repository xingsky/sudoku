
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace Sudoku
{
    public partial class Welcome : KryptonForm
    {

        private int level = 0;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
 

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            level = 1;
            this.Hide();
            Setter setterFrom = new Setter(level);
            setterFrom.Show();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            level = 2;
            this.Hide();
            Setter setterFrom = new Setter(level);
            setterFrom.Show();
        }

        private void expertButton_Click(object sender, EventArgs e)
        {
            level = 3;
            this.Hide();
            Setter setterFrom = new Setter(level);
            setterFrom.Show();
        }

        private void solverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Solver solverFrom = new Solver();
            solverFrom.Show();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KeyboardPressUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

    }
}
