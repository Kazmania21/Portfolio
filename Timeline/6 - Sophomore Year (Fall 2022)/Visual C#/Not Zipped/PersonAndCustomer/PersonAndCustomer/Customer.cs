using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomer
{
    internal class Customer : Person
    {
        public string custNum;
        public bool mailList;

        public Customer(string n, string a, string num, string cN, bool mL)
        {
            name = n;
            address = a;
            number = num;
            custNum = cN;
            mailList = mL;
        }
    }
}
