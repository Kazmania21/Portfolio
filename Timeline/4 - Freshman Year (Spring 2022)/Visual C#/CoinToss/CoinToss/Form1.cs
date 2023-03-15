using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int sideUp = rand.Next(2);

            if (sideUp == 0)
            {
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }

            else {
                tailsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
