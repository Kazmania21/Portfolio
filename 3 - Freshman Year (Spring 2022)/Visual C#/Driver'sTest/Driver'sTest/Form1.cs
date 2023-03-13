using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_sTest
{
    public partial class Form1 : Form
    {
        int currentQuestion = 0;

        Label[] currentQuestionLabel = new Label[5];

        GroupBox[] currentQuestionGroupBox = new GroupBox[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentQuestionLabel[0] = question1Label;
            currentQuestionLabel[1] = question2Label;
            currentQuestionLabel[2] = question3Label;
            currentQuestionLabel[3] = question4Label;
            currentQuestionLabel[4] = question5Label;

            currentQuestionGroupBox[0] = question1GroupBox;
            currentQuestionGroupBox[1] = question2GroupBox;
            currentQuestionGroupBox[2] = question3GroupBox;
            currentQuestionGroupBox[3] = question4GroupBox;
            currentQuestionGroupBox[4] = question5GroupBox;
        }

        private void CurrentQuestion(ref int currentQuestion, int currentQuestionzindexer)
        {
            currentQuestion += currentQuestionzindexer;

            if (currentQuestion == 0)
            {
                PreviousQusetionButton.Visible = false;
            }

            else if (currentQuestion == 4)
            {
                NextQuestionButton.Visible = false;
                finishTestButton.Visible = true;
            }

            else
            {
                PreviousQusetionButton.Visible = true;
                NextQuestionButton.Visible = true;
                finishTestButton.Visible = false;
            }
        }

        private void PreviousQusetionButton_Click(object sender, EventArgs e)
        {
            int currentQuestionIndexer = -1;

            currentQuestionLabel[currentQuestion].Visible = false;

            currentQuestionLabel[currentQuestion - 1].Visible = true;

            currentQuestionGroupBox[currentQuestion].Visible = false;

            currentQuestionGroupBox[currentQuestion - 1].Visible = true;

            CurrentQuestion(ref currentQuestion, currentQuestionIndexer);
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            int currentQuestionIndexer = 1;

            currentQuestionLabel[currentQuestion].Visible = false;

            currentQuestionLabel[currentQuestion + 1].Visible = true;

            currentQuestionGroupBox[currentQuestion].Visible = false;

            currentQuestionGroupBox[currentQuestion + 1].Visible = true;

            CurrentQuestion(ref currentQuestion, currentQuestionIndexer);
        }

        private void AnswerCheck()
        {
            int total = 0;

            bool[][] questionsAndAnswers = new bool[5][];

            bool[][] answerSheet = new bool[5][];

            questionsAndAnswers[0] = new bool[4] { q1A1RadioButton.Checked, q1A2RadioButton.Checked,
                                                   q1A3RadioButton.Checked, q1A4RadioButton.Checked };
            questionsAndAnswers[1] = new bool[4] { q2A1RadioButton.Checked, q2A2RadioButton.Checked,
                                                   q2A3RadioButton.Checked, q2A4RadioButton.Checked };
            questionsAndAnswers[2] = new bool[2] { q3A1RadioButton.Checked, q3A2RadioButton.Checked };
            questionsAndAnswers[3] = new bool[2] { q4A1RadioButton.Checked, q4A2RadioButton.Checked };
            questionsAndAnswers[4] = new bool[4] { q5A1RadioButton.Checked, q5A2RadioButton.Checked,
                                                   q5A3RadioButton.Checked, q5A4RadioButton.Checked};

            answerSheet[0] = new bool[4] { false, true, false, false };
            answerSheet[1] = new bool[4] { false, false, true, false };
            answerSheet[2] = new bool[2] { false, true };
            answerSheet[3] = new bool[2] { true, false };
            answerSheet[4] = new bool[4] { false, false, false, true };

            for (int index = 0; index < 5; index++)
            {
                int index2 = 0;

                foreach (bool answer in questionsAndAnswers[index])
                {
                    if (answer == true)
                    {
                        if (answerSheet[index][index2] == answer)
                        {
                            total++;

                            answerListBox.Items.Add($"Your answer for question {index + 1} was correct!");
                        }

                        else
                        {
                            answerListBox.Items.Add($"Your answer for question {index + 1} was incorrect.");
                        }
                    }

                    index2++;
                }
            }

            correctAnswerOutputLabel.Text = $"{total}/5";

            if (total > 3)
            {
                passedOutputLabel.Text = "Pass!";
            }

            else
            {
                passedOutputLabel.Text = "You failed. Better Luck next time!";
            }
        }

        private void finishTestButton_Click(object sender, EventArgs e)
        {
            AnswerCheck();

            question5Label.Visible = false;

            question5GroupBox.Visible = false;

            correctAnswerLabel.Visible = true;

            correctAnswerOutputLabel.Visible = true;

            passedLabel.Visible = true;

            passedOutputLabel.Visible = true;

            answerListBox.Visible = true;

            PreviousQusetionButton.Visible = false;

            finishTestButton.Visible = false;

            ExitButton.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
