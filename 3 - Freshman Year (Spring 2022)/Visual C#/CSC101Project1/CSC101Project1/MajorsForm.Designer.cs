namespace CSC101Project1
{
    partial class Form2
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
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.courseRequirementsListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // majorComboBox
            // 
            this.majorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "Business",
            "Computer Engineering",
            "Computer Science",
            "Cybersecurity"});
            this.majorComboBox.Location = new System.Drawing.Point(276, 11);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(207, 24);
            this.majorComboBox.TabIndex = 0;
            this.majorComboBox.SelectedIndexChanged += new System.EventHandler(this.majorComboBox_SelectedIndexChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(27, 19);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(233, 16);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "These are the course requirements for";
            // 
            // courseRequirementsListBox
            // 
            this.courseRequirementsListBox.FormattingEnabled = true;
            this.courseRequirementsListBox.ItemHeight = 16;
            this.courseRequirementsListBox.Location = new System.Drawing.Point(30, 58);
            this.courseRequirementsListBox.Name = "courseRequirementsListBox";
            this.courseRequirementsListBox.Size = new System.Drawing.Size(453, 228);
            this.courseRequirementsListBox.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(206, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 347);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.courseRequirementsListBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.majorComboBox);
            this.Name = "Form2";
            this.Text = "Major";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ListBox courseRequirementsListBox;
        private System.Windows.Forms.Button exitButton;
    }
}