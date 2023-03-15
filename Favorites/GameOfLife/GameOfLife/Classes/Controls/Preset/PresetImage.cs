using System;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class PresetImage : PictureBox
    {
        public PresetImage(string name, EventHandler button_Click)
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            SizeMode = PictureBoxSizeMode.Zoom;
            ImageLocation = $"../../Images/{name}.jpg";
            Click += button_Click;
        }
    }
}
