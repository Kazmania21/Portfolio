namespace CourseInformation
{
    partial class CourseInformationForm
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
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.couseNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberOutputLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.meetingTimeOutputLabel = new System.Windows.Forms.Label();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.CourseInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.courseNumberComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.instructorOutputLabel = new System.Windows.Forms.Label();
            this.CourseInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(6, 31);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(98, 16);
            this.roomNumberLabel.TabIndex = 1;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // couseNumberLabel
            // 
            this.couseNumberLabel.AutoSize = true;
            this.couseNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.couseNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.couseNumberLabel.Name = "couseNumberLabel";
            this.couseNumberLabel.Size = new System.Drawing.Size(145, 16);
            this.couseNumberLabel.TabIndex = 2;
            this.couseNumberLabel.Text = "Select Course Number:";
            // 
            // roomNumberOutputLabel
            // 
            this.roomNumberOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomNumberOutputLabel.Location = new System.Drawing.Point(110, 30);
            this.roomNumberOutputLabel.Name = "roomNumberOutputLabel";
            this.roomNumberOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.roomNumberOutputLabel.TabIndex = 3;
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(41, 64);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(63, 16);
            this.instructorLabel.TabIndex = 4;
            this.instructorLabel.Text = "Instructor:";
            // 
            // meetingTimeOutputLabel
            // 
            this.meetingTimeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meetingTimeOutputLabel.Location = new System.Drawing.Point(110, 97);
            this.meetingTimeOutputLabel.Name = "meetingTimeOutputLabel";
            this.meetingTimeOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.meetingTimeOutputLabel.TabIndex = 7;
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.AutoSize = true;
            this.meetingTimeLabel.Location = new System.Drawing.Point(12, 98);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(92, 16);
            this.meetingTimeLabel.TabIndex = 6;
            this.meetingTimeLabel.Text = "Meeting Time:";
            // 
            // CourseInformationGroupBox
            // 
            this.CourseInformationGroupBox.Controls.Add(this.instructorOutputLabel);
            this.CourseInformationGroupBox.Controls.Add(this.roomNumberLabel);
            this.CourseInformationGroupBox.Controls.Add(this.meetingTimeOutputLabel);
            this.CourseInformationGroupBox.Controls.Add(this.roomNumberOutputLabel);
            this.CourseInformationGroupBox.Controls.Add(this.meetingTimeLabel);
            this.CourseInformationGroupBox.Controls.Add(this.instructorLabel);
            this.CourseInformationGroupBox.Location = new System.Drawing.Point(15, 39);
            this.CourseInformationGroupBox.Name = "CourseInformationGroupBox";
            this.CourseInformationGroupBox.Size = new System.Drawing.Size(269, 156);
            this.CourseInformationGroupBox.TabIndex = 8;
            this.CourseInformationGroupBox.TabStop = false;
            this.CourseInformationGroupBox.Text = "Course Information";
            // 
            // courseNumberComboBox
            // 
            this.courseNumberComboBox.FormattingEnabled = true;
            this.courseNumberComboBox.Location = new System.Drawing.Point(163, 6);
            this.courseNumberComboBox.Name = "courseNumberComboBox";
            this.courseNumberComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseNumberComboBox.TabIndex = 8;
            this.courseNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.courseNumberComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(163, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(82, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // instructorOutputLabel
            // 
            this.instructorOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructorOutputLabel.Location = new System.Drawing.Point(110, 64);
            this.instructorOutputLabel.Name = "instructorOutputLabel";
            this.instructorOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.instructorOutputLabel.TabIndex = 8;
            // 
            // CourseInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 232);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.courseNumberComboBox);
            this.Controls.Add(this.CourseInformationGroupBox);
            this.Controls.Add(this.couseNumberLabel);
            this.Name = "CourseInformationForm";
            this.Text = "Course Information";
            this.CourseInformationGroupBox.ResumeLayout(false);
            this.CourseInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label couseNumberLabel;
        private System.Windows.Forms.Label roomNumberOutputLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label meetingTimeOutputLabel;
        private System.Windows.Forms.Label meetingTimeLabel;
        private System.Windows.Forms.GroupBox CourseInformationGroupBox;
        private System.Windows.Forms.ComboBox courseNumberComboBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label instructorOutputLabel;
    }
}

