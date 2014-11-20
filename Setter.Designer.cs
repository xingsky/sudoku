namespace Sudoku
{
    partial class Setter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setter));
            this.setterTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.finishButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.undoButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.levelLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbcount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newGameButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setterDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.setterCheckSet = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.highlighting1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlightingOff = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting9 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting8 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting7 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting6 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting5 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting4 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.highlighting2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.setterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setterCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // setterTimer
            // 
            this.setterTimer.Interval = 1000;
            this.setterTimer.Tick += new System.EventHandler(this.setterTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.resetButton.Location = new System.Drawing.Point(615, 233);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 29);
            this.resetButton.TabIndex = 1;
            this.resetButton.Values.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.finishButton.Location = new System.Drawing.Point(615, 342);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(97, 29);
            this.finishButton.TabIndex = 2;
            this.finishButton.Values.Text = "Finish";
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.undoButton.Location = new System.Drawing.Point(615, 288);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(97, 29);
            this.undoButton.TabIndex = 3;
            this.undoButton.Values.Text = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(597, 53);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.levelLabel.Size = new System.Drawing.Size(56, 30);
            this.levelLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.levelLabel.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.levelLabel.Values.Text = "level";
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(634, 543);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.timeLabel.Size = new System.Drawing.Size(6, 2);
            this.timeLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.timeLabel.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.timeLabel.Values.Text = "";
            // 
            // lbcount
            // 
            this.lbcount.Location = new System.Drawing.Point(634, 534);
            this.lbcount.Name = "lbcount";
            this.lbcount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lbcount.Size = new System.Drawing.Size(24, 30);
            this.lbcount.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbcount.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbcount.TabIndex = 6;
            this.lbcount.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.lbcount.Values.Text = "0";
            this.lbcount.Visible = false;
            // 
            // newGameButton
            // 
            this.newGameButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.newGameButton.Location = new System.Drawing.Point(615, 178);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(97, 29);
            this.newGameButton.TabIndex = 7;
            this.newGameButton.Values.Text = "New Game";
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setterDataGridView
            // 
            this.setterDataGridView.AllowUserToAddRows = false;
            this.setterDataGridView.AllowUserToDeleteRows = false;
            this.setterDataGridView.AllowUserToResizeColumns = false;
            this.setterDataGridView.AllowUserToResizeRows = false;
            this.setterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.setterDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.setterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setterDataGridView.ColumnHeadersVisible = false;
            this.setterDataGridView.HideOuterBorders = true;
            this.setterDataGridView.Location = new System.Drawing.Point(47, 37);
            this.setterDataGridView.MaximumSize = new System.Drawing.Size(500, 500);
            this.setterDataGridView.MinimumSize = new System.Drawing.Size(500, 500);
            this.setterDataGridView.MultiSelect = false;
            this.setterDataGridView.Name = "setterDataGridView";
            this.setterDataGridView.RowHeadersVisible = false;
            this.setterDataGridView.RowHeadersWidth = 40;
            this.setterDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.setterDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.setterDataGridView.RowTemplate.Height = 23;
            this.setterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.setterDataGridView.Size = new System.Drawing.Size(500, 500);
            this.setterDataGridView.TabIndex = 2;
            this.setterDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.setterDataGridView_CellEndEdit);
            this.setterDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseNumberEmpty);
            this.setterDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.setterDataGridView_CellMouseEnter);
            this.setterDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "R2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "R3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "R4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "R5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "R6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "R7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 33);
            this.label10.TabIndex = 20;
            this.label10.Text = "R8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 33);
            this.label11.TabIndex = 21;
            this.label11.Text = "R9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "C1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "C2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(167, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "C3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(222, 540);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 33);
            this.label13.TabIndex = 25;
            this.label13.Text = "C4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(278, 540);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 33);
            this.label14.TabIndex = 26;
            this.label14.Text = "C5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(334, 540);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 33);
            this.label15.TabIndex = 27;
            this.label15.Text = "C6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(392, 540);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 33);
            this.label16.TabIndex = 28;
            this.label16.Text = "C7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(446, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 33);
            this.label17.TabIndex = 29;
            this.label17.Text = "C8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(500, 540);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 33);
            this.label18.TabIndex = 30;
            this.label18.Text = "C9";
            // 
            // setterCheckSet
            // 
            this.setterCheckSet.CheckButtons.Add(this.highlighting1);
            this.setterCheckSet.CheckButtons.Add(this.highlightingOff);
            this.setterCheckSet.CheckButtons.Add(this.highlighting9);
            this.setterCheckSet.CheckButtons.Add(this.highlighting8);
            this.setterCheckSet.CheckButtons.Add(this.highlighting7);
            this.setterCheckSet.CheckButtons.Add(this.highlighting6);
            this.setterCheckSet.CheckButtons.Add(this.highlighting5);
            this.setterCheckSet.CheckButtons.Add(this.highlighting4);
            this.setterCheckSet.CheckButtons.Add(this.highlighting3);
            this.setterCheckSet.CheckButtons.Add(this.highlighting2);
            // 
            // highlighting1
            // 
            this.highlighting1.Location = new System.Drawing.Point(553, 121);
            this.highlighting1.Name = "highlighting1";
            this.highlighting1.Size = new System.Drawing.Size(30, 30);
            this.highlighting1.TabIndex = 32;
            this.highlighting1.Values.Text = "1";
            this.highlighting1.Click += new System.EventHandler(this.highlighting1_Click);
            this.highlighting1.MouseEnter += new System.EventHandler(this.highlighting1_MouseEnter);
            this.highlighting1.MouseLeave += new System.EventHandler(this.highlighting1_MouseLeave);
            // 
            // highlightingOff
            // 
            this.highlightingOff.Location = new System.Drawing.Point(552, 445);
            this.highlightingOff.Name = "highlightingOff";
            this.highlightingOff.Size = new System.Drawing.Size(30, 30);
            this.highlightingOff.TabIndex = 35;
            this.highlightingOff.Values.Text = "Off";
            this.highlightingOff.Click += new System.EventHandler(this.highlightingOff_Click);
            this.highlightingOff.MouseEnter += new System.EventHandler(this.highlightingOff_MouseEnter);
            // 
            // highlighting9
            // 
            this.highlighting9.Location = new System.Drawing.Point(552, 409);
            this.highlighting9.Name = "highlighting9";
            this.highlighting9.Size = new System.Drawing.Size(30, 30);
            this.highlighting9.TabIndex = 36;
            this.highlighting9.Values.Text = "9";
            this.highlighting9.Click += new System.EventHandler(this.highlighting9_Click);
            this.highlighting9.MouseEnter += new System.EventHandler(this.highlighting9_MouseEnter);
            this.highlighting9.MouseLeave += new System.EventHandler(this.highlighting9_MouseLeave);
            // 
            // highlighting8
            // 
            this.highlighting8.Location = new System.Drawing.Point(552, 373);
            this.highlighting8.Name = "highlighting8";
            this.highlighting8.Size = new System.Drawing.Size(30, 30);
            this.highlighting8.TabIndex = 37;
            this.highlighting8.Values.Text = "8";
            this.highlighting8.Click += new System.EventHandler(this.highlighting8_Click);
            this.highlighting8.MouseEnter += new System.EventHandler(this.highlighting8_MouseEnter);
            this.highlighting8.MouseLeave += new System.EventHandler(this.highlighting8_MouseLeave);
            // 
            // highlighting7
            // 
            this.highlighting7.Location = new System.Drawing.Point(552, 337);
            this.highlighting7.Name = "highlighting7";
            this.highlighting7.Size = new System.Drawing.Size(30, 30);
            this.highlighting7.TabIndex = 38;
            this.highlighting7.Values.Text = "7";
            this.highlighting7.Click += new System.EventHandler(this.highlighting7_Click);
            this.highlighting7.MouseEnter += new System.EventHandler(this.highlighting7_MouseEnter);
            this.highlighting7.MouseLeave += new System.EventHandler(this.highlighting7_MouseLeave);
            // 
            // highlighting6
            // 
            this.highlighting6.Location = new System.Drawing.Point(552, 301);
            this.highlighting6.Name = "highlighting6";
            this.highlighting6.Size = new System.Drawing.Size(30, 30);
            this.highlighting6.TabIndex = 39;
            this.highlighting6.Values.Text = "6";
            this.highlighting6.Click += new System.EventHandler(this.highlighting6_Click);
            this.highlighting6.MouseEnter += new System.EventHandler(this.highlighting6_MouseEnter);
            this.highlighting6.MouseLeave += new System.EventHandler(this.highlighting6_MouseLeave);
            // 
            // highlighting5
            // 
            this.highlighting5.Location = new System.Drawing.Point(552, 265);
            this.highlighting5.Name = "highlighting5";
            this.highlighting5.Size = new System.Drawing.Size(30, 30);
            this.highlighting5.TabIndex = 40;
            this.highlighting5.Values.Text = "5";
            this.highlighting5.Click += new System.EventHandler(this.highlighting5_Click);
            this.highlighting5.MouseEnter += new System.EventHandler(this.highlighting5_MouseEnter);
            this.highlighting5.MouseLeave += new System.EventHandler(this.highlighting5_MouseLeave);
            // 
            // highlighting4
            // 
            this.highlighting4.Location = new System.Drawing.Point(552, 229);
            this.highlighting4.Name = "highlighting4";
            this.highlighting4.Size = new System.Drawing.Size(30, 30);
            this.highlighting4.TabIndex = 41;
            this.highlighting4.Values.Text = "4";
            this.highlighting4.Click += new System.EventHandler(this.highlighting4_Click);
            this.highlighting4.MouseEnter += new System.EventHandler(this.highlighting4_MouseEnter);
            this.highlighting4.MouseLeave += new System.EventHandler(this.highlighting4_MouseLeave);
            // 
            // highlighting3
            // 
            this.highlighting3.Location = new System.Drawing.Point(552, 193);
            this.highlighting3.Name = "highlighting3";
            this.highlighting3.Size = new System.Drawing.Size(30, 30);
            this.highlighting3.TabIndex = 42;
            this.highlighting3.Values.Text = "3";
            this.highlighting3.Click += new System.EventHandler(this.highlighting3_Click);
            this.highlighting3.MouseEnter += new System.EventHandler(this.highlighting3_MouseEnter);
            this.highlighting3.MouseLeave += new System.EventHandler(this.highlighting3_MouseLeave);
            // 
            // highlighting2
            // 
            this.highlighting2.Location = new System.Drawing.Point(552, 157);
            this.highlighting2.Name = "highlighting2";
            this.highlighting2.Size = new System.Drawing.Size(30, 30);
            this.highlighting2.TabIndex = 43;
            this.highlighting2.Values.Text = "2";
            this.highlighting2.Click += new System.EventHandler(this.highlighting2_Click);
            this.highlighting2.MouseEnter += new System.EventHandler(this.highlighting2_MouseEnter);
            this.highlighting2.MouseLeave += new System.EventHandler(this.highlighting2_MouseLeave);
            // 
            // Setter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 578);
            this.Controls.Add(this.highlighting2);
            this.Controls.Add(this.highlighting3);
            this.Controls.Add(this.highlighting4);
            this.Controls.Add(this.highlighting5);
            this.Controls.Add(this.highlighting6);
            this.Controls.Add(this.highlighting7);
            this.Controls.Add(this.highlighting8);
            this.Controls.Add(this.highlighting9);
            this.Controls.Add(this.highlightingOff);
            this.Controls.Add(this.highlighting1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setterDataGridView);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 610);
            this.Name = "Setter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setter";
            this.TextExtra = "©Zhiwei Liu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setter_FormClosing);
            this.Load += new System.EventHandler(this.Setter_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardPressUp);
            ((System.ComponentModel.ISupportInitialize)(this.setterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setterCheckSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer setterTimer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton resetButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton finishButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton undoButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel levelLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel timeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbcount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newGameButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView setterDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet setterCheckSet;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlightingOff;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting9;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting8;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting7;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting6;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton highlighting2;

    }
}