using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopCalculator
{
    public partial class WorkshopCalculator : Form
    {
        public WorkshopCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //holds the selected item in the workshop list
            decimal workshopIndexNumber = workshopTypeListBox.SelectedIndex;

            //holds the selected item in the location list
            decimal locationIndexNumber = workshopLocationListBox.SelectedIndex;

            //holds the amount of days that user will be in the workshop
            decimal daysInWorkshop = 0;

            //holds the fee for registration
            decimal registrationFee = 0;

            //holds the lodging fee per day at the workshop
            decimal lodgingFeesPerDay;

            //gives an error if the user did not select a workshop
            if (workshopIndexNumber != -1)
            {
                //if-else-if statement takes the selected workshop index and decides how many days the
                //user will be in the workshop and what the registration fee will be
                if (workshopIndexNumber == 0)
                {
                    daysInWorkshop = 3;

                    registrationFee = 1000;
                }

                else if (workshopIndexNumber == 1)
                {
                    daysInWorkshop = 3;

                    registrationFee = 800;
                }

                else if (workshopIndexNumber == 2)
                {
                    daysInWorkshop = 3;

                    registrationFee = 1500;
                }

                else if (workshopIndexNumber == 3)
                {
                    daysInWorkshop = 5;

                    registrationFee = 1300;
                }

                else
                {
                    daysInWorkshop = 1;

                    registrationFee = 500;
                }

                //shows the user the registration fee
                registrationLabel.Text = $"Registration fee: {registrationFee.ToString("c")}";

            }

            else
            {
                MessageBox.Show("Please select a workshop.");
            }

            //the nested switch statement takes the selected location index and decides what the
            //daily lodging fee will be
            //if an index is not selected, an error message will appear
            switch (locationIndexNumber)
            {
                case -1:
                    MessageBox.Show("Please select a location.");
                    lodgingFeesPerDay = 0;
                    break;

                default:
                    switch (locationIndexNumber)
                    {
                        case 0:
                            lodgingFeesPerDay = 150;
                            break;

                        case 1:
                            lodgingFeesPerDay = 225;
                            break;

                        case 2:
                            lodgingFeesPerDay = 175;
                            break;

                        case 3:
                            lodgingFeesPerDay = 300;
                            break;

                        case 4:
                            lodgingFeesPerDay = 175;
                            break;

                        default:
                            lodgingFeesPerDay = 150;
                            break;
                    }

                    //calculates the lodging fee for the whole workshop
                    decimal totalLodgingFee = lodgingFeesPerDay * daysInWorkshop;

                    //shows the user the lodging fee per day, the amount of days, and the total lodging fee for the workshop
                    lodgingLabel.Text = $"Daily lodging fee: {lodgingFeesPerDay.ToString("c")} x {daysInWorkshop} days = " +
                                        $"{(totalLodgingFee).ToString("c")}";

                    //shows the user the total cost of the workshop
                    totalLabel.Text = $"Total: {(registrationFee + totalLodgingFee).ToString("c")}";

                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
