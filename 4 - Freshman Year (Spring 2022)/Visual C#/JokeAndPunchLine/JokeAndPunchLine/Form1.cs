using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchLine
{
    public partial class jokeAndPunchLine : Form
    {
        public jokeAndPunchLine()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            setupLabel.Visible = true;
            punchLineLabel.Visible = false;
        }

        private void punchLineButton_Click(object sender, EventArgs e)
        {
            setupLabel.Visible = false;
            punchLineLabel.Visible = true;
        }
    }
}
