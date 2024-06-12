using System;
using System.Windows.Forms;

namespace Candidature
{
    internal class Quitter
    {
        public Form FindTopLevelForm(Control control)
        {
            Form parentform = control.FindForm();
            while (parentform != null && parentform.Parent != null)
            {
                parentform = parentform.Parent.FindForm();
            }
            return parentform;
        }
    }
}