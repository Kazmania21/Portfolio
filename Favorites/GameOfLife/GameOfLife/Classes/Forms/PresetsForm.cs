using System;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class PresetsForm : Form
    {
        public bool presetSelected = false;

        public PresetsForm()
        {
            InitializeComponent();

            foreach (var file in Directory.GetFiles("../../Lexicon_Discriptions"))
            {
                StreamReader streamReader = new StreamReader(file);

                string name = file.Replace(@"../../Lexicon_Discriptions\", "");
                name = name.Remove(name.IndexOf("D"));
                name = name.Insert(0, name[0].ToString().ToUpper());
                name = name.Remove(1, 1);

                PresetButton button = new PresetButton(name, streamReader, presetButton_Click);
                windowTableLayoutPanel.Controls.Add(button);

                streamReader.Close();
            }
        }

        private void presetButton_Click(object sender, EventArgs e)
        {
            Control senderControl = (Control)sender;
            Colony.currentTextFile = $"{senderControl.Parent.Name}.txt";
            presetSelected = true;
            this.Close();
        }
    }
}
