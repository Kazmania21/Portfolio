namespace CalorieCounter
{
    partial class CalorieCounter
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
            this.pearPictureBox = new System.Windows.Forms.PictureBox();
            this.orangePictureBox = new System.Windows.Forms.PictureBox();
            this.applePictureBox = new System.Windows.Forms.PictureBox();
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.calorieCountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pearPictureBox
            // 
            this.pearPictureBox.Image = global::CalorieCounter.Properties.Resources.PearCalories;
            this.pearPictureBox.Location = new System.Drawing.Point(160, 188);
            this.pearPictureBox.Name = "pearPictureBox";
            this.pearPictureBox.Size = new System.Drawing.Size(128, 155);
            this.pearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pearPictureBox.TabIndex = 3;
            this.pearPictureBox.TabStop = false;
            this.pearPictureBox.Click += new System.EventHandler(this.pearPictureBox_Click);
            // 
            // orangePictureBox
            // 
            this.orangePictureBox.Image = global::CalorieCounter.Properties.Resources.OrangeCalories;
            this.orangePictureBox.Location = new System.Drawing.Point(13, 188);
            this.orangePictureBox.Name = "orangePictureBox";
            this.orangePictureBox.Size = new System.Drawing.Size(128, 155);
            this.orangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangePictureBox.TabIndex = 2;
            this.orangePictureBox.TabStop = false;
            this.orangePictureBox.Click += new System.EventHandler(this.orangePictureBox_Click);
            // 
            // applePictureBox
            // 
            this.applePictureBox.Image = global::CalorieCounter.Properties.Resources.AppleCalories;
            this.applePictureBox.Location = new System.Drawing.Point(160, 13);
            this.applePictureBox.Name = "applePictureBox";
            this.applePictureBox.Size = new System.Drawing.Size(128, 155);
            this.applePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applePictureBox.TabIndex = 1;
            this.applePictureBox.TabStop = false;
            this.applePictureBox.Click += new System.EventHandler(this.applePictureBox_Click);
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.Image = global::CalorieCounter.Properties.Resources.BananaCalories;
            this.bananaPictureBox.Location = new System.Drawing.Point(13, 13);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(128, 155);
            this.bananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bananaPictureBox.TabIndex = 0;
            this.bananaPictureBox.TabStop = false;
            this.bananaPictureBox.Click += new System.EventHandler(this.bananaPictureBox_Click);
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(323, 13);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(91, 16);
            this.totalCaloriesLabel.TabIndex = 4;
            this.totalCaloriesLabel.Text = "Total Calories";
            // 
            // calorieCountLabel
            // 
            this.calorieCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calorieCountLabel.Location = new System.Drawing.Point(326, 33);
            this.calorieCountLabel.Name = "calorieCountLabel";
            this.calorieCountLabel.Size = new System.Drawing.Size(100, 23);
            this.calorieCountLabel.TabIndex = 5;
            this.calorieCountLabel.Text = "0";
            this.calorieCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(326, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(326, 276);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // CalorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 388);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calorieCountLabel);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.pearPictureBox);
            this.Controls.Add(this.orangePictureBox);
            this.Controls.Add(this.applePictureBox);
            this.Controls.Add(this.bananaPictureBox);
            this.Name = "CalorieCounter";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox applePictureBox;
        private System.Windows.Forms.PictureBox orangePictureBox;
        private System.Windows.Forms.PictureBox pearPictureBox;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label calorieCountLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

