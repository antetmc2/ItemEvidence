using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEvidence.PresentationLayer
{
    public static class FormExtensions
    {

        public static void ClearAllTextBoxes(this Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is NumericUpDown)
                    ((NumericUpDown)c).Value = 0;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                else
                    ClearAllTextBoxes(c);
            }
        }

    }
}
