using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC101Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            /*try-catch will show an error message with the catch section if an error occurs in
            opening a file in the try section*/
            try
            {
                //puts the next window into an variable called majorSelctionPage
                Form2 majorSelectionPage = new Form2();

                //opens majorSelectionPage(the next window)
                majorSelectionPage.ShowDialog();
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
