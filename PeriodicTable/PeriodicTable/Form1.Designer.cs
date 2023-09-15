namespace PeriodicTable
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSymbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSymbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.showNumbersToolStripMenuItem,
            this.showSymbolsToolStripMenuItem,
            this.showNamesToolStripMenuItem,
            this.showMassesToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.showToolStripMenuItem.Text = "Show ";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem_Click);
            // 
            // showNumbersToolStripMenuItem
            // 
            this.showNumbersToolStripMenuItem.Name = "showNumbersToolStripMenuItem";
            this.showNumbersToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showNumbersToolStripMenuItem.Text = "Show Numbers";
            this.showNumbersToolStripMenuItem.Click += new System.EventHandler(this.ShowNumbersToolStripMenuItem_Click);
            // 
            // showSymbolsToolStripMenuItem
            // 
            this.showSymbolsToolStripMenuItem.Name = "showSymbolsToolStripMenuItem";
            this.showSymbolsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showSymbolsToolStripMenuItem.Text = "Show Symbols";
            this.showSymbolsToolStripMenuItem.Click += new System.EventHandler(this.ShowSymbolsToolStripMenuItem_Click);
            // 
            // showNamesToolStripMenuItem
            // 
            this.showNamesToolStripMenuItem.Name = "showNamesToolStripMenuItem";
            this.showNamesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showNamesToolStripMenuItem.Text = "Show Names";
            this.showNamesToolStripMenuItem.Click += new System.EventHandler(this.ShowNamesToolStripMenuItem_Click);
            // 
            // showMassesToolStripMenuItem
            // 
            this.showMassesToolStripMenuItem.Name = "showMassesToolStripMenuItem";
            this.showMassesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showMassesToolStripMenuItem.Text = "Show Masses";
            this.showMassesToolStripMenuItem.Click += new System.EventHandler(this.ShowMassesToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideAllToolStripMenuItem,
            this.hideNumbersToolStripMenuItem,
            this.hideSymbolsToolStripMenuItem,
            this.hideNamesToolStripMenuItem,
            this.hideMassesToolStripMenuItem});
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hideToolStripMenuItem.Text = "Hide";
            // 
            // hideAllToolStripMenuItem
            // 
            this.hideAllToolStripMenuItem.Name = "hideAllToolStripMenuItem";
            this.hideAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hideAllToolStripMenuItem.Text = "Hide All";
            this.hideAllToolStripMenuItem.Click += new System.EventHandler(this.HideAllToolStripMenuItem_Click);
            // 
            // hideNumbersToolStripMenuItem
            // 
            this.hideNumbersToolStripMenuItem.Name = "hideNumbersToolStripMenuItem";
            this.hideNumbersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hideNumbersToolStripMenuItem.Text = "Hide Numbers";
            this.hideNumbersToolStripMenuItem.Click += new System.EventHandler(this.HideNumbersToolStripMenuItem_Click);
            // 
            // hideSymbolsToolStripMenuItem
            // 
            this.hideSymbolsToolStripMenuItem.Name = "hideSymbolsToolStripMenuItem";
            this.hideSymbolsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hideSymbolsToolStripMenuItem.Text = "Hide Symbols";
            this.hideSymbolsToolStripMenuItem.Click += new System.EventHandler(this.HideSymbolsToolStripMenuItem_Click);
            // 
            // hideNamesToolStripMenuItem
            // 
            this.hideNamesToolStripMenuItem.Name = "hideNamesToolStripMenuItem";
            this.hideNamesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hideNamesToolStripMenuItem.Text = "Hide Names";
            this.hideNamesToolStripMenuItem.Click += new System.EventHandler(this.HideNamesToolStripMenuItem_Click);
            // 
            // hideMassesToolStripMenuItem
            // 
            this.hideMassesToolStripMenuItem.Name = "hideMassesToolStripMenuItem";
            this.hideMassesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hideMassesToolStripMenuItem.Text = "Hide Masses";
            this.hideMassesToolStripMenuItem.Click += new System.EventHandler(this.HideMassesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1400, 904);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periodic Table";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSymbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideSymbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

