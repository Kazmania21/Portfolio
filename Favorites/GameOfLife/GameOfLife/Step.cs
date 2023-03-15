using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Step : Colony
    {
        public static int step = 0;
        static List<int> adjCoords = new List<int>() { -1, 0, 1 };

        public static string UpdateCount(int newStepCount)
        {
            step = newStepCount;
            return $"Step: {step}";
        }

        private static List<Dictionary<string, Cell>> FindAdjCells(Dictionary<string, Cell> cells, bool populated)
        {
            UpdateCount(step++);
            var cellsToUpdate = new Dictionary<string, Cell>();
            var unpopAdjCells = new Dictionary<string, Cell>();

            foreach (var cell in cells) // 0(n)
            {
                string[] coordinates = cell.Key.Split(',');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);

                int popAdjCellsCount = 0;
                if (populated) { popAdjCellsCount--; }

                foreach (int xAxis in adjCoords) // O(1)
                {
                    foreach (int yAxis in adjCoords) // O(1)
                    {
                        int adjXAxis = xAxis + x;
                        int adjYAxis = yAxis + y;

                        string adjCell = $"{adjXAxis},{adjYAxis}";

                        if (populatedCells.ContainsKey(adjCell)) // O(1)
                        {
                            popAdjCellsCount++;
                        }

                        else if (populated)
                        {
                            unpopAdjCells[adjCell] = new Cell(adjXAxis, adjYAxis);
                        }
                    }
                }

                if (2 != popAdjCellsCount && popAdjCellsCount != 3 && populated)
                {
                    cellsToUpdate[cell.Key] = cell.Value;
                }

                else if (popAdjCellsCount == 3 && !populated)
                {
                    cellsToUpdate[cell.Key] = cell.Value;
                }
            }

            return new List<Dictionary<string, Cell>> { cellsToUpdate, unpopAdjCells };
        }

        public static string UpdateColony() // 0(n)
        {
            var adjCells = FindAdjCells(populatedCells, true); // 0(n)
            var unpopAdjCells = adjCells[1];
            var popToUnpop = adjCells[0];

            var unpopToPop = FindAdjCells(unpopAdjCells, false)[0]; // 0(n)

            foreach (var populatedCell in popToUnpop) // 0(n)
            {
                var cell = populatedCells[populatedCell.Key];
                cell.InvokeControl(cell.Dispose);
                populatedCells.Remove(populatedCell.Key);
            }

            foreach (var unpopulatedCell in unpopToPop) //0(n)
            {
                populatedCells[unpopulatedCell.Key] = unpopulatedCell.Value;
                populatedCells[unpopulatedCell.Key].AddToTable();
            }

            return UpdateCount(step + 1);
        }
    }
}
