using Candidature.entité;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(nom.Text) ||
                string.IsNullOrWhiteSpace(prenoms.Text) ||
                string.IsNullOrWhiteSpace(lieunaissance.Text) ||
                string.IsNullOrWhiteSpace(adresse.Text) ||
                string.IsNullOrWhiteSpace(tel.Text) ||
                string.IsNullOrWhiteSpace(cin.Text) ||
                string.IsNullOrWhiteSpace(politique.Text) ||
                string.IsNullOrEmpty(image_))
            {
                MessageBox.Show("Tous les champs doivent être remplis et une image doit être sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification de la date de naissance (doit avoir au moins 30 ans)
            DateTime currentDate = DateTime.Now;
            DateTime minDateOfBirth = currentDate.AddYears(-30);
            if (datenaissance.Value > minDateOfBirth)
            {
                MessageBox.Show("La date de naissance doit correspondre à une personne d'au moins 30 ans.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification du CIN (doit contenir exactement 12 chiffres)
            if (!Regex.IsMatch(cin.Text, @"^\d{12}$"))
            {
                MessageBox.Show("Le CIN doit contenir exactement 12 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification du numéro de téléphone (format "033 33 333 33")
            if (!Regex.IsMatch(tel.Text, @"^033 \d{2} \d{3} \d{2}$"))
            {
                MessageBox.Show("Le numéro de téléphone doit suivre le format '033 33 333 33'.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string etat = "";

            Candidats candidats = new Candidats();

            candidats.nom = nom.Text;
            candidats.prenoms = prenoms.Text;
            candidats.sexe = (mascullin.Checked) ? "Mascullin" : (feminin.Checked) ? "Feminin" : "Non defini";
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
