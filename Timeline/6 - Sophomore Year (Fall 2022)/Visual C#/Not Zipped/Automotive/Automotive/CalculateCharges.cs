using System.Collections.Generic;
using System.Windows.Forms;

namespace Automotive
{
    public class CalculateCharges : Form1
    {
        //returns all of the methods that calculate service and labor costs when called
        public decimal[] ServiceAndLabor(Dictionary<string, object> guiObjects)
        {
            decimal[] serviceAndLaborArray = { OilLubeCharges(guiObjects), FlushCharges(guiObjects), MiscCharges(guiObjects) };

            return serviceAndLaborArray;
        }

        //returns the total cost from an array of checkboxes when called
        public decimal CostFromCheckBoxes(CheckBox[] checkboxes, decimal[] costs)
        {
            decimal totalCost = 0m;

            int index = 0;

            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    totalCost += costs[index];
                }

                index++;
            }

            return totalCost;
        }

        //returns the user's text input as a decimal when called
        public decimal TextBoxTextParser(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                return 0m;
            }

            return decimal.Parse(textbox.Text);
        }

        //Calculates oil and lube charges when called
        public decimal OilLubeCharges(Dictionary<string, object> guiObjects)
        {
            decimal[] costs = { 26m, 18m };

            return CostFromCheckBoxes((CheckBox[])guiObjects["oilAndLube"], costs);
        }

        //Calculates flush charges when called
        public decimal FlushCharges(Dictionary<string, object> guiObjects)
        {
            decimal[] costs = { 30m, 80m };

            return CostFromCheckBoxes((CheckBox[])guiObjects["flushes"], costs);
        }

        //Calculates misc charges when called
        public decimal MiscCharges(Dictionary<string, object> guiObjects)
        {
            decimal[] costs = { 15m, 200m, 20m };

            return CostFromCheckBoxes((CheckBox[])guiObjects["misc"], costs);
        }

        //Calculates parts and labor charges when called
        public decimal[] OtherCharges(Dictionary<string, object> guiObjects)
        {
            decimal[] costArray = new decimal[2];

            //Parses the user's input as a decimal and adds it to the cost array
            for (int index = 0; index <= 1; index++) {
                costArray[index] = TextBoxTextParser(((TextBox[])guiObjects["partsAndLabor"])[index]);
            }

            return costArray;
        }

        //Calculates the tax on parts when called
        public decimal TaxCharges(Dictionary<string, object> guiObjects)
        {
            return TextBoxTextParser(((TextBox[])guiObjects["partsAndLabor"])[0]) * .06m;
        }

        //Calculates the total amount of charges when called
        public decimal TotalCharges(Dictionary<string, object> guiObjects)
        {
            decimal totalCharges = 0;

            Label[] labels = (Label[])guiObjects["summary"];
            
            //Foreach loop parses all of the labels into decimals
            foreach (Label label in labels)
            {
                if (label.Text != labels[3].Text) // Stops the totalFeesResult label being added to the total costs
                {
                    totalCharges += decimal.Parse(label.Text.Substring(1));
                }
            }

            return totalCharges;
        }
    }
}
