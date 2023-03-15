using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method increments the player's score by one when called
        private void UpdatePlayerScore(int score)
        {
            score++;

            //Displays the new score
            playerScoreLabel.Text = score.ToString();
        }

        //Method increments computer's score by one when called
        private void UpdateComputerScore(int score)
        {
            score++;

            //Displays the new score
            computerScoreLabel.Text = score.ToString();
        }
        
        //Method that is called when there is a winner and explains what happend
        private void NotATieOutcomeExplanation(ref string outcome, int choiceOfWinner, string winner, 
            string winner2, string loser, string face)
        {
            switch (choiceOfWinner)
            {
                //Case if the winner chose rock
                case 1:
                    outcome = $"{winner} rock smashes the {loser} scissors. \n{winner2} wins {face}";
                    break;

                //Case if the winner chose paper
                case 2:
                    outcome = $"{winner} paper wraps {loser} rock. \n{winner2} wins {face}";
                    break;

                //Case if the winner chose scissors
                default:
                    outcome = $"{winner} scissors cuts {loser} paper. \n{winner2} wins {face}";
                    break;
            }
        }

        //Method determines the outcome of the Rock Paper Scissors match
        private string ChoiceComparison(int playerChoice, int computerGeneratedChoice)
        {
            //A string that holds the outcome of the game
            string outcome = "";
            
            //If the game ends in a tie
            if (playerChoice == computerGeneratedChoice)
            {
                outcome = "Tie. Play Again.";
            }

            //If the player wins the game
            else if (playerChoice - computerGeneratedChoice == 1 || 
                playerChoice - computerGeneratedChoice == -2)
            {
                //Edits the string outcome variable
                NotATieOutcomeExplanation(ref outcome, playerChoice, "Your", 
                    "The player", "the computer's", ":)");
                //Updates the player's score
                UpdatePlayerScore(int.Parse(playerScoreLabel.Text));
            }

            //If the computer wins the game
            else
            {
                //Edits the string outcome variable
                NotATieOutcomeExplanation(ref outcome, computerGeneratedChoice, "The computer's", 
                    "The computer", "your", ":(");
                //Update's the computer's score
                UpdateComputerScore(int.Parse(computerScoreLabel.Text));
            }

            return outcome;
        }

        /*Method randomly generates computer's choice and returns it when called.
          This is not done at the beginning as the problem asks to ensure that the 
          computer makes a different choice each time. If it were to be put at the
          the beginning, the computer would pick the same choice every time*/
        private int ComputerGeneratedChoice()
        {
            Random rand = new Random();

            int computersChoice = rand.Next(3) + 1;

            return computersChoice;
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            /*Passes the player and computer choice to the choiceComparison
            method and shows the outcome of the game*/
            MessageBox.Show(ChoiceComparison(1, ComputerGeneratedChoice()));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*Passes the player and computer choice to the choiceComparison
            method and shows the outcome of the game*/
            MessageBox.Show(ChoiceComparison(2, ComputerGeneratedChoice()));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*Passes the player and computer choice to the choiceComparison
            method and shows the outcome of the game*/
            MessageBox.Show(ChoiceComparison(3, ComputerGeneratedChoice()));
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
