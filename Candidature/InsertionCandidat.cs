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
            string nom_ = nom.Text;
            string prenoms_ = prenoms.Text;
            string sexe = (mascullin.Checked) ? "Mascullin" : (feminin.Checked) ? "Feminin":"Non defini";
            string lieunaissance_ = lieunaissance.Text;
            DateTime datenaissance_ = datenaissance.Value;
            string adresse_ = adresse.Text;
            string tel_ = tel.Text;
            string cin_ = cin.Text;
            string politique_ = politique.Text;
            Candidats candidats = new Candidats();
            etat = candidats.ajoutcandidat(nom_, prenoms_, sexe, lieunaissance_, datenaissance_, adresse_, tel_, cin_, politique_, image_);
            MessageBox.Show(etat);
        }
    }
}
