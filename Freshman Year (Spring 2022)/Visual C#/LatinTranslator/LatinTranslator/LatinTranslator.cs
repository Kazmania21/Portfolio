using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class LatinTranslator : Form
    {
        public LatinTranslator()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            translatedTextLabel.Text = "left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translatedTextLabel.Text = "right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translatedTextLabel.Text = "center";
        }
    }
}
