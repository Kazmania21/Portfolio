using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timezone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (cityListBox.SelectedIndex != -1)
            {
                switch (cityListBox.SelectedIndex)
                {
                    case 0:
                        timeZoneLabel.Text = "Mountain";
                        break;

                    case 1:
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;

                    case 2:
                        timeZoneLabel.Text = "Central";
                        break;

                    case 3:
                        timeZoneLabel.Text = "Eastern";
                        break;

                    default:
                        timeZoneLabel.Text = "Pacific";
                        break;
                }
            }
        }

        private void exitBuitton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
