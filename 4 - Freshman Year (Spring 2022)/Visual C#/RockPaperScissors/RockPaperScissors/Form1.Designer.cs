namespace RockPaperScissors
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.youLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.comLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::RockPaperScissors.Properties.Resources.Scissors;
            this.pictureBox3.Location = new System.Drawing.Point(223, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.pictureBox2.Location = new System.Drawing.Point(120, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rockPictureBox.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.rockPictureBox.Location = new System.Drawing.Point(16, 68);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(68, 68);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rockPictureBox.TabIndex = 0;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(120, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(239, 32);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Click one of the pictures to select either \r\nrock, paper, or scissors.";
            // 
            // youLabel
            // 
            this.youLabel.AutoSize = true;
            this.youLabel.Location = new System.Drawing.Point(54, 158);
            this.youLabel.Name = "youLabel";
            this.youLabel.Size = new System.Drawing.Size(39, 16);
            this.youLabel.TabIndex = 5;
            this.youLabel.Text = "YOU:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.Location = new System.Drawing.Point(51, 174);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(42, 46);
            this.playerScoreLabel.TabIndex = 6;
            this.playerScoreLabel.Text = "0";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(146, 170);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(25, 16);
            this.vsLabel.TabIndex = 7;
            this.vsLabel.Text = "VS";
            // 
            // comLabel
            // 
            this.comLabel.AutoSize = true;
            this.comLabel.Location = new System.Drawing.Point(241, 158);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(37, 16);
            this.comLabel.TabIndex = 8;
            this.comLabel.Text = "COM";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLabel.Location = new System.Drawing.Point(236, 174);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(42, 46);
            this.computerScoreLabel.TabIndex = 9;
            this.computerScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 309);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.comLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.youLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rockPictureBox);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label youLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label comLabel;
        private System.Windows.Forms.Label computerScoreLabel;
    }
}

