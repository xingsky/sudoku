namespace Sudoku
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.solverButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.expertButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.normalButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.easyButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonCheckSetPalettes = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonCheckSetStyles = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetPalettes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetStyles)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(427, 17);
            this.toolStripStatusLabel1.Text = "                                                                                 " +
    "                       PLEASE SELECT ONE";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.ContentPanel.BackgroundImage")));
            this.toolStripContainer1.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.solverButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.expertButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.normalButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.easyButton);
            this.toolStripContainer1.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(734, 465);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(734, 490);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // solverButton
            // 
            this.solverButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.solverButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.solverButton.Location = new System.Drawing.Point(301, 310);
            this.solverButton.Name = "solverButton";
            this.solverButton.Size = new System.Drawing.Size(137, 38);
            this.solverButton.TabIndex = 0;
            this.solverButton.Values.Text = "SOLVER";
            this.solverButton.Click += new System.EventHandler(this.solverButton_Click);
            // 
            // expertButton
            // 
            this.expertButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.expertButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.expertButton.Location = new System.Drawing.Point(301, 254);
            this.expertButton.Name = "expertButton";
            this.expertButton.Size = new System.Drawing.Size(137, 38);
            this.expertButton.TabIndex = 0;
            this.expertButton.Values.Text = "EXPERT";
            this.expertButton.Click += new System.EventHandler(this.expertButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.normalButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.normalButton.Location = new System.Drawing.Point(301, 199);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(137, 38);
            this.normalButton.TabIndex = 0;
            this.normalButton.Values.Text = "NORMAL";
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.easyButton.Location = new System.Drawing.Point(301, 143);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(137, 38);
            this.easyButton.TabIndex = 0;
            this.easyButton.Values.Text = "EASY";
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.TextExtra = "©Zhiwei Liu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardPressUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetPalettes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetStyles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSetPalettes;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSetStyles;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton easyButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton normalButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton expertButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton solverButton;
    }
}

