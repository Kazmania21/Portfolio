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
            this.mailListCheckBox = new System.Windows.Forms.CheckBox();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.Employee = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Customer);
            this.tabControl.Controls.Add(this.Employee);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(771, 438);
            this.tabControl.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.mailListCheckBox);
            this.Customer.Controls.Add(this.custNumTextBox);
            this.Customer.Controls.Add(this.custNumLabel);
            this.Customer.Controls.Add(this.numberTextBox);
            this.Customer.Controls.Add(this.numberLabel);
            this.Customer.Controls.Add(this.addressTextBox);
            this.Customer.Controls.Add(this.addressLabel);
            this.Customer.Controls.Add(this.nameTextBox);
            this.Customer.Controls.Add(this.nameLabel);
            this.Customer.Controls.Add(this.exitButton);
            this.Customer.Controls.Add(this.removeCustomerButton);
            this.Customer.Controls.Add(this.addCustomerButton);
            this.Customer.Controls.Add(this.customerListBox);
            this.Customer.Location = new System.Drawing.Point(4, 25);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(763, 409);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // mailListCheckBox
            // 
            this.mailListCheckBox.AutoSize = true;
            this.mailListCheckBox.Location = new System.Drawing.Point(402, 151);
            this.mailListCheckBox.Name = "mailListCheckBox";
            this.mailListCheckBox.Size = new System.Drawing.Size(77, 20);
            this.mailListCheckBox.TabIndex = 13;
            this.mailListCheckBox.Text = "Mail List";
            this.mailListCheckBox.UseVisualStyleBackColor = true;
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Location = new System.Drawing.Point(452, 111);
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.custNumTextBox.TabIndex = 11;
            // 
            // custNumLabel
            // 
            this.custNumLabel.AutoSize = true;
            this.custNumLabel.Location = new System.Drawing.Point(328, 114);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(118, 16);
            this.custNumLabel.TabIndex = 10;
            this.custNumLabel.Text = "Customer Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(452, 83);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 9;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(346, 86);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(100, 16);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Phone Number:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(452, 55);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 7;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(385, 58);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(61, 16);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(452, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(399, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(225, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Location = new System.Drawing.Point(135, 276);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(84, 46);
            this.removeCustomerButton.TabIndex = 2;
            this.removeCustomerButton.Text = "Remove Customer";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(45, 276);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(84, 46);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 16;
            this.customerListBox.Location = new System.Drawing.Point(45, 30);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(269, 212);
            this.customerListBox.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(4, 25);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(763, 409);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.TextBox custNumTextBox;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox mailListCheckBox;
    }
}

