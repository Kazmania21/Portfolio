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
            saveFile.ShowDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputFile = File.AppendText(saveFile.FileName);

                int randomNumberAmount = int.Parse(randomTextBox.Text);

                int loopNumber = 0;

                while (loopNumber < randomNumberAmount)
                {
                    Random rand = new Random();

                    outputFile.WriteLine(rand.Next(100) + 1);

                    loopNumber++;
                }

                outputFile.Close();
            }

            else {
                MessageBox.Show("Operation cancelled");
            }
        }
    }
}
