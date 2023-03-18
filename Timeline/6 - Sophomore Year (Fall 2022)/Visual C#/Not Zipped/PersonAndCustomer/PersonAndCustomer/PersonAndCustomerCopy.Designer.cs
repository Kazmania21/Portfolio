namespace PersonAndCustomer
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.TabPage();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.Customer.SuspendLayout();
            this.Employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Customer);
            this.tabControl.Controls.Add(this.Employee);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(771, 438);
            this.tabControl.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.exitButton);
            this.Customer.Controls.Add(this.customerListBox);
            this.Customer.Location = new System.Drawing.Point(4, 27);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(763, 407);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(283, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.exitButton2);
            this.Employee.Controls.Add(this.employeeListBox);
            this.Employee.Location = new System.Drawing.Point(4, 27);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(763, 407);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // exitButton2
            // 
            this.exitButton2.Location = new System.Drawing.Point(283, 276);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(89, 46);
            this.exitButton2.TabIndex = 5;
            this.exitButton2.Text = "Exit";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 18;
            this.employeeListBox.Items.AddRange(new object[] {
            "Name, Address, Phone Number, Employee ID, Start Date",
            ""});
            this.employeeListBox.Location = new System.Drawing.Point(45, 30);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(576, 202);
            this.employeeListBox.TabIndex = 4;
            // 
            // customerListBox
            // 
            this.customerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 20;
            this.customerListBox.Items.AddRange(new object[] {
            "Name, Address, Phone Number, Customer Number, Mail List",
            ""});
            this.customerListBox.Location = new System.Drawing.Point(45, 30);
            this.customerListBox.MultiColumn = true;
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(576, 204);
            this.customerListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 416);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Person and Customer";
            this.tabControl.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.ListBox customerListBox;
    }
}

