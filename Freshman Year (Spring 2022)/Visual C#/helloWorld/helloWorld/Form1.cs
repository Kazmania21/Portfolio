using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class myFirstProgram : Form
    {
        public myFirstProgram()
        {
            InitializeComponent();
        }

        private void myFirstProgram_Load(object sender, EventArgs e)
        {

        }

        private void displayMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
