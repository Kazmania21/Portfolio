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
        List<Customer> customers = new List<Customer>() 
        {
            new Customer("Billy Bob", "1234 Fish View Dr.", "(724) - 555 - 6789", "1232", true),
            new Customer("Sally Schneider", "654 Firefox Rd.", "(724) - 654 - 3210", "1233", true),
            new Customer("Fred Falk", "7890 Beaver Kit St.", "(724) - 987 - 1234", "1234", false)
        };

        List<Employee> employees = new List<Employee>()
        {
            new Employee("Jimmy James", "2109 Black Hawk Blvd.", "(724) - 123 - 4567", 7890, new DateTime(2020, 1, 15)),
            new Employee("Kim Kennedy", "456 Croaking Frog Ln.", "(724) - 234 - 8901", 7891, new DateTime(2021, 9, 30)),
            new Employee("Damon Davis", "4321 Horseferry Ave.", "(724) - 901 - 2345", 7892, new DateTime(2022, 3, 14))
        };

        public MainForm()
        {
            InitializeComponent();

            AddCustomerstoList();
            AddEmployeestoList();
        }

        public void AddCustomerstoList()
        {
            foreach (Customer customer in customers)
            {
                customerListBox.Items.Add($"{customer.name}, {customer.address}, {customer.number}, {customer.custNum}, {customer.mailList}");
            }
        }

        public void AddEmployeestoList()
        {
            foreach (Employee employee in employees)
            {
                employeeListBox.Items.Add($"{employee.name}, {employee.address}, {employee.number}, {employee.employeeID}, {employee.StartDate.Month}-{employee.StartDate.Day}-{employee.StartDate.Year}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
