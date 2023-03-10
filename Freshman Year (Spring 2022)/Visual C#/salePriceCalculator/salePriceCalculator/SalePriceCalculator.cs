using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salePriceCalculator
{
    public partial class SalePriceCalculator : Form
    {
        public SalePriceCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            salePriceLabel.Text = $"{(decimal.Parse(originalPriceTextBox.Text) - (decimal.Parse(originalPriceTextBox.Text) * decimal.Parse(discountPercentageTextBox.Text) / 100)).ToString("C")}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
