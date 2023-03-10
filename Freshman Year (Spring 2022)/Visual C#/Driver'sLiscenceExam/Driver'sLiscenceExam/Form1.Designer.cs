namespace Driver_sLiscenceExam
{
    partial class Form1
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
            this.incorrectAnswersListBox = new System.Windows.Forms.ListBox();
            this.correctAnswersLabel = new System.Windows.Forms.Label();
            this.incorrectAnswersLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.correctAnswersOutputLabel = new System.Windows.Forms.Label();
            this.incorrectAnswersOutputLabel = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // incorrectAnswersListBox
            // 
            this.incorrectAnswersListBox.FormattingEnabled = true;
            this.incorrectAnswersListBox.ItemHeight = 16;
            this.incorrectAnswersListBox.Location = new System.Drawing.Point(0, 32);
            this.incorrectAnswersListBox.Name = "incorrectAnswersListBox";
            this.incorrectAnswersListBox.Size = new System.Drawing.Size(262, 196);
            this.incorrectAnswersListBox.TabIndex = 1;
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.AutoSize = true;
            this.correctAnswersLabel.Location = new System.Drawing.Point(13, 235);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(107, 16);
            this.correctAnswersLabel.TabIndex = 2;
            this.correctAnswersLabel.Text = "Correct Answers:";
            // 
            // incorrectAnswersLabel
            // 
            this.incorrectAnswersLabel.AutoSize = true;
            this.incorrectAnswersLabel.Location = new System.Drawing.Point(5, 260);
            this.incorrectAnswersLabel.Name = "incorrectAnswersLabel";
            this.incorrectAnswersLabel.Size = new System.Drawing.Size(115, 16);
            this.incorrectAnswersLabel.TabIndex = 3;
            this.incorrectAnswersLabel.Text = "Incorrect Answers:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(72, 289);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 16);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result:";
            // 
            // correctAnswersOutputLabel
            // 
            this.correctAnswersOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctAnswersOutputLabel.Location = new System.Drawing.Point(127, 235);
            this.correctAnswersOutputLabel.Name = "correctAnswersOutputLabel";
            this.correctAnswersOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.correctAnswersOutputLabel.TabIndex = 5;
            // 
            // incorrectAnswersOutputLabel
            // 
            this.incorrectAnswersOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.incorrectAnswersOutputLabel.Location = new System.Drawing.Point(127, 262);
            this.incorrectAnswersOutputLabel.Name = "incorrectAnswersOutputLabel";
            this.incorrectAnswersOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.incorrectAnswersOutputLabel.TabIndex = 6;
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultOutputLabel.Location = new System.Drawing.Point(127, 289);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.resultOutputLabel.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(45, 331);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(127, 331);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 371);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.incorrectAnswersOutputLabel);
            this.Controls.Add(this.correctAnswersOutputLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.incorrectAnswersLabel);
            this.Controls.Add(this.correctAnswersLabel);
            this.Controls.Add(this.incorrectAnswersListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Driver\'s Liscense Exam";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox incorrectAnswersListBox;
        private System.Windows.Forms.Label correctAnswersLabel;
        private System.Windows.Forms.Label incorrectAnswersLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label correctAnswersOutputLabel;
        private System.Windows.Forms.Label incorrectAnswersOutputLabel;
        private System.Windows.Forms.Label resultOutputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

