using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class General_Option : Form
    {
        bool hideGenerate;
        bool hideSolving;
        public General_Option(bool generate, bool solving)
        {
            this.hideGenerate = generate;
            this.hideSolving = solving;
            
            InitializeComponent();
            if (generate == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }

            if (solving == true)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void General_Option_Load(object sender, EventArgs e)
        {
            
        }
    }
}
