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
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.year1GroupBox = new System.Windows.Forms.GroupBox();
            this.yearOneSummer = new System.Windows.Forms.Label();
            this.yearOneSummerListBox = new System.Windows.Forms.ListBox();
            this.yearOneSpring = new System.Windows.Forms.Label();
            this.yearOneFall = new System.Windows.Forms.Label();
            this.yearOneSpringListBox = new System.Windows.Forms.ListBox();
            this.yearOneFallListBox = new System.Windows.Forms.ListBox();
            this.year2GroupBox = new System.Windows.Forms.GroupBox();
            this.yearTwoSummerLabel = new System.Windows.Forms.Label();
            this.yearTwoSummerListBox = new System.Windows.Forms.ListBox();
            this.yearTwoSpringLable = new System.Windows.Forms.Label();
            this.yearTwoFallLable = new System.Windows.Forms.Label();
            this.yearTwoSpringListBox = new System.Windows.Forms.ListBox();
            this.yearTwoFallListBox = new System.Windows.Forms.ListBox();
            this.year3GroupBox = new System.Windows.Forms.GroupBox();
            this.yearThreeSummerLabel = new System.Windows.Forms.Label();
            this.yearThreeSpringLabel = new System.Windows.Forms.Label();
            this.yearThreeSummerListBox = new System.Windows.Forms.ListBox();
            this.yearThreeFallLable = new System.Windows.Forms.Label();
            this.yearThreeSpringListBox = new System.Windows.Forms.ListBox();
            this.yearThreeFallListBox = new System.Windows.Forms.ListBox();
            this.year4GroupBox = new System.Windows.Forms.GroupBox();
            this.yearFourSummerLabel = new System.Windows.Forms.Label();
            this.yearFourSpringLabel = new System.Windows.Forms.Label();
            this.yearFourFallLabel = new System.Windows.Forms.Label();
            this.yearFourSpringListBox = new System.Windows.Forms.ListBox();
            this.yearFourFallListBox = new System.Windows.Forms.ListBox();
            this.yearFourSummerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseInformationPanel = new System.Windows.Forms.Panel();
            this.courseInfoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.courseGroupBox.SuspendLayout();
            this.year1GroupBox.SuspendLayout();
            this.year2GroupBox.SuspendLayout();
            this.year3GroupBox.SuspendLayout();
            this.year4GroupBox.SuspendLayout();
            this.courseInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(68, 22);
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.searchResultListBox);
            this.courseGroupBox.Controls.Add(this.searchButton);
            this.courseGroupBox.Controls.Add(this.searchTextBox);
            this.courseGroupBox.Location = new System.Drawing.Point(12, 25);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(128, 301);
            this.courseGroupBox.TabIndex = 1;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Courses";
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.AllowDrop = true;
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 12;
            this.searchResultListBox.Location = new System.Drawing.Point(6, 67);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(115, 220);
            this.searchResultListBox.TabIndex = 3;
            this.searchResultListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchResultListBox_MouseDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(26, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 21);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(7, 13);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ShortcutsEnabled = false;
            this.searchTextBox.Size = new System.Drawing.Size(115, 21);
            this.searchTextBox.TabIndex = 0;
            // 
            // year1GroupBox
            // 
            this.year1GroupBox.Controls.Add(this.yearOneSummer);
            this.year1GroupBox.Controls.Add(this.yearOneSummerListBox);
            this.year1GroupBox.Controls.Add(this.yearOneSpring);
            this.year1GroupBox.Controls.Add(this.yearOneFall);
            this.year1GroupBox.Controls.Add(this.yearOneSpringListBox);
            this.year1GroupBox.Controls.Add(this.yearOneFallListBox);
            this.year1GroupBox.Location = new System.Drawing.Point(173, 25);
            this.year1GroupBox.Name = "year1GroupBox";
            this.year1GroupBox.Size = new System.Drawing.Size(722, 140);
            this.year1GroupBox.TabIndex = 2;
            this.year1GroupBox.TabStop = false;
            this.year1GroupBox.Text = "Year 1 (Freshman)";
            // 
            // yearOneSummer
            // 
            this.yearOneSummer.AutoSize = true;
            this.yearOneSummer.Location = new System.Drawing.Point(488, 20);
            this.yearOneSummer.Name = "yearOneSummer";
            this.yearOneSummer.Size = new System.Drawing.Size(95, 12);
            this.yearOneSummer.TabIndex = 6;
            this.yearOneSummer.Text = "Summer Semester";
            // 
            // yearOneSummerListBox
            // 
            this.yearOneSummerListBox.FormattingEnabled = true;
            this.yearOneSummerListBox.ItemHeight = 12;
            this.yearOneSummerListBox.Location = new System.Drawing.Point(490, 35);
            this.yearOneSummerListBox.Name = "yearOneSummerListBox";
            this.yearOneSummerListBox.Size = new System.Drawing.Size(219, 100);
            this.yearOneSummerListBox.TabIndex = 5;
            // 
            // yearOneSpring
            // 
            this.yearOneSpring.AutoSize = true;
            this.yearOneSpring.Location = new System.Drawing.Point(252, 20);
            this.yearOneSpring.Name = "yearOneSpring";
            this.yearOneSpring.Size = new System.Drawing.Size(95, 12);
            this.yearOneSpring.TabIndex = 4;
            this.yearOneSpring.Text = "Spring Semester";
            // 
            // yearOneFall
            // 
            this.yearOneFall.AutoSize = true;
            this.yearOneFall.Location = new System.Drawing.Point(20, 20);
            this.yearOneFall.Name = "yearOneFall";
            this.yearOneFall.Size = new System.Drawing.Size(83, 12);
            this.yearOneFall.TabIndex = 3;
            this.yearOneFall.Text = "Fall Semester";
            // 
            // yearOneSpringListBox
            // 
            this.yearOneSpringListBox.FormattingEnabled = true;
            this.yearOneSpringListBox.ItemHeight = 12;
            this.yearOneSpringListBox.Location = new System.Drawing.Point(255, 35);
            this.yearOneSpringListBox.Name = "yearOneSpringListBox";
            this.yearOneSpringListBox.Size = new System.Drawing.Size(219, 100);
            this.yearOneSpringListBox.TabIndex = 1;
            // 
            // yearOneFallListBox
            // 
            this.yearOneFallListBox.AllowDrop = true;
            this.yearOneFallListBox.FormattingEnabled = true;
            this.yearOneFallListBox.ItemHeight = 12;
            this.yearOneFallListBox.Location = new System.Drawing.Point(20, 35);
            this.yearOneFallListBox.Name = "yearOneFallListBox";
            this.yearOneFallListBox.Size = new System.Drawing.Size(219, 100);
            this.yearOneFallListBox.TabIndex = 0;
            this.yearOneFallListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.yearOneFallListBox_DragDrop);
            this.yearOneFallListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.yearOneFallListBox_DragEnter);
            // 
            // year2GroupBox
            // 
            this.year2GroupBox.Controls.Add(this.yearTwoSummerLabel);
            this.year2GroupBox.Controls.Add(this.yearTwoSummerListBox);
            this.year2GroupBox.Controls.Add(this.yearTwoSpringLable);
            this.year2GroupBox.Controls.Add(this.yearTwoFallLable);
            this.year2GroupBox.Controls.Add(this.yearTwoSpringListBox);
            this.year2GroupBox.Controls.Add(this.yearTwoFallListBox);
            this.year2GroupBox.Location = new System.Drawing.Point(173, 172);
            this.year2GroupBox.Name = "year2GroupBox";
            this.year2GroupBox.Size = new System.Drawing.Size(722, 140);
            this.year2GroupBox.TabIndex = 3;
            this.year2GroupBox.TabStop = false;
            this.year2GroupBox.Text = "Year 2 (Sophomore)";
            // 
            // yearTwoSummerLabel
            // 
            this.yearTwoSummerLabel.AutoSize = true;
            this.yearTwoSummerLabel.Location = new System.Drawing.Point(488, 20);
            this.yearTwoSummerLabel.Name = "yearTwoSummerLabel";
            this.yearTwoSummerLabel.Size = new System.Drawing.Size(95, 12);
            this.yearTwoSummerLabel.TabIndex = 7;
            this.yearTwoSummerLabel.Text = "Summer Semester";
            // 
            // yearTwoSummerListBox
            // 
            this.yearTwoSummerListBox.FormattingEnabled = true;
            this.yearTwoSummerListBox.ItemHeight = 12;
            this.yearTwoSummerListBox.Location = new System.Drawing.Point(490, 35);
            this.yearTwoSummerListBox.Name = "yearTwoSummerListBox";
            this.yearTwoSummerListBox.Size = new System.Drawing.Size(219, 100);
            this.yearTwoSummerListBox.TabIndex = 7;
            // 
            // yearTwoSpringLable
            // 
            this.yearTwoSpringLable.AutoSize = true;
            this.yearTwoSpringLable.Location = new System.Drawing.Point(252, 20);
            this.yearTwoSpringLable.Name = "yearTwoSpringLable";
            this.yearTwoSpringLable.Size = new System.Drawing.Size(95, 12);
            this.yearTwoSpringLable.TabIndex = 5;
            this.yearTwoSpringLable.Text = "Spring Semester";
            // 
            // yearTwoFallLable
            // 
            this.yearTwoFallLable.AutoSize = true;
            this.yearTwoFallLable.Location = new System.Drawing.Point(20, 20);
            this.yearTwoFallLable.Name = "yearTwoFallLable";
            this.yearTwoFallLable.Size = new System.Drawing.Size(83, 12);
            this.yearTwoFallLable.TabIndex = 4;
            this.yearTwoFallLable.Text = "Fall Semester";
            // 
            // yearTwoSpringListBox
            // 
            this.yearTwoSpringListBox.FormattingEnabled = true;
            this.yearTwoSpringListBox.ItemHeight = 12;
            this.yearTwoSpringListBox.Location = new System.Drawing.Point(255, 35);
            this.yearTwoSpringListBox.Name = "yearTwoSpringListBox";
            this.yearTwoSpringListBox.Size = new System.Drawing.Size(219, 100);
            this.yearTwoSpringListBox.TabIndex = 3;
            // 
            // yearTwoFallListBox
            // 
            this.yearTwoFallListBox.FormattingEnabled = true;
            this.yearTwoFallListBox.ItemHeight = 12;
            this.yearTwoFallListBox.Location = new System.Drawing.Point(20, 35);
            this.yearTwoFallListBox.Name = "yearTwoFallListBox";
            this.yearTwoFallListBox.Size = new System.Drawing.Size(219, 100);
            this.yearTwoFallListBox.TabIndex = 2;
            // 
            // year3GroupBox
            // 
            this.year3GroupBox.Controls.Add(this.yearThreeSummerLabel);
            this.year3GroupBox.Controls.Add(this.yearThreeSpringLabel);
            this.year3GroupBox.Controls.Add(this.yearThreeSummerListBox);
            this.year3GroupBox.Controls.Add(this.yearThreeFallLable);
            this.year3GroupBox.Controls.Add(this.yearThreeSpringListBox);
            this.year3GroupBox.Controls.Add(this.yearThreeFallListBox);
            this.year3GroupBox.Location = new System.Drawing.Point(173, 318);
            this.year3GroupBox.Name = "year3GroupBox";
            this.year3GroupBox.Size = new System.Drawing.Size(722, 140);
            this.year3GroupBox.TabIndex = 3;
            this.year3GroupBox.TabStop = false;
            this.year3GroupBox.Text = "Year 3 (Junior)";
            // 
            // yearThreeSummerLabel
            // 
            this.yearThreeSummerLabel.AutoSize = true;
            this.yearThreeSummerLabel.Location = new System.Drawing.Point(488, 20);
            this.yearThreeSummerLabel.Name = "yearThreeSummerLabel";
            this.yearThreeSummerLabel.Size = new System.Drawing.Size(95, 12);
            this.yearThreeSummerLabel.TabIndex = 8;
            this.yearThreeSummerLabel.Text = "Summer Semester";
            // 
            // yearThreeSpringLabel
            // 
            this.yearThreeSpringLabel.AutoSize = true;
            this.yearThreeSpringLabel.Location = new System.Drawing.Point(252, 20);
            this.yearThreeSpringLabel.Name = "yearThreeSpringLabel";
            this.yearThreeSpringLabel.Size = new System.Drawing.Size(95, 12);
            this.yearThreeSpringLabel.TabIndex = 6;
            this.yearThreeSpringLabel.Text = "Spring Semester";
            // 
            // yearThreeSummerListBox
            // 
            this.yearThreeSummerListBox.FormattingEnabled = true;
            this.yearThreeSummerListBox.ItemHeight = 12;
            this.yearThreeSummerListBox.Location = new System.Drawing.Point(490, 35);
            this.yearThreeSummerListBox.Name = "yearThreeSummerListBox";
            this.yearThreeSummerListBox.Size = new System.Drawing.Size(219, 100);
            this.yearThreeSummerListBox.TabIndex = 6;
            // 
            // yearThreeFallLable
            // 
            this.yearThreeFallLable.AutoSize = true;
            this.yearThreeFallLable.Location = new System.Drawing.Point(20, 20);
            this.yearThreeFallLable.Name = "yearThreeFallLable";
            this.yearThreeFallLable.Size = new System.Drawing.Size(83, 12);
            this.yearThreeFallLable.TabIndex = 5;
            this.yearThreeFallLable.Text = "Fall Semester";
            // 
            // yearThreeSpringListBox
            // 
            this.yearThreeSpringListBox.FormattingEnabled = true;
            this.yearThreeSpringListBox.ItemHeight = 12;
            this.yearThreeSpringListBox.Location = new System.Drawing.Point(255, 35);
            this.yearThreeSpringListBox.Name = "yearThreeSpringListBox";
            this.yearThreeSpringListBox.Size = new System.Drawing.Size(219, 100);
            this.yearThreeSpringListBox.TabIndex = 5;
            // 
            // yearThreeFallListBox
            // 
            this.yearThreeFallListBox.FormattingEnabled = true;
            this.yearThreeFallListBox.ItemHeight = 12;
            this.yearThreeFallListBox.Location = new System.Drawing.Point(20, 35);
            this.yearThreeFallListBox.Name = "yearThreeFallListBox";
            this.yearThreeFallListBox.Size = new System.Drawing.Size(219, 100);
            this.yearThreeFallListBox.TabIndex = 4;
            // 
            // year4GroupBox
            // 
            this.year4GroupBox.Controls.Add(this.yearFourSummerLabel);
            this.year4GroupBox.Controls.Add(this.yearFourSpringLabel);
            this.year4GroupBox.Controls.Add(this.yearFourFallLabel);
            this.year4GroupBox.Controls.Add(this.yearFourSpringListBox);
            this.year4GroupBox.Controls.Add(this.yearFourFallListBox);
            this.year4GroupBox.Location = new System.Drawing.Point(173, 463);
            this.year4GroupBox.Name = "year4GroupBox";
            this.year4GroupBox.Size = new System.Drawing.Size(722, 140);
            this.year4GroupBox.TabIndex = 3;
            this.year4GroupBox.TabStop = false;
            this.year4GroupBox.Text = "Year 4 (Senior)";
            // 
            // yearFourSummerLabel
            // 
            this.yearFourSummerLabel.AutoSize = true;
            this.yearFourSummerLabel.Location = new System.Drawing.Point(488, 20);
            this.yearFourSummerLabel.Name = "yearFourSummerLabel";
            this.yearFourSummerLabel.Size = new System.Drawing.Size(95, 12);
            this.yearFourSummerLabel.TabIndex = 9;
            this.yearFourSummerLabel.Text = "Summer Semester";
            // 
            // yearFourSpringLabel
            // 
            this.yearFourSpringLabel.AutoSize = true;
            this.yearFourSpringLabel.Location = new System.Drawing.Point(252, 20);
            this.yearFourSpringLabel.Name = "yearFourSpringLabel";
            this.yearFourSpringLabel.Size = new System.Drawing.Size(95, 12);
            this.yearFourSpringLabel.TabIndex = 5;
            this.yearFourSpringLabel.Text = "Spring Semester";
            // 
            // yearFourFallLabel
            // 
            this.yearFourFallLabel.AutoSize = true;
            this.yearFourFallLabel.Location = new System.Drawing.Point(20, 20);
            this.yearFourFallLabel.Name = "yearFourFallLabel";
            this.yearFourFallLabel.Size = new System.Drawing.Size(83, 12);
            this.yearFourFallLabel.TabIndex = 6;
            this.yearFourFallLabel.Text = "Fall Semester";
            // 
            // yearFourSpringListBox
            // 
            this.yearFourSpringListBox.FormattingEnabled = true;
            this.yearFourSpringListBox.ItemHeight = 12;
            this.yearFourSpringListBox.Location = new System.Drawing.Point(255, 35);
            this.yearFourSpringListBox.Name = "yearFourSpringListBox";
            this.yearFourSpringListBox.Size = new System.Drawing.Size(219, 100);
            this.yearFourSpringListBox.TabIndex = 7;
            // 
            // yearFourFallListBox
            // 
            this.yearFourFallListBox.FormattingEnabled = true;
            this.yearFourFallListBox.ItemHeight = 12;
            this.yearFourFallListBox.Location = new System.Drawing.Point(20, 35);
            this.yearFourFallListBox.Name = "yearFourFallListBox";
            this.yearFourFallListBox.Size = new System.Drawing.Size(219, 100);
            this.yearFourFallListBox.TabIndex = 6;
            // 
            // yearFourSummerListBox
            // 
            this.yearFourSummerListBox.FormattingEnabled = true;
            this.yearFourSummerListBox.ItemHeight = 12;
            this.yearFourSummerListBox.Location = new System.Drawing.Point(664, 498);
            this.yearFourSummerListBox.Name = "yearFourSummerListBox";
            this.yearFourSummerListBox.Size = new System.Drawing.Size(219, 100);
            this.yearFourSummerListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course Information";
            // 
            // courseInformationPanel
            // 
            this.courseInformationPanel.Controls.Add(this.courseInfoLabel);
            this.courseInformationPanel.Location = new System.Drawing.Point(12, 340);
            this.courseInformationPanel.Name = "courseInformationPanel";
            this.courseInformationPanel.Size = new System.Drawing.Size(155, 258);
            this.courseInformationPanel.TabIndex = 9;
            // 
            // courseInfoLabel
            // 
            this.courseInfoLabel.Location = new System.Drawing.Point(7, 3);
            this.courseInfoLabel.Name = "courseInfoLabel";
            this.courseInfoLabel.Size = new System.Drawing.Size(145, 255);
            this.courseInfoLabel.TabIndex = 0;
            // 
            // PlannerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 611);
            this.Controls.Add(this.courseInformationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearFourSummerListBox);
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
            this.courseGroupBox.ResumeLayout(false);
            this.courseGroupBox.PerformLayout();
            this.year1GroupBox.ResumeLayout(false);
            this.year1GroupBox.PerformLayout();
            this.year2GroupBox.ResumeLayout(false);
            this.year2GroupBox.PerformLayout();
            this.year3GroupBox.ResumeLayout(false);
            this.year3GroupBox.PerformLayout();
            this.year4GroupBox.ResumeLayout(false);
            this.year4GroupBox.PerformLayout();
            this.courseInformationPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox yearOneSpringListBox;
        private System.Windows.Forms.ListBox yearOneFallListBox;
        private System.Windows.Forms.ListBox yearTwoSpringListBox;
        private System.Windows.Forms.ListBox yearTwoFallListBox;
        private System.Windows.Forms.ListBox yearThreeSpringListBox;
        private System.Windows.Forms.ListBox yearThreeFallListBox;
        private System.Windows.Forms.ListBox yearFourSpringListBox;
        private System.Windows.Forms.ListBox yearFourFallListBox;
        private System.Windows.Forms.Label yearOneSpring;
        private System.Windows.Forms.Label yearOneFall;
        private System.Windows.Forms.Label yearTwoSpringLable;
        private System.Windows.Forms.Label yearTwoFallLable;
        private System.Windows.Forms.Label yearThreeSpringLabel;
        private System.Windows.Forms.Label yearThreeFallLable;
        private System.Windows.Forms.Label yearFourSpringLabel;
        private System.Windows.Forms.Label yearFourFallLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label yearOneSummer;
        private System.Windows.Forms.ListBox yearOneSummerListBox;
        private System.Windows.Forms.Label yearTwoSummerLabel;
        private System.Windows.Forms.ListBox yearTwoSummerListBox;
        private System.Windows.Forms.Label yearThreeSummerLabel;
        private System.Windows.Forms.ListBox yearThreeSummerListBox;
        private System.Windows.Forms.Label yearFourSummerLabel;
        private System.Windows.Forms.ListBox yearFourSummerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel courseInformationPanel;
        private System.Windows.Forms.Label courseInfoLabel;
    }
}

