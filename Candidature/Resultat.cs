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
    public partial class Resultat : Form
    {
        public Resultat()
        {
            InitializeComponent();
            afficheresultat();
        }

        public void afficheresultat()
        {
            Resultats resultats = new Resultats();
            resultats.afficherresultat(displayresultat);

        }

        private void displayresultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayresultat.SelectedItems.Count > 0)
            {
                int idCandidat = Convert.ToInt32(displayresultat.SelectedItems[0].Tag);

                string pathimage ="";
                Candidats candidats = new Candidats();
                pathimage = candidats.afficheimage(idCandidat);
                Image image = Image.FromFile(pathimage);
                picturecandidat.Image = image;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new MenuBV(), conteneur);
        }

        private void graphicsdisplay_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new GraphicsDisplay(), conteneur);

        }
    }
}
