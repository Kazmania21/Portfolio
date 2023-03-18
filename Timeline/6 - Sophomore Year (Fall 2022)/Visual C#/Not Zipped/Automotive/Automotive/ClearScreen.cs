using System.Collections.Generic;
using System.Windows.Forms;

namespace Automotive
{
    public class ClearScreen : Form1
    {
        //The screen clearing secretary
        public ClearScreen(Dictionary<string, object> guiObjects)
        {
            ClearOilLube(guiObjects);
            ClearFlushes(guiObjects);
            ClearMisc(guiObjects);
            ClearOther(guiObjects);
            ClearFees(guiObjects);
        }

        //Clears an array of form objects
        public void ClearObjects(object obj)
        {
            //If statement checks the type of array and clears it based on its type
            if (obj is CheckBox[])
            {
                foreach (CheckBox checkBox in (CheckBox[])obj)
                {
                    checkBox.Checked = false;
                }
            }

            else if (obj is TextBox[])
            {
                foreach (TextBox textbox in (TextBox[])obj)
                {
                    textbox.Text = "";
                }
            }

            else
            {
                foreach (Label label in (Label[])obj)
                {
                    label.Text = "";
                }
            }
        }

        //Clears the oil and lube checkboxes
        private void ClearOilLube(Dictionary<string, object> guiObjects)
        {
            ClearObjects(guiObjects["oilAndLube"]);
        }

        //Clears the flush checkboxes
        private void ClearFlushes(Dictionary<string, object> guiObjects)
        {
            ClearObjects(guiObjects["flushes"]);
        }

        //Clears the misc checkboxes
        private void ClearMisc(Dictionary<string, object> guiObjects)
        {
            ClearObjects(guiObjects["misc"]);
        }

        //Clears the parts and labor textboxes
        private void ClearOther(Dictionary<string, object> guiObjects)
        {
            ClearObjects(guiObjects["partsAndLabor"]);
        }

        //Clears the summary labels
        private void ClearFees(Dictionary<string, object> guiObjects)
        {
            ClearObjects(guiObjects["summary"]);
        }
    }
}
