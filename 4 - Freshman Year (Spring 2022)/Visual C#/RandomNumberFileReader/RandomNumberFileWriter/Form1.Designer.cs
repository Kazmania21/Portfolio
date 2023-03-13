namespace RandomNumberFileWriter
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
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.randomNumberListBox = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a text file with random numbers. The total will be added to together, and th" +
    "e amount of numbers will be displayed.";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 37);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // randomNumberListBox
            // 
            this.randomNumberListBox.FormattingEnabled = true;
            this.randomNumberListBox.ItemHeight = 16;
            this.randomNumberListBox.Location = new System.Drawing.Point(15, 81);
            this.randomNumberListBox.Name = "randomNumberListBox";
            this.randomNumberListBox.Size = new System.Drawing.Size(120, 84);
            this.randomNumberListBox.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(15, 189);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(212, 23);
            this.totalLabel.TabIndex = 4;
            // 
            // amountLabel
            // 
            this.amountLabel.Location = new System.Drawing.Point(12, 231);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(215, 23);
            this.amountLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 279);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.randomNumberListBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Number File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox randomNumberListBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label amountLabel;
    }
}

