using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTheme
{
    public partial class ColorTheme : Form
    {
        public ColorTheme()
        {
            InitializeComponent();
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
