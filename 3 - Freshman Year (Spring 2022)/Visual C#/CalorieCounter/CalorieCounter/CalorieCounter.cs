using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class CalorieCounter : Form
    {

        public CalorieCounter()
        {
            InitializeComponent();
        }

        private void bananaPictureBox_Click(object sender, EventArgs e)
        {
            //Adds the calories of the banana to the calorie count
            calorieCountLabel.Text = $"{int.Parse(calorieCountLabel.Text) + 115}";
        }

        private void applePictureBox_Click(object sender, EventArgs e)
        {
            //Adds the calories of the apple to the calorie count
            calorieCountLabel.Text = $"{int.Parse(calorieCountLabel.Text) + 80}";
        }

        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            //Adds the calories of the orange to the calorie count
            calorieCountLabel.Text = $"{int.Parse(calorieCountLabel.Text) + 90}";
        }

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            //Adds the calories of the pear to the calorie count
            calorieCountLabel.Text = $"{int.Parse(calorieCountLabel.Text) + 120}";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resets the calorie count back to zero
            calorieCountLabel.Text = $"{0}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
    }
}
