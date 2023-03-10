using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();

                int randomNumber = rand.Next(100) + 1;

                int guess = int.Parse(guessTextBox.Text);

                int guessAttempt = 0;

                if (guess > randomNumber)
                {
                    MessageBox.Show("The number is too high, guess again.");
                }

                else if (guess < randomNumber)
                {
                    MessageBox.Show("The number is too low, guess again.");
                }

                else
                {
                    MessageBox.Show("You have guessed the correct number!");
                    attemptsLabel.Text = $"Number of Guesses: {guessAttempt}";
                }

                guessAttempt++;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            
        }
    }
}
