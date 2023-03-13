namespace helloWorld
{
    partial class myFirstProgram
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
            this.displayMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayMessage
            // 
            this.displayMessage.Location = new System.Drawing.Point(358, 388);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(81, 50);
            this.displayMessage.TabIndex = 0;
            this.displayMessage.Text = "Display Message";
            this.displayMessage.UseVisualStyleBackColor = true;
            this.displayMessage.Click += new System.EventHandler(this.displayMessage_Click);
            // 
            // myFirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayMessage);
            this.Name = "myFirstProgram";
            this.Text = "myFirstProgram";
            this.Load += new System.EventHandler(this.myFirstProgram_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayMessage;
    }
}

