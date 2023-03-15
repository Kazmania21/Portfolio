using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        List<double> speeds = new List<double> { 3000, 2000, 1750, 1500, 1250, 1000, 750, 500, 250, 50, .01 };
        int speed;

        static CellTable cellTable;

        bool isRunning = false;

        public MainForm()
        {
            InitializeComponent();

            CreateForm();

            Colony.PopulateColony();

            appTableLayoutPanel.Controls.Add(CellTable.cellPanel);
            appTableLayoutPanel.SetColumnSpan(CellTable.cellPanel, 3);
            appTableLayoutPanel.SetRowSpan(CellTable.cellPanel, 5);

            cellTable = new CellTable(); // O(n^2)

            zoomTrackBar.Value = 5;
        }

        private void CreateForm() // O(1)
        {
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;

            this.Size = new Size((int)(screenWidth * .95), (int)(screenHeight * .95));
        }

        private void startButton_Click(object sender, EventArgs e) // O(n^2) or O(1)
        {
            void changeRunState(Color color, string text) // O(1)
            {
                isRunning = !isRunning;
                startButton.Text = text;
                loadButton.BackColor = stepButton.BackColor = resetButton.BackColor = color;
                loadButton.Enabled = stepButton.Enabled = resetButton.Enabled = isRunning;
            }

            void runProgram() // O(n^2)
            {
                while (isRunning) // O(n^2)
                {
                    stepLabel.InvokeControl(delegate { stepLabel.Text = Step.UpdateColony(); }); // O(n)

                    Thread.Sleep(speed);
                }
            }

            if (!isRunning) // O(n^2)
            {
                changeRunState(Color.Gray, "STOP");
                speed = (int)speeds[speedTrackBar.Value];
                new Thread(runProgram).Start(); // O(n^2)
            }

            else { changeRunState(Color.Gold, "START");
                loadButton.Enabled = stepButton.Enabled = resetButton.Enabled = true;/* O(1) */ } // O(1)
        }

        private void stepButton_Click(object sender, EventArgs e) { stepLabel.Text = Step.UpdateColony(); }  // O(n)

        private void loadButton_Click(object sender, EventArgs e) // O(n)
        {
            PresetsForm presetsForm = new PresetsForm(); // O(1)
            presetsForm.ShowDialog(); // O(1)

            if (presetsForm.presetSelected)
            {
                Colony.PopulateColony();
            }
        }

        private void resetButton_Click(object sender, EventArgs e) // O(n)
        {
            stepLabel.Text = Step.UpdateCount(0);
            Colony.PopulateColony();
        }

        private void zoomTrackBar_Scroll(object sender, EventArgs e) { Zoom.ChangeZoom(zoomTrackBar.Value, cellTable); }

        private void exitButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            this.Close();
        }
    }
}
