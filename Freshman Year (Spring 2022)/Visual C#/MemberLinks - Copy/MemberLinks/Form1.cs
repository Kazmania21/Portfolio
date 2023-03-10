using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberLinks
{
    public partial class MemberLinks : Form
    {

        public MemberLinks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linkString = $"{nameBox.Text}\nUGN {nameBox.Text} GO CHECK OUT THE HOST OF THIS CONTENT / UGN {nameBox.Text} / SOCIAL LINKS BELOW\n🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽\n";

            TextBox[] textBoxes = { youtubeBox, twitchBox, dliveBox, sliverBox, twitterBox };

            string[] apps = { "🔴 YOUTUBE | ", "🔴 TWITCH | ", "🔴 DLIVE | ", "🔴 SLIVER | ", "💻 TWITTER | " };

            for(int index = 0; index < textBoxes.Length; index ++)
            {
                if (textBoxes[index].Text != "")
                {
                    linkString = $"{linkString}{apps[index]}{textBoxes[index].Text}\n";
                }
            }

            outputBox.Text = linkString;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
    }
}
