using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidature
{
    public partial class MenuCandidats : Form
    {
        public MenuCandidats()
        {
            InitializeComponent();
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new InsertionCandidat(), conteneur);
        }

        private void listecandidat_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new Listecandidat(), conteneur);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new Acceuil(), conteneur);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Quitter quitter = new Quitter();
            Form Mere = quitter.FindTopLevelForm(this);
            if (Mere != null)
            {
                Mere.Close();
            }
        }
    }
}
