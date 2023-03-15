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

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputFile = File.OpenText(openFile.FileName);

                    randomNumberListBox.Items.Clear();

                    int loopNumber = 0;

                    int total = 0;

                    while (!inputFile.EndOfStream)
                    {
                        int randomNumber = int.Parse(inputFile.ReadLine());

                        randomNumberListBox.Items.Add(randomNumber);

                        total += randomNumber;

                        loopNumber++;
                    }

                    totalLabel.Text = $"Total: {total}";

                    amountLabel.Text = $"AmountOfRandomNumbers: {loopNumber}";

                    inputFile.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else {
                MessageBox.Show("Operation cancelled");
            }
        }
    }
}
