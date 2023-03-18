using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Zoom
    {
        //static List<int> zooms = new List<int> { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 };
        public static int zoom;

        public static void ChangeZoom(int selectedIndex, CellTable cellTable)
        {
            Console.WriteLine("hi");
            zoom = 10 + 5 * selectedIndex;

            cellTable.SetTableSize(zoom);

            foreach (var populatedCell in Colony.populatedCells) // O(n)
            {
                populatedCell.Value.CellLocation();
            }
        }
    }
}
