using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class CellTable : DataGridView
    {
        public static Panel cellPanel = new Panel()
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
        };

        public CellTable() // O(n)
        {
            RowHeadersVisible = false;
            ColumnHeadersVisible = false;
            ScrollBars = ScrollBars.None;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            BackgroundColor = SystemColors.ControlDarkDark;
            Dock = DockStyle.Fill;

            cellPanel.Controls.Add(this);

            ReadOnly = true;
            ColumnCount = (int)(cellPanel.Size.Width / 10);
            RowCount = (int)(cellPanel.Size.Height / 10);

            SetTableSize(60);
        }

        public void SetTableSize(int zoom)
        {
            for (int i = 0; i < ColumnCount; i++) // O(n)
            {
                Columns[i].Width = zoom;
            }

            for (int i = 0; i < RowCount; i++) // O(n)
            {
                Rows[i].Height = zoom;
            }
        }
    }
}
