using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Driver_sLiscenceExam
{
    public partial class Form1 : Form
    {
        int correctAnswers = 0;

        int incorrectAnswers = 0;

        string[] answerSheet = { "1. B", "2. D", "3. A", "4. A", "5. C", "6. A", "7. B", "8. A", "9. C", 
            "10. D", "11. B", "12. C", "13. D", "14. A", "15. D", "16. C", "17. C", "18. B", "19. D", 
            "20. A" };

        string[] studentAnswers = new string[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void AnswerFilter(ref int correctAnswers, string[] studentAnswers)
        {
            for (int index = 0; index < studentAnswers.Length; index++)
            {
                if (studentAnswers[index] == answerSheet[index])
                {
                    correctAnswers++;

                    correctAnswersOutputLabel.Text = $"{correctAnswers}";
                }

                else
                {
                    incorrectAnswers++;

                    incorrectAnswersOutputLabel.Text = $"{incorrectAnswers}";

                    incorrectAnswersListBox.Items.Add(studentAnswers[index]);
                }

                PassOrFail();
            }
        }

        private void PassOrFail()
        {
            if (correctAnswers >= 15)
            {
                resultOutputLabel.Text = "Pass";
            }

            else
            {
                resultOutputLabel.Text = "Fail";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputFile = new StreamReader(openFile.FileName);

                while (!inputFile.EndOfStream)
                {
                    studentAnswers[index] = inputFile.ReadLine();

                    index++;
                }

                inputFile.Close();

                AnswerFilter(ref correctAnswers, studentAnswers);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            incorrectAnswersListBox.Items.Clear();

            correctAnswersOutputLabel.Text = "";

            incorrectAnswersOutputLabel.Text = "";

            resultOutputLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
