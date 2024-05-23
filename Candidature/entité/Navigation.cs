using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidature
{
    internal class Navigation
    {
        public Navigation(Form form, Panel conteneur)
        {
            //Clear container contents
            conteneur.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            conteneur.Controls.Add(form);

            form.BringToFront();
            form.Show();
        }
    }
}
