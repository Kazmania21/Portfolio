namespace JokeAndPunchLine
{
    partial class jokeAndPunchLine
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
            this.setupButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.setupLabel = new System.Windows.Forms.Label();
            this.punchLineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(47, 83);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 44);
            this.setupButton.TabIndex = 0;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(191, 82);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(75, 45);
            this.punchLineButton.TabIndex = 1;
            this.punchLineButton.Text = "Punch Line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // setupLabel
            // 
            this.setupLabel.AutoSize = true;
            this.setupLabel.Location = new System.Drawing.Point(44, 35);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(236, 16);
            this.setupLabel.TabIndex = 2;
            this.setupLabel.Text = "A guy walks into a bar. What happens?";
            this.setupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setupLabel.Visible = false;
            // 
            // punchLineLabel
            // 
            this.punchLineLabel.AutoSize = true;
            this.punchLineLabel.Location = new System.Drawing.Point(124, 51);
            this.punchLineLabel.Name = "punchLineLabel";
            this.punchLineLabel.Size = new System.Drawing.Size(75, 16);
            this.punchLineLabel.TabIndex = 3;
            this.punchLineLabel.Text = "He fell over";
            this.punchLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.punchLineLabel.Visible = false;
            // 
            // jokeAndPunchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 151);
            this.Controls.Add(this.punchLineLabel);
            this.Controls.Add(this.setupLabel);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.setupButton);
            this.Name = "jokeAndPunchLine";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchLineButton;
        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.Label punchLineLabel;
    }
}

