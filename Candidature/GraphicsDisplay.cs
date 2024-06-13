using Candidature.entité;
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
    public partial class GraphicsDisplay : Form
    {
        public GraphicsDisplay()
        {
            InitializeComponent();
            affichercandidats();
        }

        public void affichercandidats()
        {
            Resultats resultat = new Resultats();
            resultat.afficherresultatchart(affichecandidat);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new Resultat(), conteneur);
        }

        private void quitter_Click(object sender, EventArgs e)
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
