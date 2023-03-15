using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatPercentageCalculator
{
    public partial class FatPercenatgeCalculator : Form
    {
        public FatPercenatgeCalculator()
        {
            InitializeComponent();
        }

        private void calculateTextButton_Click(object sender, EventArgs e)
        {
            if (double.Parse(fatGramsTextBox.Text) >= 0 && double.Parse(totalCaloriesTextBox.Text) >= 0)
            {
                //calculates the amount of fat calories in the food item and stores it in a variable
                double caloriesOfFat = double.Parse(fatGramsTextBox.Text) / 9;

                //calculates the ratio of fat calories to total calories and stores it in a variable
                //this will be converted to a percentage
                double percantageOfFat = caloriesOfFat / double.Parse(totalCaloriesTextBox.Text);

                //shows the user the amount and percentage of fat calories in the food item
                fatCaloriesOutputLabel.Text = $"{caloriesOfFat.ToString("n")} " +
                    $"({percantageOfFat.ToString("p")})";
            }

            else
            {
                //displays a message if the user entered a number less than zero
                MessageBox.Show("You must enter values of 0 or greater.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
