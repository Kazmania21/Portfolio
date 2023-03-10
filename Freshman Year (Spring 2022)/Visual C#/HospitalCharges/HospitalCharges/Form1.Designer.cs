namespace HospitalCharges
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medicationChargesLabel = new System.Windows.Forms.Label();
            this.medicationChargesTextBox = new System.Windows.Forms.TextBox();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesTextBox = new System.Windows.Forms.TextBox();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.physicalRehabChargesLabel = new System.Windows.Forms.Label();
            this.physicalRehabChargesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostResultLabel = new System.Windows.Forms.Label();
            this.daysGroupBox = new System.Windows.Forms.GroupBox();
            this.miscChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.daysSpentLabel = new System.Windows.Forms.Label();
            this.daysSpentResultLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesResultLabel = new System.Windows.Forms.Label();
            this.daysGroupBox.SuspendLayout();
            this.miscChargesGroupBox.SuspendLayout();
            this.totalChargesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(374, 44);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Type in the corresponding information and\r\n press calculate to calculate the tota" +
    "l charges.";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(11, 28);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(222, 16);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Amount of days spent in the hospital:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(250, 28);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 22);
            this.daysTextBox.TabIndex = 2;
            // 
            // medicationChargesLabel
            // 
            this.medicationChargesLabel.AutoSize = true;
            this.medicationChargesLabel.Location = new System.Drawing.Point(100, 30);
            this.medicationChargesLabel.Name = "medicationChargesLabel";
            this.medicationChargesLabel.Size = new System.Drawing.Size(130, 16);
            this.medicationChargesLabel.TabIndex = 3;
            this.medicationChargesLabel.Text = "Medication Charges:";
            // 
            // medicationChargesTextBox
            // 
            this.medicationChargesTextBox.Location = new System.Drawing.Point(247, 30);
            this.medicationChargesTextBox.Name = "medicationChargesTextBox";
            this.medicationChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.medicationChargesTextBox.TabIndex = 4;
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(117, 60);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(113, 16);
            this.surgicalChargesLabel.TabIndex = 5;
            this.surgicalChargesLabel.Text = "Surgical Charges:";
            // 
            // surgicalChargesTextBox
            // 
            this.surgicalChargesTextBox.Location = new System.Drawing.Point(247, 60);
            this.surgicalChargesTextBox.Name = "surgicalChargesTextBox";
            this.surgicalChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.surgicalChargesTextBox.TabIndex = 6;
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(163, 90);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(67, 16);
            this.labFeesLabel.TabIndex = 7;
            this.labFeesLabel.Text = "Lab Fees:";
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(247, 89);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 22);
            this.labFeesTextBox.TabIndex = 8;
            // 
            // physicalRehabChargesLabel
            // 
            this.physicalRehabChargesLabel.AutoSize = true;
            this.physicalRehabChargesLabel.Location = new System.Drawing.Point(30, 119);
            this.physicalRehabChargesLabel.Name = "physicalRehabChargesLabel";
            this.physicalRehabChargesLabel.Size = new System.Drawing.Size(200, 16);
            this.physicalRehabChargesLabel.TabIndex = 9;
            this.physicalRehabChargesLabel.Text = "Physical Rehabilitation Charges:";
            // 
            // physicalRehabChargesTextBox
            // 
            this.physicalRehabChargesTextBox.Location = new System.Drawing.Point(247, 119);
            this.physicalRehabChargesTextBox.Name = "physicalRehabChargesTextBox";
            this.physicalRehabChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.physicalRehabChargesTextBox.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(51, 478);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(165, 478);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(265, 477);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(152, 83);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(78, 16);
            this.totalCostLabel.TabIndex = 14;
            this.totalCostLabel.Text = "Total Cost =";
            // 
            // totalCostResultLabel
            // 
            this.totalCostResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostResultLabel.Location = new System.Drawing.Point(247, 83);
            this.totalCostResultLabel.Name = "totalCostResultLabel";
            this.totalCostResultLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostResultLabel.TabIndex = 15;
            // 
            // daysGroupBox
            // 
            this.daysGroupBox.Controls.Add(this.daysLabel);
            this.daysGroupBox.Controls.Add(this.daysTextBox);
            this.daysGroupBox.Location = new System.Drawing.Point(15, 75);
            this.daysGroupBox.Name = "daysGroupBox";
            this.daysGroupBox.Size = new System.Drawing.Size(373, 75);
            this.daysGroupBox.TabIndex = 16;
            this.daysGroupBox.TabStop = false;
            this.daysGroupBox.Text = "Days in Hospital";
            // 
            // miscChargesGroupBox
            // 
            this.miscChargesGroupBox.Controls.Add(this.medicationChargesTextBox);
            this.miscChargesGroupBox.Controls.Add(this.medicationChargesLabel);
            this.miscChargesGroupBox.Controls.Add(this.surgicalChargesLabel);
            this.miscChargesGroupBox.Controls.Add(this.surgicalChargesTextBox);
            this.miscChargesGroupBox.Controls.Add(this.labFeesLabel);
            this.miscChargesGroupBox.Controls.Add(this.labFeesTextBox);
            this.miscChargesGroupBox.Controls.Add(this.physicalRehabChargesLabel);
            this.miscChargesGroupBox.Controls.Add(this.physicalRehabChargesTextBox);
            this.miscChargesGroupBox.Location = new System.Drawing.Point(18, 157);
            this.miscChargesGroupBox.Name = "miscChargesGroupBox";
            this.miscChargesGroupBox.Size = new System.Drawing.Size(370, 161);
            this.miscChargesGroupBox.TabIndex = 17;
            this.miscChargesGroupBox.TabStop = false;
            this.miscChargesGroupBox.Text = "Charges and Fees in Dollars";
            // 
            // totalChargesGroupBox
            // 
            this.totalChargesGroupBox.Controls.Add(this.miscChargesResultLabel);
            this.totalChargesGroupBox.Controls.Add(this.miscChargesLabel);
            this.totalChargesGroupBox.Controls.Add(this.daysSpentResultLabel);
            this.totalChargesGroupBox.Controls.Add(this.totalCostResultLabel);
            this.totalChargesGroupBox.Controls.Add(this.daysSpentLabel);
            this.totalChargesGroupBox.Controls.Add(this.totalCostLabel);
            this.totalChargesGroupBox.Location = new System.Drawing.Point(18, 325);
            this.totalChargesGroupBox.Name = "totalChargesGroupBox";
            this.totalChargesGroupBox.Size = new System.Drawing.Size(370, 128);
            this.totalChargesGroupBox.TabIndex = 18;
            this.totalChargesGroupBox.TabStop = false;
            this.totalChargesGroupBox.Text = "Total Charges";
            // 
            // daysSpentLabel
            // 
            this.daysSpentLabel.AutoSize = true;
            this.daysSpentLabel.Location = new System.Drawing.Point(104, 18);
            this.daysSpentLabel.Name = "daysSpentLabel";
            this.daysSpentLabel.Size = new System.Drawing.Size(126, 16);
            this.daysSpentLabel.TabIndex = 0;
            this.daysSpentLabel.Text = "Days Spent * $350 =";
            // 
            // daysSpentResultLabel
            // 
            this.daysSpentResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daysSpentResultLabel.Location = new System.Drawing.Point(247, 18);
            this.daysSpentResultLabel.Name = "daysSpentResultLabel";
            this.daysSpentResultLabel.Size = new System.Drawing.Size(100, 23);
            this.daysSpentResultLabel.TabIndex = 1;
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Location = new System.Drawing.Point(72, 48);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(158, 16);
            this.miscChargesLabel.TabIndex = 2;
            this.miscChargesLabel.Text = "Miscellaneous Charges =";
            // 
            // miscChargesResultLabel
            // 
            this.miscChargesResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miscChargesResultLabel.Location = new System.Drawing.Point(247, 48);
            this.miscChargesResultLabel.Name = "miscChargesResultLabel";
            this.miscChargesResultLabel.Size = new System.Drawing.Size(100, 23);
            this.miscChargesResultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 544);
            this.Controls.Add(this.totalChargesGroupBox);
            this.Controls.Add(this.miscChargesGroupBox);
            this.Controls.Add(this.daysGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.daysGroupBox.ResumeLayout(false);
            this.daysGroupBox.PerformLayout();
            this.miscChargesGroupBox.ResumeLayout(false);
            this.miscChargesGroupBox.PerformLayout();
            this.totalChargesGroupBox.ResumeLayout(false);
            this.totalChargesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label medicationChargesLabel;
        private System.Windows.Forms.TextBox medicationChargesTextBox;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.TextBox surgicalChargesTextBox;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.Label physicalRehabChargesLabel;
        private System.Windows.Forms.TextBox physicalRehabChargesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostResultLabel;
        private System.Windows.Forms.GroupBox daysGroupBox;
        private System.Windows.Forms.GroupBox miscChargesGroupBox;
        private System.Windows.Forms.GroupBox totalChargesGroupBox;
        private System.Windows.Forms.Label daysSpentLabel;
        private System.Windows.Forms.Label daysSpentResultLabel;
        private System.Windows.Forms.Label miscChargesResultLabel;
        private System.Windows.Forms.Label miscChargesLabel;
    }
}

