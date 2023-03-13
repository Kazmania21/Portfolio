namespace translator2
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
            this.english = new System.Windows.Forms.Button();
            this.spanish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // english
            // 
            this.english.Location = new System.Drawing.Point(67, 384);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(75, 23);
            this.english.TabIndex = 0;
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = true;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // spanish
            // 
            this.spanish.Location = new System.Drawing.Point(653, 384);
            this.spanish.Name = "spanish";
            this.spanish.Size = new System.Drawing.Size(75, 23);
            this.spanish.TabIndex = 1;
            this.spanish.Text = "Spanish";
            this.spanish.UseVisualStyleBackColor = true;
            this.spanish.Click += new System.EventHandler(this.spanish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spanish);
            this.Controls.Add(this.english);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button english;
        private System.Windows.Forms.Button spanish;
        private System.Windows.Forms.Label label1;
    }
}

