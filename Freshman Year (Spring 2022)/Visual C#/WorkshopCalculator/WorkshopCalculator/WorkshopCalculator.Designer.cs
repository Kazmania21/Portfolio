namespace WorkshopCalculator
{
    partial class WorkshopCalculator
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
            this.workshopTypeListBox = new System.Windows.Forms.ListBox();
            this.workshopLocationListBox = new System.Windows.Forms.ListBox();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculatorInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopTypeListBox
            // 
            this.workshopTypeListBox.FormattingEnabled = true;
            this.workshopTypeListBox.ItemHeight = 16;
            this.workshopTypeListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopTypeListBox.Location = new System.Drawing.Point(34, 94);
            this.workshopTypeListBox.Name = "workshopTypeListBox";
            this.workshopTypeListBox.Size = new System.Drawing.Size(131, 100);
            this.workshopTypeListBox.TabIndex = 0;
            // 
            // workshopLocationListBox
            // 
            this.workshopLocationListBox.FormattingEnabled = true;
            this.workshopLocationListBox.ItemHeight = 16;
            this.workshopLocationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.workshopLocationListBox.Location = new System.Drawing.Point(186, 94);
            this.workshopLocationListBox.Name = "workshopLocationListBox";
            this.workshopLocationListBox.Size = new System.Drawing.Size(120, 100);
            this.workshopLocationListBox.TabIndex = 1;
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(31, 75);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(72, 16);
            this.workshopLabel.TabIndex = 2;
            this.workshopLabel.Text = "Workshop:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(183, 75);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(58, 16);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(200, 16);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Pick a workshop and its location.";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(69, 306);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 306);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationLabel.Location = new System.Drawing.Point(13, 214);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(321, 23);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.Text = "Registration fee:";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingLabel.Location = new System.Drawing.Point(13, 237);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(321, 23);
            this.lodgingLabel.TabIndex = 8;
            this.lodgingLabel.Text = "Daily lodging fee:";
            this.lodgingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(13, 260);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(321, 23);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculatorInstructionLabel
            // 
            this.calculatorInstructionLabel.AutoSize = true;
            this.calculatorInstructionLabel.Location = new System.Drawing.Point(13, 29);
            this.calculatorInstructionLabel.Name = "calculatorInstructionLabel";
            this.calculatorInstructionLabel.Size = new System.Drawing.Size(321, 16);
            this.calculatorInstructionLabel.TabIndex = 10;
            this.calculatorInstructionLabel.Text = "Press calculate to see the amount of money required.";
            // 
            // WorkshopCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 345);
            this.Controls.Add(this.calculatorInstructionLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.workshopLocationListBox);
            this.Controls.Add(this.workshopTypeListBox);
            this.Name = "WorkshopCalculator";
            this.Text = "Workshop Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workshopTypeListBox;
        private System.Windows.Forms.ListBox workshopLocationListBox;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label calculatorInstructionLabel;
    }
}

