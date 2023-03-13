using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackVendingMachine
{
    public partial class Form1 : Form
    {
        //below are constants that have the price for a unit of each item
        const decimal LAYS_PRICE = 1.99m;

        const decimal DORITOS_PRICE = 2.99m;

        const decimal PRETZELS_PRICE = 1.49m;

        const decimal SKITTLES_PRICE = 0.99m;

        const decimal WATER_PRICE = 1.09m;

        const decimal GATORADE_PRICE = 2.79m;

        //decimal that keeps track of the total price of snacks
        decimal totalPrice = 0m;

        //below are decimals that keep track of individual prices

        decimal totalLaysPrice = 0m;

        decimal totalDoritosPrice = 0m;

        decimal totalPretzelsPrice = 0m;

        decimal totalSkittlesPrice = 0m;

        decimal totalWaterPrice = 0m;

        decimal totalGatoradePrice = 0m;

        //below are integers that keep track of the amount of each item

        int laysAmount = 5;

        int doritosAmount = 5;

        int pretzelAmount = 5;

        int skittlesAmount = 5;

        int waterAmount = 5;

        int gatoradeAmount = 5;

        public Form1()
        {
            InitializeComponent();
        }

        //method that calculates the total price and returns it when called
        private string Price(decimal price, int amountLeft)
        {
            /*if there are still some of the selected item left than the price of the item will be added
            to the total*/
            if (amountLeft != 0)
            {
                //adds the price of the selcted item to the total price
                totalPrice += price;
            }

            //puts the total price into a string and formats it to currency
            string totalPriceDisplay = totalPrice.ToString("c");

            //returns the total price in the form of a string
            return totalPriceDisplay;
        }

        /*method that calculates the price for the item that was just added to the cart
        and returns it when called*/
        private string ItemPrice(decimal itemPrice, int amountLeft, ref decimal totalItemPrice, Label itemPriceLabel)
        {
            //creates a string equal to the ItemPriceLabel
            string totalPriceDisplay = itemPriceLabel.Text;

            //determines if there are still some of the selected item left
            if (amountLeft != 0)
            {

                //calculates the total price that will be paid for that item
                totalItemPrice += itemPrice;

                //sets total Price display to a calculated price demonstartion of the selected item
                totalPriceDisplay = $"{6 - amountLeft} * {itemPrice.ToString("c")} = {(totalItemPrice).ToString("c")}";
            }

            return totalPriceDisplay;
        }

        //method that calculates the amount of items left and returns the label text when called
        private string AmountLeft(ref int amountLeft)
        {
            //if there are still some of the selected item left then amount will be decremented
            if (amountLeft != 0)
            {
                amountLeft--;
            }

            //if there are none of the selected item left then an error message will be displayed
            else
            {
                MessageBox.Show("Sorry, we are out of this item at this time!");
            }

            //returns the amount of the selected item left
            return $"{amountLeft} left";
        }

        /*method that resets all values except for the amount of items
        back to there normal configuration*/
        private void ResetValues()
        {
            //resets the total price
            totalPrice = 0m;

            //the rest of the lines in the method set the item output labels to 0 or $0
            totalLaysOutputLabel.Text = "0";

            totalDoritosOutputLabel.Text = "0";

            totalPretzelsOutputLabel.Text = "0";

            totalSkittlesOutputLabel.Text = "0";

            totalWaterOutputLabel.Text = "0";

            totalGatoradeOutputLabel.Text = "0";

            totalPriceOutputLabel.Text = "$0";

            //lines below reset the total price for each item

            totalLaysPrice = 0m;

            totalDoritosPrice = 0m;

            totalPretzelsPrice = 0m;

            totalSkittlesPrice = 0m;

            totalWaterPrice = 0m;

            totalGatoradePrice = 0m;
        }

        //method is called when the user adds lays to the cart
        private void laysPurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(LAYS_PRICE, laysAmount);
            //sets the totalLaysOutputLabel text to the new net price of the lays
            totalLaysOutputLabel.Text = ItemPrice(LAYS_PRICE, laysAmount, ref totalLaysPrice, totalLaysOutputLabel);
            //sets the laysAmountLabel text to the new amount of lays
            laysAmountLabel.Text = AmountLeft(ref laysAmount);
        }

        //method is called when the user adds doritos to the cart
        private void doritosPurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(DORITOS_PRICE, doritosAmount);
            //sets the totalDoritosOutputLabel text to the new net price of the doritos
            totalDoritosOutputLabel.Text = ItemPrice(DORITOS_PRICE, doritosAmount, ref totalDoritosPrice, totalDoritosOutputLabel);
            //sets the doritosAmountLabel text to the new amount of doritos
            doritosAmountLabel.Text = AmountLeft(ref doritosAmount);
        }

        //method is called when the user adds pretzels to the cart
        private void pretzelPurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(PRETZELS_PRICE, pretzelAmount);
            //sets the totalPretzelsOutputLabel text to the new net price of the pretzels
            totalPretzelsOutputLabel.Text = ItemPrice(PRETZELS_PRICE, pretzelAmount, ref totalPretzelsPrice, totalPretzelsOutputLabel);
            //sets the pretzelsAmountLabel text to the new amount of pretzels
            pretzelAmountLabel.Text = AmountLeft(ref pretzelAmount);
        }

        //method is called when the user adds skittles to the cart
        private void skittlesPurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(SKITTLES_PRICE, skittlesAmount);
            //sets the totalSkittlesOutputLabel text to the new net price of the skittles
            totalSkittlesOutputLabel.Text = ItemPrice(SKITTLES_PRICE, skittlesAmount, ref totalSkittlesPrice, totalSkittlesOutputLabel);
            //sets the skittlesAmountLabel text to the new amount of skittles
            skittlesAmountLabel.Text = AmountLeft(ref skittlesAmount);
        }

        //method is called when the user adds water to the cart
        private void waterPurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(WATER_PRICE, waterAmount);
            //sets the totalWaterOutputLabel text to the new net price of the watter bottles
            totalWaterOutputLabel.Text = ItemPrice(WATER_PRICE, waterAmount, ref totalWaterPrice, totalWaterOutputLabel);
            //sets the waterAmountLabel text to the new amount of water
            waterAmountLabel.Text = AmountLeft(ref waterAmount);
        }

        //method is called when the user adds gatorade to the cart
        private void gatoradePurchaseButton_Click(object sender, EventArgs e)
        {
            //sets the totalPriceOutputLabel text to the new total price
            totalPriceOutputLabel.Text = Price(GATORADE_PRICE, gatoradeAmount);
            //sets the totalGatoradeOutputLabel text to the new net price of the gatorade
            totalGatoradeOutputLabel.Text = ItemPrice(GATORADE_PRICE, gatoradeAmount, ref totalGatoradePrice, totalGatoradeOutputLabel);
            //sets the gatoradeAmountLabel text to the new amount of gatorade
            gatoradeAmountLabel.Text = AmountLeft(ref gatoradeAmount);
        }

        //method that is called when the user clicks "check out"
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            //if statement that detects if there is any items in the cart
            if (totalPrice != 0)
            {
                //creates a string called message and sets it equal to the user's order
                string message = $"            Item: # * Value = Price\n" +
                                        $"             Lays: {totalLaysOutputLabel.Text}" +
                                        $"\n        Doritos: {totalDoritosOutputLabel.Text}" +
                                        $"\n       Pretzels: {totalPretzelsOutputLabel.Text}" +
                                        $"\n        Skittles: {totalSkittlesOutputLabel.Text}" +
                                        $"\n          Water: {totalWaterOutputLabel.Text}" +
                                        $"\n     Gatorade: {totalGatoradeOutputLabel.Text}" +
                                        $"\n    Total Price: {totalPriceOutputLabel.Text}" +
                                        $"\n\nWould you like to complete your order?";

                //YesNo message box asks if user wants to complete their order
                if (MessageBox.Show(message , "Your Order:", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //If the user selected yes, a thank you message will appear
                    MessageBox.Show("Your items are now dispensing.\nThank you for you purchase!", 
                        "Thank you!");

                    //Resets the cart to default settings
                    ResetValues();
                }
            }
            
            else
            {
                //If their are no items in the cart, the user will be notified
                MessageBox.Show("You have no items in your cart!");
            }
        }

        //resets all values when the reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            //lines below reset the amount of items in the vending machine
            laysAmountLabel.Text = "5 left";

            doritosAmountLabel.Text = "5 left";

            pretzelAmountLabel.Text = "5 left";

            skittlesAmountLabel.Text = "5 left";

            waterAmountLabel.Text = "5 left";

            gatoradeAmountLabel.Text = "5 left";

            laysAmount = 5;

            doritosAmount = 5;

            pretzelAmount = 5;

            skittlesAmount = 5;

            waterAmount = 5;

            gatoradeAmount = 5;

            //Calls the RestValues method to reset the rest of the items
            ResetValues();
        }

        //closes the application when the user clicks "exit"
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
