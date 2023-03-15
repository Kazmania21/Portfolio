using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class PresetName : Label
    {
        public PresetName(string name, EventHandler button_Click)
        {
            Text = name;
            Font = new Font("Impact", 16.2f);
            TextAlign = ContentAlignment.MiddleLeft;
            ForeColor = Color.Gold;
            AutoSize = true;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Click += button_Click;
        }
    }
}
