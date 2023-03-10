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

namespace TotalSales
{
    public partial class Form1 : Form
    {
        //creates a boolean called calculate that will be set to true until an error occurs
        bool calculate = true;

        /*creates a boolean called firstIteration that determines whether the current
        iteration of the sales array is the first*/
        bool firstIteration = true;

        //creates a decimal called largestValue and sets it equal to 0
        decimal largestValue = 0;

        //creates a decimal called smallestValue and sets it equal to 0
        decimal smallestValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Method converts text file to an array and returns it when called
        private string[] TextToArray()
        {
            //creates an integer called index which is set to 0
            int index = 0;

            //creates an array that will hold 7 items/elements
            string[] sales = new string[7];

            //tries to add items to the array from the text file
            try
            {
                //opens the sales text file with the StreamReader object
                StreamReader inputFile = new StreamReader("./Sales.txt");

                //while loop loops until the end of the text file
                while (!inputFile.EndOfStream)
                {
                    //adds the current line in the loop to the array
                    sales[index] = inputFile.ReadLine();

                    //increments the index by 1
                    index += 1;
                }

                //closes Sales.txt
                inputFile.Close();
            }

            //displays an error to the user if the text file was not found or unable to be converted
            catch
            {
                //displays the error
                MessageBox.Show("Sales.txt was modified or not found.");

                //changes calculate to false since an error has occured
                calculate = false;
            }

            //returns the array when called
            return sales;
        }

        private void CompareValues(decimal saleDecimal)
        {
            //sets largest and smallest value equal to the first item in the sales array
            if (firstIteration)
            {
                largestValue = saleDecimal;

                smallestValue = saleDecimal;
            }

            /*if the current iteration of the parsed sale is greater than the current 
            largest value, then set largest value equal to new largest number*/
            if (saleDecimal > largestValue)
            {
                largestValue = saleDecimal;
            }

            /*if the current iteration of the parsed sale is less than the current 
            smallest value, then set largest value equal to new smallest number*/
            if (saleDecimal < smallestValue)
            {
                smallestValue = saleDecimal;
            }

            //changes firstIteration to false since it will no longer be the first iteration
            firstIteration = false;
        }

        /*Method adds the sales to the listbox and calculates the total amount of sales made in dollars
         when the calculateSalesButton is clicked*/
        private void calculateSalesButton_Click(object sender, EventArgs e)
        {
            //creates a decimal called totalSales and sets it equal to 0
            decimal totalSales = 0;

            //clears the listbox in case the user clicks the calculate button twice
            salesListBox.Items.Clear();

            //uses the foreach loop to look at each item or sale in the sales array
            foreach (string sale in TextToArray())
            {
                //if no error has occured then the items will be added to the listbox and calculated
                if (calculate)
                {
                    //adds the sale in the current iteration to the listbox
                    salesListBox.Items.Add($"${sale}");

                    //tries to parse the sale of the current iteration
                    if (decimal.TryParse(sale, out decimal saleDecimal))
                    {
                        //adds the parsed sale in the current iteration to the totalSales variable
                        totalSales += saleDecimal;

                        //calculates the largest and smallest sale values
                        CompareValues(saleDecimal);
                    }

                    //displays an error if there are a number could not be successfully parsed
                    else
                    {
                        //clears the listbox
                        salesListBox.Items.Clear();

                        //displays the error
                        MessageBox.Show("Sales.txt does not include valid numbers.");

                        //changes calculate to false since an error has occured
                        calculate = false;
                    }
                }
            }

            //if no error has occured then the total and average will be displayed
            if (calculate)
            {
                //displays the total amount of sales to the user
                totalSalesOutputLabel.Text = totalSales.ToString("c");

                //displays the average amount of sales to the user
                averageSalesOutputLabel.Text = (totalSales/TextToArray().Length).ToString("c");

                //displays the largest sale value
                largestValueOutputLabel.Text = largestValue.ToString("c");

                //displays the smallest sale value
                smallestValueOutputLabel.Text = smallestValue.ToString("c");
            }
        }

        //Method clears the listbox and the total sales label when the clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the listbox
            salesListBox.Items.Clear();

            //sets the total sales label to an empty string
            totalSalesOutputLabel.Text = "";

            //sets the average sales label to an empty string
            averageSalesOutputLabel.Text = "";

            //sets the largest value label to an empty string
            largestValueOutputLabel.Text = "";

            //sets the smallest value label to an empty string
            smallestValueOutputLabel.Text = "";
        }

        //Method closes the application when the exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
