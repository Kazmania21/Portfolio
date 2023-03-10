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
        private List<String> linkString = new List<String>();
        private String[] newString;
        private int index = 0;

        public MemberLinks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkString.Add($"{nameBox.Text}");
            linkString.Add($"UGN {nameBox.Text} GO CHECK OUT THE HOST OF THIS CONTENT / UGN {nameBox.Text} / SOCIAL LINKS BELOW");
            linkString.Add("🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽");

            if (youtubeBox.Text != "")
            {
                linkString.Append($"🔴 YOUTUBE | {youtubeBox.Text}");
            }

            if (twitchBox.Text != "")
            {
                linkString.Append($"🔴 TWITCH | {twitchBox.Text}");
            }

            if (dliveBox.Text != "")
            {
                linkString.Append($"🔴 DLIVE | {dliveBox.Text}");
            }

            if (sliverBox.Text != "")
            {
                linkString.Append($"🔴 SLIVER | {sliverBox.Text}");
            }

            if (twitterBox.Text != "")
            {
                linkString.Append($"💻 TWITTER | {twitterBox.Text}");
            }

            linkString.ToArray();

            outputBox.Lines = linkString;
        }
    }
}
