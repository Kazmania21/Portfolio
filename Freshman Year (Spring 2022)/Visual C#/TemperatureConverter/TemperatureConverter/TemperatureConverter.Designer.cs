namespace TemperatureConverter
{
    partial class TemperatureConverter
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
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.toFahrenheitButton = new System.Windows.Forms.Button();
            this.toCelsiusButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.closeButton = new System.Windows.Forms.Button();
            this.convertedTemperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(67, 9);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(137, 16);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Enter the temperature:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(241, 9);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 22);
            this.temperatureTextBox.TabIndex = 0;
            // 
            // toFahrenheitButton
            // 
            this.toFahrenheitButton.Location = new System.Drawing.Point(12, 53);
            this.toFahrenheitButton.Name = "toFahrenheitButton";
            this.toFahrenheitButton.Size = new System.Drawing.Size(107, 44);
            this.toFahrenheitButton.TabIndex = 2;
            this.toFahrenheitButton.Text = "Convert to Fahrenheit";
            this.toFahrenheitButton.UseVisualStyleBackColor = true;
            this.toFahrenheitButton.Click += new System.EventHandler(this.toFahrenheitButton_Click);
            // 
            // toCelsiusButton
            // 
            this.toCelsiusButton.Location = new System.Drawing.Point(162, 52);
            this.toCelsiusButton.Name = "toCelsiusButton";
            this.toCelsiusButton.Size = new System.Drawing.Size(100, 45);
            this.toCelsiusButton.TabIndex = 3;
            this.toCelsiusButton.Text = "Convert to Celcius";
            this.toCelsiusButton.UseVisualStyleBackColor = true;
            this.toCelsiusButton.Click += new System.EventHandler(this.toCelsiusButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(309, 53);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // convertedTemperatureLabel
            // 
            this.convertedTemperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedTemperatureLabel.Location = new System.Drawing.Point(162, 129);
            this.convertedTemperatureLabel.Name = "convertedTemperatureLabel";
            this.convertedTemperatureLabel.Size = new System.Drawing.Size(100, 23);
            this.convertedTemperatureLabel.TabIndex = 6;
            this.convertedTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 184);
            this.Controls.Add(this.convertedTemperatureLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toCelsiusButton);
            this.Controls.Add(this.toFahrenheitButton);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Button toFahrenheitButton;
        private System.Windows.Forms.Button toCelsiusButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label convertedTemperatureLabel;
    }
}

