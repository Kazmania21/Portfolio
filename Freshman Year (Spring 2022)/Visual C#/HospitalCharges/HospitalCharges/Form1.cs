using System;
using System.Windows.Forms;

namespace HospitalCharges
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* A method that holds an array of TextBoxes and returns the array when called. 
         This helps when multiple methods need to use this array.*/
        private TextBox[] textBoxes()
        {
            TextBox[] textBoxArray = { daysTextBox, medicationChargesTextBox, surgicalChargesTextBox, labFeesTextBox, physicalRehabChargesTextBox };

            return textBoxArray;
        }

        /* A method that holds an array of Labels and returns the array when called. 
         This helps when multiple methods need to use this array.*/
        private Label[] outputLabels()
        {
            Label[] outputLabelsArray = { daysSpentResultLabel, miscChargesResultLabel, totalCostResultLabel };

            return outputLabelsArray;
        }

        // A method that calculates the amount of stay charges and returns it when called
        private int CalcStayCharges (ref bool calculate)
        {
            //creates a decimal called stayCharges
            int stayCharges = 0;
            
            /* if statement tries to parse the content in daysTextBox into a decimal
            called daysInHospital */
            if (int.TryParse(daysTextBox.Text, out int daysInHospital))
            {
                if (daysInHospital >= 0)
                {
                    // calculates the amount stay charges
                    stayCharges = daysInHospital * 350;
                }
                
                else
                {
                    MessageBox.Show("Please enter a positive whole number.");

                    calculate = false;
                }
            }

            // gives the text box a value of zero assuming their were no charges
            else if (daysTextBox.Text == "")
            {
                daysTextBox.Text = "0";

                MessageBox.Show("One or more pieces of information are blank. A zero has been filled in for any missing info.");
            }

            // displays an error message if the user inputs something other than a whole number
            else
            {
                MessageBox.Show("Please input whole numbers only.");

                calculate=false;
            }

            //returns the amount of stay charges to the user
            return stayCharges;
        }

        // A method that calculates the amount of miscellaneous charges and returns it when called
        private decimal CalcMiscCharges (ref bool calculate)
        {
            //creates a decimal called miscCharges
            decimal miscCharges = 0;

            /* for loop contains a variable called x that will loop through the textBoxes()
            array with x as the index */
            for (int x = 1; x < 5; x++)
            {

                if (calculate)
                {
                    /* if statement that tries to parse the content in the corresponding textbox into a decimal
                called charge */
                    if (decimal.TryParse(textBoxes()[x].Text, out decimal charge))
                    {
                        if (charge >= 0)
                        {
                            miscCharges += charge;
                        }

                        else
                        {
                            MessageBox.Show("Please enter a positive number.");

                            calculate = false;
                        }
                    }

                    // gives the text box a value of zero assuming their were no charges
                    else if (textBoxes()[x].Text == "")
                    {
                        textBoxes()[x].Text = "0";

                        MessageBox.Show("One or more pieces of information are blank. A zero has been filled in for any missing info.");
                    }

                    // displays an error message if the user inputs something other than a number
                    else
                    {
                        MessageBox.Show("Please input numbers only.");

                        calculate = false;
                    }
                }

                
            }

            return miscCharges;

        }

        // A method that calculates the total charges and returns it when called
        private decimal CalcTotalCharges (bool calculate, string stayChargeResult, string miscResult)
        {
            decimal totalCharges = 0m;

            if (calculate)
            {
                if (decimal.TryParse(stayChargeResult, out decimal stayCharge))
                {
                    if (decimal.TryParse(miscResult, out decimal miscCharge))
                    {
                        totalCharges = stayCharge + miscCharge;
                    }
                }
            }

            else 
            {
                totalCharges = -10m;
            }

            return totalCharges;
        }

        /* A method that displays the stay, miscellaneous, and total
        charges when the user clicks the calculate button */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            bool calculate = true;

            //displays the amount of display charges
            daysSpentResultLabel.Text = CalcStayCharges(ref calculate).ToString("c");

            //displays the amount of miscellaneous charges
            miscChargesResultLabel.Text = CalcMiscCharges(ref calculate).ToString("c");

            //displays the total amount of charges
            totalCostResultLabel.Text = CalcTotalCharges(calculate, daysSpentResultLabel.Text, miscChargesResultLabel.Text).ToString("c");
            // displays nothing if error
            if (CalcTotalCharges(calculate, daysSpentResultLabel.Text, miscChargesResultLabel.Text) == -10)
            {
                
                daysSpentResultLabel.Text = "";

                miscChargesResultLabel.Text = "";

                totalCostResultLabel.Text = "";
            }
        }

        // A method that clears all textboxes and labels when the user clicks the clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            //for loop clears the textboxes
            for (int x = 0; x < 5; x++)
            {
                textBoxes()[x].Text = "";
            }

            //for loop clears the output labels
            for (int x = 0; x < 3; x++)
            {
                outputLabels()[x].Text = "";
            }
        }

        // A method that closes the app when the user clicks the exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
