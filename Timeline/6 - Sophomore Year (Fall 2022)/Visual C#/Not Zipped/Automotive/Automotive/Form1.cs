using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automotive
{

    public partial class Form1 : Form
    {
        //Contains objects on the form that will be edited
        Dictionary<string, object> GUIObjects = new Dictionary<string, object>();

        public Form1()
        {
            InitializeComponent();

            //Adds keys with object array to the previous dictionary
            GUIObjects["oilAndLube"] = new CheckBox[] { oilChangeCheckBox, lubeJobCheckBox };
            GUIObjects["flushes"] = new CheckBox[] { radiatorFlushCheckBox, transmissionFlushCheckBox };
            GUIObjects["misc"] = new CheckBox[] { inspectionCheckBox, replaceMufflerCheckBox, tireRotationCheckBox };
            GUIObjects["partsAndLabor"] = new TextBox[] { partsTextBox, laborTextBox };
            GUIObjects["summary"] = new Label[] { serviceAndLaborResult, partsResult, taxResult, totalFeesResult };
        }

        //Calculates the charges when pressed
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal totalServiceCost = 0;

            CalculateCharges charges = new CalculateCharges(); //Class in Automotive\CalculateCharges.cs

            //Foreach loop calculates the costs for services except labor
            foreach (decimal service in charges.ServiceAndLabor(GUIObjects)) 
            {
                totalServiceCost += service; 
            }

            //Puts calculate parts and labor costs into an arry
            decimal[] partsAndLaborCosts = charges.OtherCharges(GUIObjects);

            //Adds the labor costs to the total service costs
            totalServiceCost += partsAndLaborCosts[1];

            //The rest displays the results to the user
            serviceAndLaborResult.Text = totalServiceCost.ToString("c");

            partsResult.Text = partsAndLaborCosts[0].ToString("c");

            taxResult.Text = charges.TaxCharges(GUIObjects).ToString("c");

            totalFeesResult.Text = charges.TotalCharges(GUIObjects).ToString("c");
        }

        //Clears the screen when pressed
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearScreen clear = new ClearScreen(GUIObjects); //Class in Automotive\ClearScreen.cs
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
