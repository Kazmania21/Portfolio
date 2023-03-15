using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class Colony : Form
    {
        public static Dictionary<string, Cell> populatedCells = new Dictionary<string, Cell>();
        public static string currentTextFile = "default.txt";

        public static void PopulateColony() // O(n)
        {
            removeCells(); // O(n)

            StreamReader streamReader = new StreamReader($"../../Lexicon/{currentTextFile}");

            string[] coordinates = streamReader.ReadToEnd().Split('\n'); // O(1)

            foreach (string coordinate in coordinates) // O(n)
            {
                string trimmedCoordinate = coordinate.Trim();
                string[] trimmedCoordinateArray = trimmedCoordinate.Split(',');
                populatedCells[trimmedCoordinate] = new Cell(int.Parse(trimmedCoordinateArray[0]), int.Parse(trimmedCoordinateArray[1])); // O(1)
            }

            streamReader.Close();
            addCells();
        }

        public static void removeCells() // O(n)
        {
            foreach (var populatedCell in populatedCells) // O(n)
            {
                populatedCell.Value.Dispose(); // O(1)
            }

            populatedCells.Clear(); // O(1)
        }

        public static void addCells() // O(n)
        {
            foreach (var populatedCell in populatedCells) // O(n)
            {
               populatedCell.Value.AddToTable();
            }
        }
    }
}
