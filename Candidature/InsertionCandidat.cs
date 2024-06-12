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
using System.IO;

namespace Candidature
{
    public partial class InsertionCandidat : Form
    {
        string image_;
        public InsertionCandidat()
        {
            InitializeComponent();
        }

        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                image.ImageLocation = openFileDialog.FileName;
                image_ = openFileDialog.FileName;
            }
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            string etat;

            Candidats candidats = new Candidats();

            candidats.nom = nom.Text;
            candidats.prenoms = prenoms.Text;
            candidats.sexe = (mascullin.Checked) ? "Mascullin" : (feminin.Checked) ? "Feminin":"Non defini";
            candidats.lieunaissance = lieunaissance.Text;
            candidats.datenaissance = datenaissance.Value;
            candidats.adresse = adresse.Text;
            candidats.tel = tel.Text;
            candidats.cin = cin.Text;
            candidats.politique = politique.Text;
            candidats.image = image_;

            etat = candidats.ajoutcandidat();
            MessageBox.Show(etat);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new MenuCandidats(), conteneur);
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
