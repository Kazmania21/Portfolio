using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal OilLubeCharges (decimal total = 0)
        {
            
            if (oilChangeCheckBox.Checked)
            {
                total += 26;
            }

            if (lubeJobCheckBox.Checked)
            {
                total += 18;
            }

            return total;

        }

        private decimal FlushCharges (decimal total = 0m)
        {
            if (radiatorFlushCheckBox.Checked)
            {
                total += 30;
            }

            if (transmissionFlushCheckBox.Checked)
            {
                total += 80;
            }

            return total;
        }

        private decimal MiscCharges (decimal total = 0m)
        {
            if (inspectionCheckBox.Checked)
            {
                total += 15;
            }

            if (replaceMufflerCheckBox.Checked)
            {
                total += 200;
            }

            if (tireRotationCheckBox.Checked)
            {
                total += 20;
            }

            return total;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal total=0;

            decimal[] serviceAndLaborArray = { OilLubeCharges(total), FlushCharges(total), MiscCharges(total) };

            foreach (decimal service in serviceAndLaborArray)
            {
                total += service;
            }

            serviceAndLaborResult.Text = total.ToString("c");

        }
    }
}
