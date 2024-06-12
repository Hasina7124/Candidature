using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetWinform_30190_.Traitment
{
    internal class Quitter
    {
        //To find the top level form
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
