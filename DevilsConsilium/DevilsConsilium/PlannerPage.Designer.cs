namespace DevilsConsilium
{
    partial class PlannerPage
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.year1GroupBox = new System.Windows.Forms.GroupBox();
            this.year2GroupBox = new System.Windows.Forms.GroupBox();
            this.year3GroupBox = new System.Windows.Forms.GroupBox();
            this.year4GroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Location = new System.Drawing.Point(12, 27);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(128, 311);
            this.courseGroupBox.TabIndex = 1;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Courses";
            // 
            // year1GroupBox
            // 
            this.year1GroupBox.Location = new System.Drawing.Point(173, 27);
            this.year1GroupBox.Name = "year1GroupBox";
            this.year1GroupBox.Size = new System.Drawing.Size(499, 152);
            this.year1GroupBox.TabIndex = 2;
            this.year1GroupBox.TabStop = false;
            this.year1GroupBox.Text = "Year 1 (Freshman)";
            // 
            // year2GroupBox
            // 
            this.year2GroupBox.Location = new System.Drawing.Point(173, 186);
            this.year2GroupBox.Name = "year2GroupBox";
            this.year2GroupBox.Size = new System.Drawing.Size(499, 152);
            this.year2GroupBox.TabIndex = 3;
            this.year2GroupBox.TabStop = false;
            this.year2GroupBox.Text = "Year 2 (Sophomore)";
            // 
            // year3GroupBox
            // 
            this.year3GroupBox.Location = new System.Drawing.Point(173, 344);
            this.year3GroupBox.Name = "year3GroupBox";
            this.year3GroupBox.Size = new System.Drawing.Size(499, 152);
            this.year3GroupBox.TabIndex = 3;
            this.year3GroupBox.TabStop = false;
            this.year3GroupBox.Text = "Year 3 (Junior)";
            // 
            // year4GroupBox
            // 
            this.year4GroupBox.Location = new System.Drawing.Point(173, 502);
            this.year4GroupBox.Name = "year4GroupBox";
            this.year4GroupBox.Size = new System.Drawing.Size(499, 152);
            this.year4GroupBox.TabIndex = 3;
            this.year4GroupBox.TabStop = false;
            this.year4GroupBox.Text = "Year 4 (Senior)";
            // 
            // PlannerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.year4GroupBox);
            this.Controls.Add(this.year3GroupBox);
            this.Controls.Add(this.year2GroupBox);
            this.Controls.Add(this.year1GroupBox);
            this.Controls.Add(this.courseGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlannerPage";
            this.Text = "Devil\'s Consilium";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox courseGroupBox;
        private System.Windows.Forms.GroupBox year1GroupBox;
        private System.Windows.Forms.GroupBox year2GroupBox;
        private System.Windows.Forms.GroupBox year3GroupBox;
        private System.Windows.Forms.GroupBox year4GroupBox;
    }
}

