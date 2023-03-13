using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    public partial class wallSpaceLabel : Form
    {
        public wallSpaceLabel()
        {
            InitializeComponent();
        }

        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            decimal wallSpaceNeededCovered = decimal.Parse(wallSpaceTextBox.Text);

            decimal gallonsNeeded = wallSpaceNeededCovered / 115;
            decimal paintCostPerGallon = decimal.Parse(costForPaintTextBox.Text);
            decimal paintCost = gallonsNeeded* paintCostPerGallon;
            gallonsLabel.Text = $"Gallons of paint needed: {gallonsNeeded} x ${paintCostPerGallon} = {paintCost}";

            decimal laborCosts = gallonsNeeded * 160;
            hoursLabel.Text = $"Hours of Labor need: {gallonsNeeded * 8} x $20 = {laborCosts}";

            totalPriceLabel.Text = $"Total cost: {paintCost + laborCosts}";
        }
    }
}
