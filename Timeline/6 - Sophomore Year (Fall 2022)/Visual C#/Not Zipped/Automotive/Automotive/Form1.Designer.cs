namespace Automotive
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsAndLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeesResult = new System.Windows.Forms.Label();
            this.taxResult = new System.Windows.Forms.Label();
            this.partsResult = new System.Windows.Forms.Label();
            this.serviceAndLaborResult = new System.Windows.Forms.Label();
            this.totalFees = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsAndLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(7, 49);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(134, 20);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(7, 22);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(144, 20);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(236, 12);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(209, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 48);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(194, 20);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(7, 22);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(165, 20);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 118);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(7, 74);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(155, 20);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(7, 49);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(179, 20);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($200.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(7, 22);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(139, 20);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsAndLaborGroupBox
            // 
            this.partsAndLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsAndLaborGroupBox.Location = new System.Drawing.Point(236, 118);
            this.partsAndLaborGroupBox.Name = "partsAndLaborGroupBox";
            this.partsAndLaborGroupBox.Size = new System.Drawing.Size(209, 100);
            this.partsAndLaborGroupBox.TabIndex = 3;
            this.partsAndLaborGroupBox.TabStop = false;
            this.partsAndLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(72, 46);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 22);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(72, 18);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 22);
            this.partsTextBox.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(5, 49);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(60, 16);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor ($)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(27, 18);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(38, 16);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalFeesResult);
            this.summaryGroupBox.Controls.Add(this.taxResult);
            this.summaryGroupBox.Controls.Add(this.partsResult);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborResult);
            this.summaryGroupBox.Controls.Add(this.totalFees);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 224);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(424, 133);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalFeesResult
            // 
            this.totalFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesResult.Location = new System.Drawing.Point(131, 91);
            this.totalFeesResult.Name = "totalFeesResult";
            this.totalFeesResult.Size = new System.Drawing.Size(100, 23);
            this.totalFeesResult.TabIndex = 7;
            // 
            // taxResult
            // 
            this.taxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxResult.Location = new System.Drawing.Point(131, 68);
            this.taxResult.Name = "taxResult";
            this.taxResult.Size = new System.Drawing.Size(100, 23);
            this.taxResult.TabIndex = 6;
            // 
            // partsResult
            // 
            this.partsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsResult.Location = new System.Drawing.Point(131, 45);
            this.partsResult.Name = "partsResult";
            this.partsResult.Size = new System.Drawing.Size(100, 23);
            this.partsResult.TabIndex = 5;
            // 
            // serviceAndLaborResult
            // 
            this.serviceAndLaborResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndLaborResult.Location = new System.Drawing.Point(131, 22);
            this.serviceAndLaborResult.Name = "serviceAndLaborResult";
            this.serviceAndLaborResult.Size = new System.Drawing.Size(100, 23);
            this.serviceAndLaborResult.TabIndex = 4;
            // 
            // totalFees
            // 
            this.totalFees.AutoSize = true;
            this.totalFees.Location = new System.Drawing.Point(53, 91);
            this.totalFees.Name = "totalFees";
            this.totalFees.Size = new System.Drawing.Size(72, 16);
            this.totalFees.TabIndex = 3;
            this.totalFees.Text = "Total Fees";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(36, 68);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(89, 16);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax (on parts)";
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(86, 45);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(38, 16);
            this.partsSummaryLabel.TabIndex = 1;
            this.partsSummaryLabel.Text = "Parts";
            // 
            // serviceAndLaborLabel
            // 
            this.serviceAndLaborLabel.AutoSize = true;
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(7, 22);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(117, 16);
            this.serviceAndLaborLabel.TabIndex = 0;
            this.serviceAndLaborLabel.Text = "Service and Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(87, 376);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(191, 376);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(283, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsAndLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsAndLaborGroupBox.ResumeLayout(false);
            this.partsAndLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsAndLaborGroupBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label totalFeesResult;
        private System.Windows.Forms.Label taxResult;
        private System.Windows.Forms.Label partsResult;
        private System.Windows.Forms.Label serviceAndLaborResult;
        private System.Windows.Forms.Label totalFees;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

