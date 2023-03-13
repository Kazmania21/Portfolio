namespace TotalSales
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
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.totalSalesOutputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateSalesButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.averageSalesLabel = new System.Windows.Forms.Label();
            this.averageSalesOutputLabel = new System.Windows.Forms.Label();
            this.largestValueLabel = new System.Windows.Forms.Label();
            this.largestValueOutputLabel = new System.Windows.Forms.Label();
            this.smallestValueLabel = new System.Windows.Forms.Label();
            this.smallestValueOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.ItemHeight = 16;
            this.salesListBox.Location = new System.Drawing.Point(0, 52);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(309, 196);
            this.salesListBox.TabIndex = 0;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Location = new System.Drawing.Point(62, 271);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(79, 16);
            this.totalSalesLabel.TabIndex = 2;
            this.totalSalesLabel.Text = "Total Sales:";
            // 
            // totalSalesOutputLabel
            // 
            this.totalSalesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesOutputLabel.Location = new System.Drawing.Point(147, 271);
            this.totalSalesOutputLabel.Name = "totalSalesOutputLabel";
            this.totalSalesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSalesOutputLabel.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(128, 438);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 51);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateSalesButton
            // 
            this.calculateSalesButton.Location = new System.Drawing.Point(27, 438);
            this.calculateSalesButton.Name = "calculateSalesButton";
            this.calculateSalesButton.Size = new System.Drawing.Size(95, 51);
            this.calculateSalesButton.TabIndex = 6;
            this.calculateSalesButton.Text = "Calculate Sales";
            this.calculateSalesButton.UseVisualStyleBackColor = true;
            this.calculateSalesButton.Click += new System.EventHandler(this.calculateSalesButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(256, 32);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "Click \"Calculate Sales\" to display all of the\r\nsales and their total value.";
            // 
            // averageSalesLabel
            // 
            this.averageSalesLabel.AutoSize = true;
            this.averageSalesLabel.Location = new System.Drawing.Point(41, 302);
            this.averageSalesLabel.Name = "averageSalesLabel";
            this.averageSalesLabel.Size = new System.Drawing.Size(100, 16);
            this.averageSalesLabel.TabIndex = 8;
            this.averageSalesLabel.Text = "Average Sales:";
            // 
            // averageSalesOutputLabel
            // 
            this.averageSalesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageSalesOutputLabel.Location = new System.Drawing.Point(147, 302);
            this.averageSalesOutputLabel.Name = "averageSalesOutputLabel";
            this.averageSalesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.averageSalesOutputLabel.TabIndex = 9;
            // 
            // largestValueLabel
            // 
            this.largestValueLabel.AutoSize = true;
            this.largestValueLabel.Location = new System.Drawing.Point(48, 330);
            this.largestValueLabel.Name = "largestValueLabel";
            this.largestValueLabel.Size = new System.Drawing.Size(93, 16);
            this.largestValueLabel.TabIndex = 10;
            this.largestValueLabel.Text = "Largest Value:";
            // 
            // largestValueOutputLabel
            // 
            this.largestValueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.largestValueOutputLabel.Location = new System.Drawing.Point(147, 330);
            this.largestValueOutputLabel.Name = "largestValueOutputLabel";
            this.largestValueOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.largestValueOutputLabel.TabIndex = 11;
            // 
            // smallestValueLabel
            // 
            this.smallestValueLabel.AutoSize = true;
            this.smallestValueLabel.Location = new System.Drawing.Point(41, 358);
            this.smallestValueLabel.Name = "smallestValueLabel";
            this.smallestValueLabel.Size = new System.Drawing.Size(100, 16);
            this.smallestValueLabel.TabIndex = 12;
            this.smallestValueLabel.Text = "Smallest Value:";
            // 
            // smallestValueOutputLabel
            // 
            this.smallestValueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallestValueOutputLabel.Location = new System.Drawing.Point(147, 358);
            this.smallestValueOutputLabel.Name = "smallestValueOutputLabel";
            this.smallestValueOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.smallestValueOutputLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 511);
            this.Controls.Add(this.smallestValueOutputLabel);
            this.Controls.Add(this.smallestValueLabel);
            this.Controls.Add(this.largestValueOutputLabel);
            this.Controls.Add(this.largestValueLabel);
            this.Controls.Add(this.averageSalesOutputLabel);
            this.Controls.Add(this.averageSalesLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.calculateSalesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalSalesOutputLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.salesListBox);
            this.Name = "Form1";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label totalSalesOutputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateSalesButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label averageSalesLabel;
        private System.Windows.Forms.Label averageSalesOutputLabel;
        private System.Windows.Forms.Label largestValueLabel;
        private System.Windows.Forms.Label largestValueOutputLabel;
        private System.Windows.Forms.Label smallestValueLabel;
        private System.Windows.Forms.Label smallestValueOutputLabel;
    }
}

