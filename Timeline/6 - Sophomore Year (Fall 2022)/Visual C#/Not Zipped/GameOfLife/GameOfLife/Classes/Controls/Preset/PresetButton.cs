using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GameOfLife
{
    internal class PresetButton : TableLayoutPanel
    {
        public PresetButton(string name, StreamReader description, EventHandler button_Click)
        {
            Name = name;
            RowCount = 2;
            ColumnCount = 2;
            BackColor = Color.Gray;
            Margin = new Padding(25, 25, 25, 25);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            PictureBox image = new PresetImage(name, button_Click);

            Controls.Add(image);
            SetRowSpan(image, 2);

            Controls.Add(new PresetName(name, button_Click));
            Controls.Add(new PresetDescription(description.ReadLine(), button_Click));
        }
    }
}
