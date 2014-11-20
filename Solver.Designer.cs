namespace Sudoku
{
    partial class Solver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("R1,C5 4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("R3,C7 4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("R3,C8 3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("R4,C9 4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("R7,C3 6");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("R7,C4 2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("R8,C3 4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("R8,C8 8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("R8,C5 2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("R9,C4 4");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Naked Single", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("R4,C4 3");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("R4,C5 9");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("R6,C1 3");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("R6,C2 9");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Hidden Single", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Naked Pair");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Hidden Pair");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Naked Triple");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Hidden Triple");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Pointing Pair");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Pointing Triple");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("X-wing");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("R2,C1 4");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("R2,C2 6");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("R5,C1 6");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("R5,C2 4");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("R8,C4 7");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("R9,C1 9");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("R9,C5 1");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Brute-force", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solver));
            this.solverDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.generateNewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkValidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplePuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bruteForceButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkValidityButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.solveTracking = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.CandidatesVisibleRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.clearValuesButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nakedSingleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hiddenSingleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nakedPairButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hiddenPairButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nakedTripleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hiddenTripleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.xWingButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pointingPairButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pointingTripleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.solveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.solverDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solverDataGridView
            // 
            this.solverDataGridView.AllowUserToAddRows = false;
            this.solverDataGridView.AllowUserToDeleteRows = false;
            this.solverDataGridView.AllowUserToResizeColumns = false;
            this.solverDataGridView.AllowUserToResizeRows = false;
            this.solverDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.solverDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.solverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solverDataGridView.ColumnHeadersVisible = false;
            this.solverDataGridView.HideOuterBorders = true;
            this.solverDataGridView.Location = new System.Drawing.Point(49, 29);
            this.solverDataGridView.MaximumSize = new System.Drawing.Size(500, 500);
            this.solverDataGridView.MinimumSize = new System.Drawing.Size(500, 500);
            this.solverDataGridView.MultiSelect = false;
            this.solverDataGridView.Name = "solverDataGridView";
            this.solverDataGridView.RowHeadersVisible = false;
            this.solverDataGridView.RowHeadersWidth = 40;
            this.solverDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.solverDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.solverDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.solverDataGridView.RowTemplate.Height = 23;
            this.solverDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.solverDataGridView.Size = new System.Drawing.Size(500, 500);
            this.solverDataGridView.TabIndex = 1;
            this.solverDataGridView.Tag = "";
            this.solverDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.solverDataGridView_CellClick);
            this.solverDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.solverDataGridView_CellContentClick);
            this.solverDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.solverDataGridView_CellDoubleClick);
            this.solverDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.solverDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.solverDataGridView_CellEnter);
            this.solverDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.solverDataGridView_CellLeave);
            this.solverDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseNumberEmpty);
            this.solverDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellMouseHightlight);
            this.solverDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "R1";
            // 
            // generateNewButton
            // 
            this.generateNewButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.generateNewButton.Location = new System.Drawing.Point(565, 495);
            this.generateNewButton.Name = "generateNewButton";
            this.generateNewButton.Size = new System.Drawing.Size(97, 29);
            this.generateNewButton.TabIndex = 8;
            this.generateNewButton.Values.Text = "Generate";
            this.generateNewButton.Click += new System.EventHandler(this.Generate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.Quit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearGridToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearGridToolStripMenuItem
            // 
            this.clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            this.clearGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearGridToolStripMenuItem.Text = "Clear grid";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkValidityToolStripMenuItem,
            this.checkUniqueToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // checkValidityToolStripMenuItem
            // 
            this.checkValidityToolStripMenuItem.Name = "checkValidityToolStripMenuItem";
            this.checkValidityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkValidityToolStripMenuItem.Text = "Check validity";
            // 
            // checkUniqueToolStripMenuItem
            // 
            this.checkUniqueToolStripMenuItem.Name = "checkUniqueToolStripMenuItem";
            this.checkUniqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkUniqueToolStripMenuItem.Text = "Check unique";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showingToolStripMenuItem,
            this.colorSettingToolStripMenuItem,
            this.techniquesToolStripMenuItem1,
            this.generalToolStripMenuItem,
            this.examplePuzzleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // techniquesToolStripMenuItem1
            // 
            this.techniquesToolStripMenuItem1.Name = "techniquesToolStripMenuItem1";
            this.techniquesToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.techniquesToolStripMenuItem1.Text = "Solving setting";
            this.techniquesToolStripMenuItem1.Click += new System.EventHandler(this.techniquesToolStripMenuItem1_Click);
            // 
            // showingToolStripMenuItem
            // 
            this.showingToolStripMenuItem.Name = "showingToolStripMenuItem";
            this.showingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showingToolStripMenuItem.Text = "Show candidates";
            this.showingToolStripMenuItem.Click += new System.EventHandler(this.showingToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.generalToolStripMenuItem.Text = "General setting";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // colorSettingToolStripMenuItem
            // 
            this.colorSettingToolStripMenuItem.Name = "colorSettingToolStripMenuItem";
            this.colorSettingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.colorSettingToolStripMenuItem.Text = "Style setting";
            this.colorSettingToolStripMenuItem.Click += new System.EventHandler(this.colorSettingToolStripMenuItem_Click);
            // 
            // examplePuzzleToolStripMenuItem
            // 
            this.examplePuzzleToolStripMenuItem.Name = "examplePuzzleToolStripMenuItem";
            this.examplePuzzleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.examplePuzzleToolStripMenuItem.Text = "Example puzzle";
            this.examplePuzzleToolStripMenuItem.Visible = false;
            this.examplePuzzleToolStripMenuItem.Click += new System.EventHandler(this.examplePuzzleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.techniquesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // techniquesToolStripMenuItem
            // 
            this.techniquesToolStripMenuItem.Name = "techniquesToolStripMenuItem";
            this.techniquesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.techniquesToolStripMenuItem.Text = "Techniques";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "R2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "C1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "C2";
            // 
            // bruteForceButton
            // 
            this.bruteForceButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.bruteForceButton.Location = new System.Drawing.Point(679, 531);
            this.bruteForceButton.Name = "bruteForceButton";
            this.bruteForceButton.Size = new System.Drawing.Size(319, 29);
            this.bruteForceButton.TabIndex = 13;
            this.bruteForceButton.Values.Text = "Brute Force";
            this.bruteForceButton.Click += new System.EventHandler(this.Solve_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "R3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "R4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "R5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "R6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "R7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 33);
            this.label10.TabIndex = 19;
            this.label10.Text = "R8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 33);
            this.label11.TabIndex = 20;
            this.label11.Text = "R9";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(163, 532);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 33);
            this.label12.TabIndex = 21;
            this.label12.Text = "C3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(218, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 33);
            this.label13.TabIndex = 22;
            this.label13.Text = "C4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(274, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 33);
            this.label14.TabIndex = 23;
            this.label14.Text = "C5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(334, 532);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 33);
            this.label15.TabIndex = 24;
            this.label15.Text = "C6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(392, 532);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 33);
            this.label16.TabIndex = 25;
            this.label16.Text = "C7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(445, 533);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 33);
            this.label17.TabIndex = 26;
            this.label17.Text = "C8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(500, 532);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 33);
            this.label18.TabIndex = 27;
            this.label18.Text = "C9";
            // 
            // checkValidityButton
            // 
            this.checkValidityButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.checkValidityButton.Location = new System.Drawing.Point(565, 390);
            this.checkValidityButton.Name = "checkValidityButton";
            this.checkValidityButton.Size = new System.Drawing.Size(97, 29);
            this.checkValidityButton.TabIndex = 29;
            this.checkValidityButton.Values.Text = "Check Validity";
            this.checkValidityButton.Click += new System.EventHandler(this.CheckValid_Click);
            // 
            // solveTracking
            // 
            this.solveTracking.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.solveTracking.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.solveTracking.ItemHeight = 21;
            this.solveTracking.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.solveTracking.Location = new System.Drawing.Point(565, 29);
            this.solveTracking.Name = "solveTracking";
            treeNode1.Name = "节点0";
            treeNode1.Text = "R1,C5 4";
            treeNode2.Name = "节点1";
            treeNode2.Text = "R3,C7 4";
            treeNode3.Name = "节点2";
            treeNode3.Text = "R3,C8 3";
            treeNode4.Name = "节点3";
            treeNode4.Text = "R4,C9 4";
            treeNode5.Name = "节点3";
            treeNode5.Text = "R7,C3 6";
            treeNode6.Name = "节点4";
            treeNode6.Text = "R7,C4 2";
            treeNode7.Name = "节点5";
            treeNode7.Text = "R8,C3 4";
            treeNode8.Name = "节点6";
            treeNode8.Text = "R8,C8 8";
            treeNode9.Name = "节点7";
            treeNode9.Text = "R8,C5 2";
            treeNode10.Name = "节点8";
            treeNode10.Text = "R9,C4 4";
            treeNode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            treeNode11.Name = "";
            treeNode11.NodeFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode11.Text = "Naked Single";
            treeNode12.Name = "节点14";
            treeNode12.Text = "R4,C4 3";
            treeNode13.Name = "节点15";
            treeNode13.Text = "R4,C5 9";
            treeNode14.Name = "节点16";
            treeNode14.Text = "R6,C1 3";
            treeNode15.Name = "节点17";
            treeNode15.Text = "R6,C2 9";
            treeNode16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode16.Name = "节点4";
            treeNode16.Text = "Hidden Single";
            treeNode17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode17.Name = "节点0";
            treeNode17.Text = "Naked Pair";
            treeNode18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode18.Name = "节点1";
            treeNode18.Text = "Hidden Pair";
            treeNode19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode19.Name = "节点2";
            treeNode19.Text = "Naked Triple";
            treeNode20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode20.Name = "节点3";
            treeNode20.Text = "Hidden Triple";
            treeNode21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode21.Name = "节点4";
            treeNode21.Text = "Pointing Pair";
            treeNode22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            treeNode22.Name = "节点5";
            treeNode22.Text = "Pointing Triple";
            treeNode23.BackColor = System.Drawing.Color.Aqua;
            treeNode23.Name = "节点6";
            treeNode23.Text = "X-wing";
            treeNode24.Name = "节点18";
            treeNode24.Text = "R2,C1 4";
            treeNode25.Name = "节点19";
            treeNode25.Text = "R2,C2 6";
            treeNode26.Name = "节点20";
            treeNode26.Text = "R5,C1 6";
            treeNode27.Name = "节点21";
            treeNode27.Text = "R5,C2 4";
            treeNode28.Name = "节点22";
            treeNode28.Text = "R8,C4 7";
            treeNode29.Name = "节点23";
            treeNode29.Text = "R9,C1 9";
            treeNode30.Name = "节点24";
            treeNode30.Text = "R9,C5 1";
            treeNode31.BackColor = System.Drawing.Color.IndianRed;
            treeNode31.Name = "节点8";
            treeNode31.Text = "Brute-force";
            this.solveTracking.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode31});
            this.solveTracking.Size = new System.Drawing.Size(435, 345);
            this.solveTracking.TabIndex = 30;
            // 
            // CandidatesVisibleRadioButton
            // 
            this.CandidatesVisibleRadioButton.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.CandidatesVisibleRadioButton.Location = new System.Drawing.Point(556, 533);
            this.CandidatesVisibleRadioButton.Name = "CandidatesVisibleRadioButton";
            this.CandidatesVisibleRadioButton.Size = new System.Drawing.Size(117, 20);
            this.CandidatesVisibleRadioButton.TabIndex = 31;
            this.CandidatesVisibleRadioButton.Text = "Show Candidates";
            this.CandidatesVisibleRadioButton.Values.Text = "Show Candidates";
            this.CandidatesVisibleRadioButton.CheckedChanged += new System.EventHandler(this.CandidatesVisibleRadioButton_CheckedChanged);
            // 
            // clearValuesButton
            // 
            this.clearValuesButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.clearValuesButton.Location = new System.Drawing.Point(565, 460);
            this.clearValuesButton.Name = "clearValuesButton";
            this.clearValuesButton.Size = new System.Drawing.Size(97, 29);
            this.clearValuesButton.TabIndex = 32;
            this.clearValuesButton.Values.Text = "Clear Values";
            // 
            // nakedSingleButton
            // 
            this.nakedSingleButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.nakedSingleButton.Location = new System.Drawing.Point(679, 425);
            this.nakedSingleButton.Name = "nakedSingleButton";
            this.nakedSingleButton.Size = new System.Drawing.Size(97, 29);
            this.nakedSingleButton.TabIndex = 33;
            this.nakedSingleButton.Values.Text = "Naked Single";
            this.nakedSingleButton.Click += new System.EventHandler(this.nakedSingleButton_Click);
            // 
            // hiddenSingleButton
            // 
            this.hiddenSingleButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.hiddenSingleButton.Location = new System.Drawing.Point(791, 425);
            this.hiddenSingleButton.Name = "hiddenSingleButton";
            this.hiddenSingleButton.Size = new System.Drawing.Size(97, 29);
            this.hiddenSingleButton.TabIndex = 34;
            this.hiddenSingleButton.Values.Text = "Hidden Single";
            this.hiddenSingleButton.Click += new System.EventHandler(this.hiddenSingleButton_Click);
            // 
            // nakedPairButton
            // 
            this.nakedPairButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.nakedPairButton.Location = new System.Drawing.Point(679, 460);
            this.nakedPairButton.Name = "nakedPairButton";
            this.nakedPairButton.Size = new System.Drawing.Size(97, 29);
            this.nakedPairButton.TabIndex = 36;
            this.nakedPairButton.Values.Text = "Naked Pair";
            this.nakedPairButton.Click += new System.EventHandler(this.nakedPairButton_Click);
            // 
            // hiddenPairButton
            // 
            this.hiddenPairButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.hiddenPairButton.Location = new System.Drawing.Point(791, 460);
            this.hiddenPairButton.Name = "hiddenPairButton";
            this.hiddenPairButton.Size = new System.Drawing.Size(97, 29);
            this.hiddenPairButton.TabIndex = 37;
            this.hiddenPairButton.Values.Text = "Hidden Pair";
            this.hiddenPairButton.Click += new System.EventHandler(this.hiddenPairButton_Click);
            // 
            // nakedTripleButton
            // 
            this.nakedTripleButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.nakedTripleButton.Location = new System.Drawing.Point(679, 495);
            this.nakedTripleButton.Name = "nakedTripleButton";
            this.nakedTripleButton.Size = new System.Drawing.Size(97, 29);
            this.nakedTripleButton.TabIndex = 38;
            this.nakedTripleButton.Values.Text = "Naked Triple";
            this.nakedTripleButton.Click += new System.EventHandler(this.nakedTripleButton_Click);
            // 
            // hiddenTripleButton
            // 
            this.hiddenTripleButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.hiddenTripleButton.Location = new System.Drawing.Point(791, 495);
            this.hiddenTripleButton.Name = "hiddenTripleButton";
            this.hiddenTripleButton.Size = new System.Drawing.Size(97, 29);
            this.hiddenTripleButton.TabIndex = 40;
            this.hiddenTripleButton.Values.Text = "Hidden Triple";
            this.hiddenTripleButton.Click += new System.EventHandler(this.hiddenTripleButton_Click);
            // 
            // xWingButton
            // 
            this.xWingButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.xWingButton.Location = new System.Drawing.Point(903, 495);
            this.xWingButton.Name = "xWingButton";
            this.xWingButton.Size = new System.Drawing.Size(97, 29);
            this.xWingButton.TabIndex = 41;
            this.xWingButton.Values.Text = "X-Wing";
            this.xWingButton.Click += new System.EventHandler(this.xWingButton_Click);
            // 
            // pointingPairButton
            // 
            this.pointingPairButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.pointingPairButton.Location = new System.Drawing.Point(903, 425);
            this.pointingPairButton.Name = "pointingPairButton";
            this.pointingPairButton.Size = new System.Drawing.Size(97, 29);
            this.pointingPairButton.TabIndex = 42;
            this.pointingPairButton.Values.Text = "Pointing Pair";
            this.pointingPairButton.Click += new System.EventHandler(this.pointingPairButton_Click);
            // 
            // pointingTripleButton
            // 
            this.pointingTripleButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.pointingTripleButton.Location = new System.Drawing.Point(903, 460);
            this.pointingTripleButton.Name = "pointingTripleButton";
            this.pointingTripleButton.Size = new System.Drawing.Size(97, 29);
            this.pointingTripleButton.TabIndex = 43;
            this.pointingTripleButton.Values.Text = "Pointing Triple";
            this.pointingTripleButton.Click += new System.EventHandler(this.pointingTripleButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // solveButton
            // 
            this.solveButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.solveButton.Location = new System.Drawing.Point(679, 390);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(319, 29);
            this.solveButton.TabIndex = 44;
            this.solveButton.Values.Text = "Solve";
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.kryptonButton1.Location = new System.Drawing.Point(565, 425);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(97, 29);
            this.kryptonButton1.TabIndex = 45;
            this.kryptonButton1.Values.Text = "Check Unique";
            // 
            // Solver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 572);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.pointingTripleButton);
            this.Controls.Add(this.pointingPairButton);
            this.Controls.Add(this.xWingButton);
            this.Controls.Add(this.hiddenTripleButton);
            this.Controls.Add(this.nakedTripleButton);
            this.Controls.Add(this.hiddenPairButton);
            this.Controls.Add(this.nakedPairButton);
            this.Controls.Add(this.hiddenSingleButton);
            this.Controls.Add(this.nakedSingleButton);
            this.Controls.Add(this.clearValuesButton);
            this.Controls.Add(this.CandidatesVisibleRadioButton);
            this.Controls.Add(this.solveTracking);
            this.Controls.Add(this.checkValidityButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bruteForceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateNewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solverDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(994, 610);
            this.Name = "Solver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solver_FormClosing);
            this.Load += new System.EventHandler(this.Solver_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardPressUp);
            ((System.ComponentModel.ISupportInitialize)(this.solverDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView solverDataGridView;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateNewButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bruteForceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private ComponentFactory.Krypton.Toolkit.KryptonButton checkValidityButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView solveTracking;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CandidatesVisibleRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clearValuesButton;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkValidityToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nakedSingleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hiddenSingleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nakedPairButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hiddenPairButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nakedTripleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hiddenTripleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton xWingButton;
        private System.Windows.Forms.ToolStripMenuItem clearGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUniqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniquesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton pointingPairButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton pointingTripleButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton solveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ToolStripMenuItem examplePuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSettingToolStripMenuItem;
    }
}