namespace FatPercentageCalculator
{
    partial class FatPercenatgeCalculator
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
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.totalCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.fatGramsLabel = new System.Windows.Forms.Label();
            this.fatGramsTextBox = new System.Windows.Forms.TextBox();
            this.fatCaloriesLabel = new System.Windows.Forms.Label();
            this.fatCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.calculateTextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(34, 66);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(94, 16);
            this.totalCaloriesLabel.TabIndex = 0;
            this.totalCaloriesLabel.Text = "Total Calories:";
            // 
            // totalCaloriesTextBox
            // 
            this.totalCaloriesTextBox.Location = new System.Drawing.Point(138, 66);
            this.totalCaloriesTextBox.Name = "totalCaloriesTextBox";
            this.totalCaloriesTextBox.Size = new System.Drawing.Size(136, 22);
            this.totalCaloriesTextBox.TabIndex = 1;
            // 
            // fatGramsLabel
            // 
            this.fatGramsLabel.AutoSize = true;
            this.fatGramsLabel.Location = new System.Drawing.Point(56, 104);
            this.fatGramsLabel.Name = "fatGramsLabel";
            this.fatGramsLabel.Size = new System.Drawing.Size(72, 16);
            this.fatGramsLabel.TabIndex = 2;
            this.fatGramsLabel.Text = "Fat Grams:";
            // 
            // fatGramsTextBox
            // 
            this.fatGramsTextBox.Location = new System.Drawing.Point(138, 104);
            this.fatGramsTextBox.Name = "fatGramsTextBox";
            this.fatGramsTextBox.Size = new System.Drawing.Size(136, 22);
            this.fatGramsTextBox.TabIndex = 3;
            // 
            // fatCaloriesLabel
            // 
            this.fatCaloriesLabel.AutoSize = true;
            this.fatCaloriesLabel.Location = new System.Drawing.Point(17, 137);
            this.fatCaloriesLabel.Name = "fatCaloriesLabel";
            this.fatCaloriesLabel.Size = new System.Drawing.Size(111, 16);
            this.fatCaloriesLabel.TabIndex = 4;
            this.fatCaloriesLabel.Text = "Calories from Fat:";
            // 
            // fatCaloriesOutputLabel
            // 
            this.fatCaloriesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatCaloriesOutputLabel.Location = new System.Drawing.Point(138, 137);
            this.fatCaloriesOutputLabel.Name = "fatCaloriesOutputLabel";
            this.fatCaloriesOutputLabel.Size = new System.Drawing.Size(136, 23);
            this.fatCaloriesOutputLabel.TabIndex = 5;
            this.fatCaloriesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateTextButton
            // 
            this.calculateTextButton.Location = new System.Drawing.Point(37, 172);
            this.calculateTextButton.Name = "calculateTextButton";
            this.calculateTextButton.Size = new System.Drawing.Size(91, 23);
            this.calculateTextButton.TabIndex = 6;
            this.calculateTextButton.Text = "Calculate";
            this.calculateTextButton.UseVisualStyleBackColor = true;
            this.calculateTextButton.Click += new System.EventHandler(this.calculateTextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(135, 172);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type in the information below and ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Click calculate to see the amount of fat calories are in the food item.";
            // 
            // FatPercenatgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateTextButton);
            this.Controls.Add(this.fatCaloriesOutputLabel);
            this.Controls.Add(this.fatCaloriesLabel);
            this.Controls.Add(this.fatGramsTextBox);
            this.Controls.Add(this.fatGramsLabel);
            this.Controls.Add(this.totalCaloriesTextBox);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Name = "FatPercenatgeCalculator";
            this.Text = "Fat Percenatge Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.TextBox totalCaloriesTextBox;
        private System.Windows.Forms.Label fatGramsLabel;
        private System.Windows.Forms.TextBox fatGramsTextBox;
        private System.Windows.Forms.Label fatCaloriesLabel;
        private System.Windows.Forms.Label fatCaloriesOutputLabel;
        private System.Windows.Forms.Button calculateTextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

