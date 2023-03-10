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

namespace CSC101Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void majorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets the name of the selcted major and puts it in a variable called majorSelected
            string majorSelected = majorComboBox.SelectedItem.ToString();

            /*try-catch will show an error message with the catch section if an error occurs in
            opening a file in the try section*/
            try
            {
                //opens a text file file with the name of the selected major and puts it into inputFile
                StreamReader inputFile = new StreamReader($"{majorSelected}.txt");

                //clears all items in the list box in case it already has items
                courseRequirementsListBox.Items.Clear();

                /* while loop adds each line from the text file into as an item in the list box
                and ends the loop after every line has been read */
                while (!inputFile.EndOfStream)
                {
                    courseRequirementsListBox.Items.Add(inputFile.ReadLine());
                }

                //closes the file after it has been used and it is no longer needed
                inputFile.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }
    }
}
