using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomer
{
    internal class Employee : Person
    {
        public int employeeID;
        public DateTime StartDate;

        public Employee(string n, string a, string num, int id, DateTime sd)
        {
            name = n;
            address = a;
            number = num;
            employeeID = id;
            StartDate = sd;
        }
    }
}
