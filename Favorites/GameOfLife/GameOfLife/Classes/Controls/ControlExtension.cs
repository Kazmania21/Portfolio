using System;
using System.Windows.Forms;

namespace GameOfLife
{
    internal static class ControlExtension
    {
        public static void InvokeControl (this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }

            else { action(); }
        }
    }
}
