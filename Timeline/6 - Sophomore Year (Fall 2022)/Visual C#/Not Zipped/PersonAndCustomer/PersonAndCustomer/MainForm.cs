using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonAndCustomer
{
    public partial class MainForm : Form
    {
        private List<Customer> customers = new List<Customer>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.name = nameTextBox.Text;
            customer.address = addressTextBox.Text;
            customer.number = numberTextBox.Text;
            customer.custNum = custNumTextBox.Text;
            customer.mailList = mailListCheckBox.Checked;


        }
    }
}
