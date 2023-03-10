using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void toFahrenheitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Converts temperature to Fahrenheit
                //I formatted the string instead of using the ToString method due to preference
                convertedTemperatureLabel.Text = $"{double.Parse(temperatureTextBox.Text) * 9/5 + 32}";
            }

            catch
            {
                //If a user enters a character other than a number or nothing at all than this
                //message is displayed
                MessageBox.Show("Please enter a number. No other characters are allowed.");
            }
        }

        private void toCelsiusButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Converts temperature to Celcius
                convertedTemperatureLabel.Text = $"{(double.Parse(temperatureTextBox.Text) - 32) * 5/9}";
            }

            catch
            {
                //If a user enters a character other than a number  or nothing at all
                //than this message is displayed
                MessageBox.Show("Please enter a number. No other characters are allowed.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
    }
}
