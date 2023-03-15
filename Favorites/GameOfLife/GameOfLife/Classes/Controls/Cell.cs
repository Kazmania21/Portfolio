using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class Cell : Label
    {
        public int x = 0;
        public int y = 0;

        public Cell(int xAxis, int yAxis)
        {
            x = xAxis;
            y = yAxis;
            BorderStyle = BorderStyle.FixedSingle;
            BackColor = Color.Gold;
            Size = new Size(10, 10);
            Margin = Padding.Empty;
        }

        public void CellLocation()
        {
            Size = new Size(Zoom.zoom, Zoom.zoom);
            Location = new Point(CellTable.cellPanel.Left + x * Zoom.zoom - 2, CellTable.cellPanel.Top + y * Zoom.zoom - 90); // O(1)
        }

        public void AddToTable() // O(1)
        {
            CellTable.cellPanel.InvokeControl(delegate { CellTable.cellPanel.Controls.Add(this); }); // O(1)

            this.InvokeControl(CellLocation); // O(1)
            this.InvokeControl(BringToFront); // O(1)
        }
    }
}
