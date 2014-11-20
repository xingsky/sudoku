namespace Sudoku
{
    partial class General_Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.generateButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.difficultyDescriptionLabel = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.difficultyRatingRadio = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.emptyGridsRadio = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.difficultyRatingCombo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.emptyGridsText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.full = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.none = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.nineRotational = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.eightRotational = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.antiDiagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.diagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.horizontal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.vertical = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xWingOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.nakedSingleOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.hiddenSingleOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.nakedPairOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.hiddenPairOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.nakedTripleOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.hiddenTripleOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.bruteForceOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pairPointingOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.triplePointingOption = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyRatingCombo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puzzle generate";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.generateButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.difficultyRatingRadio);
            this.groupBox4.Controls.Add(this.emptyGridsRadio);
            this.groupBox4.Controls.Add(this.difficultyRatingCombo);
            this.groupBox4.Controls.Add(this.kryptonLabel3);
            this.groupBox4.Controls.Add(this.kryptonLabel2);
            this.groupBox4.Controls.Add(this.emptyGridsText);
            this.groupBox4.Location = new System.Drawing.Point(7, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 192);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Difficulty ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(283, 42);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(90, 32);
            this.generateButton.TabIndex = 9;
            this.generateButton.Values.Text = "Generate";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.difficultyDescriptionLabel);
            this.groupBox5.Location = new System.Drawing.Point(6, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(423, 87);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
            // 
            // difficultyDescriptionLabel
            // 
            this.difficultyDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.difficultyDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.difficultyDescriptionLabel.Location = new System.Drawing.Point(6, 28);
            this.difficultyDescriptionLabel.Name = "difficultyDescriptionLabel";
            this.difficultyDescriptionLabel.Size = new System.Drawing.Size(116, 15);
            this.difficultyDescriptionLabel.Text = "difficulty description";
            // 
            // difficultyRatingRadio
            // 
            this.difficultyRatingRadio.Location = new System.Drawing.Point(12, 65);
            this.difficultyRatingRadio.Name = "difficultyRatingRadio";
            this.difficultyRatingRadio.Size = new System.Drawing.Size(115, 20);
            this.difficultyRatingRadio.TabIndex = 7;
            this.difficultyRatingRadio.Values.Text = "Difficulty Rating :";
            // 
            // emptyGridsRadio
            // 
            this.emptyGridsRadio.Location = new System.Drawing.Point(12, 29);
            this.emptyGridsRadio.Name = "emptyGridsRadio";
            this.emptyGridsRadio.Size = new System.Drawing.Size(95, 20);
            this.emptyGridsRadio.TabIndex = 6;
            this.emptyGridsRadio.Values.Text = "Empty Grids :";
            // 
            // difficultyRatingCombo
            // 
            this.difficultyRatingCombo.DropDownWidth = 116;
            this.difficultyRatingCombo.Items.AddRange(new object[] {
            "Very Simple",
            "Simple",
            "Hard",
            "Extremely Hard",
            "Expert"});
            this.difficultyRatingCombo.Location = new System.Drawing.Point(133, 65);
            this.difficultyRatingCombo.Name = "difficultyRatingCombo";
            this.difficultyRatingCombo.Size = new System.Drawing.Size(116, 21);
            this.difficultyRatingCombo.TabIndex = 4;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(217, 29);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "≤ 64 ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(113, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(29, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "1 ≤";
            // 
            // emptyGridsText
            // 
            this.emptyGridsText.Location = new System.Drawing.Point(148, 29);
            this.emptyGridsText.Name = "emptyGridsText";
            this.emptyGridsText.Size = new System.Drawing.Size(63, 20);
            this.emptyGridsText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.full);
            this.groupBox3.Controls.Add(this.none);
            this.groupBox3.Controls.Add(this.nineRotational);
            this.groupBox3.Controls.Add(this.eightRotational);
            this.groupBox3.Controls.Add(this.antiDiagonal);
            this.groupBox3.Controls.Add(this.diagonal);
            this.groupBox3.Controls.Add(this.horizontal);
            this.groupBox3.Controls.Add(this.vertical);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 98);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowed symmtry types";
            // 
            // full
            // 
            this.full.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.full.Location = new System.Drawing.Point(229, 61);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(43, 20);
            this.full.TabIndex = 15;
            this.full.Text = "Full";
            this.full.Values.Text = "Full";
            // 
            // none
            // 
            this.none.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.none.Location = new System.Drawing.Point(320, 61);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(53, 20);
            this.none.TabIndex = 14;
            this.none.Text = "None";
            this.none.Values.Text = "None";
            // 
            // nineRotational
            // 
            this.nineRotational.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.nineRotational.Location = new System.Drawing.Point(120, 61);
            this.nineRotational.Name = "nineRotational";
            this.nineRotational.Size = new System.Drawing.Size(98, 20);
            this.nineRotational.TabIndex = 13;
            this.nineRotational.Text = "90° rotational";
            this.nineRotational.Values.Text = "90° rotational";
            // 
            // eightRotational
            // 
            this.eightRotational.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.eightRotational.Location = new System.Drawing.Point(11, 61);
            this.eightRotational.Name = "eightRotational";
            this.eightRotational.Size = new System.Drawing.Size(104, 20);
            this.eightRotational.TabIndex = 12;
            this.eightRotational.Text = "180° rotational";
            this.eightRotational.Values.Text = "180° rotational";
            // 
            // antiDiagonal
            // 
            this.antiDiagonal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.antiDiagonal.Location = new System.Drawing.Point(320, 30);
            this.antiDiagonal.Name = "antiDiagonal";
            this.antiDiagonal.Size = new System.Drawing.Size(99, 20);
            this.antiDiagonal.TabIndex = 11;
            this.antiDiagonal.Text = "Anti-Diagonal";
            this.antiDiagonal.Values.Text = "Anti-Diagonal";
            // 
            // diagonal
            // 
            this.diagonal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.diagonal.Location = new System.Drawing.Point(229, 30);
            this.diagonal.Name = "diagonal";
            this.diagonal.Size = new System.Drawing.Size(72, 20);
            this.diagonal.TabIndex = 10;
            this.diagonal.Text = "Diagonal";
            this.diagonal.Values.Text = "Diagonal";
            // 
            // horizontal
            // 
            this.horizontal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.horizontal.Location = new System.Drawing.Point(120, 30);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(80, 20);
            this.horizontal.TabIndex = 9;
            this.horizontal.Text = "Horizontal";
            this.horizontal.Values.Text = "Horizontal";
            // 
            // vertical
            // 
            this.vertical.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.vertical.Location = new System.Drawing.Point(11, 30);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(64, 20);
            this.vertical.TabIndex = 8;
            this.vertical.Text = "Vertical";
            this.vertical.Values.Text = "Vertical";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.triplePointingOption);
            this.groupBox2.Controls.Add(this.bruteForceOption);
            this.groupBox2.Controls.Add(this.pairPointingOption);
            this.groupBox2.Controls.Add(this.xWingOption);
            this.groupBox2.Controls.Add(this.nakedSingleOption);
            this.groupBox2.Controls.Add(this.hiddenSingleOption);
            this.groupBox2.Controls.Add(this.nakedPairOption);
            this.groupBox2.Controls.Add(this.hiddenPairOption);
            this.groupBox2.Controls.Add(this.nakedTripleOption);
            this.groupBox2.Controls.Add(this.hiddenTripleOption);
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solving techniques";
            // 
            // xWingOption
            // 
            this.xWingOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.xWingOption.Location = new System.Drawing.Point(120, 36);
            this.xWingOption.Name = "xWingOption";
            this.xWingOption.Size = new System.Drawing.Size(71, 20);
            this.xWingOption.TabIndex = 7;
            this.xWingOption.Text = "X - Wing";
            this.xWingOption.Values.Text = "X - Wing";
            // 
            // nakedSingleOption
            // 
            this.nakedSingleOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.nakedSingleOption.Location = new System.Drawing.Point(18, 62);
            this.nakedSingleOption.Name = "nakedSingleOption";
            this.nakedSingleOption.Size = new System.Drawing.Size(96, 20);
            this.nakedSingleOption.TabIndex = 6;
            this.nakedSingleOption.Text = "Naked Single";
            this.nakedSingleOption.Values.Text = "Naked Single";
            // 
            // hiddenSingleOption
            // 
            this.hiddenSingleOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.hiddenSingleOption.Location = new System.Drawing.Point(18, 88);
            this.hiddenSingleOption.Name = "hiddenSingleOption";
            this.hiddenSingleOption.Size = new System.Drawing.Size(100, 20);
            this.hiddenSingleOption.TabIndex = 5;
            this.hiddenSingleOption.Text = "Hidden Single";
            this.hiddenSingleOption.Values.Text = "Hidden Single";
            // 
            // nakedPairOption
            // 
            this.nakedPairOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.nakedPairOption.Location = new System.Drawing.Point(120, 62);
            this.nakedPairOption.Name = "nakedPairOption";
            this.nakedPairOption.Size = new System.Drawing.Size(83, 20);
            this.nakedPairOption.TabIndex = 4;
            this.nakedPairOption.Text = "Naked Pair";
            this.nakedPairOption.Values.Text = "Naked Pair";
            // 
            // hiddenPairOption
            // 
            this.hiddenPairOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.hiddenPairOption.Location = new System.Drawing.Point(120, 88);
            this.hiddenPairOption.Name = "hiddenPairOption";
            this.hiddenPairOption.Size = new System.Drawing.Size(87, 20);
            this.hiddenPairOption.TabIndex = 3;
            this.hiddenPairOption.Text = "Hidden Pair";
            this.hiddenPairOption.Values.Text = "Hidden Pair";
            // 
            // nakedTripleOption
            // 
            this.nakedTripleOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.nakedTripleOption.Location = new System.Drawing.Point(215, 62);
            this.nakedTripleOption.Name = "nakedTripleOption";
            this.nakedTripleOption.Size = new System.Drawing.Size(93, 20);
            this.nakedTripleOption.TabIndex = 2;
            this.nakedTripleOption.Text = "Naked Triple";
            this.nakedTripleOption.Values.Text = "Naked Triple";
            // 
            // hiddenTripleOption
            // 
            this.hiddenTripleOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.hiddenTripleOption.Location = new System.Drawing.Point(215, 88);
            this.hiddenTripleOption.Name = "hiddenTripleOption";
            this.hiddenTripleOption.Size = new System.Drawing.Size(97, 20);
            this.hiddenTripleOption.TabIndex = 1;
            this.hiddenTripleOption.Text = "Hidden Triple";
            this.hiddenTripleOption.Values.Text = "Hidden Triple";
            // 
            // bruteForceOption
            // 
            this.bruteForceOption.Checked = true;
            this.bruteForceOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bruteForceOption.Enabled = false;
            this.bruteForceOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.bruteForceOption.Location = new System.Drawing.Point(18, 36);
            this.bruteForceOption.Name = "bruteForceOption";
            this.bruteForceOption.Size = new System.Drawing.Size(85, 20);
            this.bruteForceOption.TabIndex = 0;
            this.bruteForceOption.Text = "Brute-force";
            this.bruteForceOption.Values.Text = "Brute-force";
            // 
            // pairPointingOption
            // 
            this.pairPointingOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.pairPointingOption.Location = new System.Drawing.Point(314, 62);
            this.pairPointingOption.Name = "pairPointingOption";
            this.pairPointingOption.Size = new System.Drawing.Size(93, 20);
            this.pairPointingOption.TabIndex = 8;
            this.pairPointingOption.Text = "Pair Pointing";
            this.pairPointingOption.Values.Text = "Pair Pointing";
            // 
            // triplePointingOption
            // 
            this.triplePointingOption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.triplePointingOption.Location = new System.Drawing.Point(314, 88);
            this.triplePointingOption.Name = "triplePointingOption";
            this.triplePointingOption.Size = new System.Drawing.Size(103, 20);
            this.triplePointingOption.TabIndex = 9;
            this.triplePointingOption.Text = "Triple Pointing";
            this.triplePointingOption.Values.Text = "Triple Pointing";
            // 
            // General_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "General_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Option";
            this.Load += new System.EventHandler(this.General_Option_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyRatingCombo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox xWingOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox nakedSingleOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox hiddenSingleOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox nakedPairOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox hiddenPairOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox nakedTripleOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox hiddenTripleOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox bruteForceOption;
        private System.Windows.Forms.GroupBox groupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox full;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox none;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox nineRotational;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox eightRotational;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox antiDiagonal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox diagonal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox horizontal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox vertical;
        private System.Windows.Forms.GroupBox groupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emptyGridsText;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox difficultyRatingCombo;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton difficultyRatingRadio;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton emptyGridsRadio;
        private System.Windows.Forms.GroupBox groupBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel difficultyDescriptionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateButton;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox triplePointingOption;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox pairPointingOption;
    }
}