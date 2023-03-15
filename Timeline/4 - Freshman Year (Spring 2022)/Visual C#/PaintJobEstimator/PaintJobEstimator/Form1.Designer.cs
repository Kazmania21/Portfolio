namespace PaintJobEstimator
{
    partial class wallSpaceLabel
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
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.calculatePriceButton = new System.Windows.Forms.Button();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.costForPaintLabel = new System.Windows.Forms.Label();
            this.costForPaintTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wall space that needs to be covered:";
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.Location = new System.Drawing.Point(262, 13);
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 22);
            this.wallSpaceTextBox.TabIndex = 1;
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(392, 2);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(75, 45);
            this.calculatePriceButton.TabIndex = 2;
            this.calculatePriceButton.Text = "Calculate Price";
            this.calculatePriceButton.UseVisualStyleBackColor = true;
            this.calculatePriceButton.Click += new System.EventHandler(this.calculatePriceButton_Click);
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsLabel.Location = new System.Drawing.Point(13, 77);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(2, 18);
            this.gallonsLabel.TabIndex = 3;
            this.gallonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLabel.Location = new System.Drawing.Point(13, 128);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(2, 18);
            this.hoursLabel.TabIndex = 4;
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(13, 185);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(2, 18);
            this.totalPriceLabel.TabIndex = 5;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costForPaintLabel
            // 
            this.costForPaintLabel.AutoSize = true;
            this.costForPaintLabel.Location = new System.Drawing.Point(159, 44);
            this.costForPaintLabel.Name = "costForPaintLabel";
            this.costForPaintLabel.Size = new System.Drawing.Size(83, 16);
            this.costForPaintLabel.TabIndex = 6;
            this.costForPaintLabel.Text = "Cost of paint:";
            // 
            // costForPaintTextBox
            // 
            this.costForPaintTextBox.Location = new System.Drawing.Point(262, 44);
            this.costForPaintTextBox.Name = "costForPaintTextBox";
            this.costForPaintTextBox.Size = new System.Drawing.Size(100, 22);
            this.costForPaintTextBox.TabIndex = 7;
            // 
            // wallSpaceLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costForPaintTextBox);
            this.Controls.Add(this.costForPaintLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.calculatePriceButton);
            this.Controls.Add(this.wallSpaceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "wallSpaceLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.Button calculatePriceButton;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label costForPaintLabel;
        private System.Windows.Forms.TextBox costForPaintTextBox;
    }
}

