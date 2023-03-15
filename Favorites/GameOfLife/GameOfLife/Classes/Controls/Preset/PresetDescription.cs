using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class PresetDescription : Label
    {
        public PresetDescription(string description, EventHandler button_Click)
        {
            Text = description;
            Font = new Font("Maiandra GD", 12f);
            TextAlign = ContentAlignment.MiddleLeft;
            ForeColor = Color.Black;
            AutoSize = true;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Click += button_Click;
        }
    }
}
