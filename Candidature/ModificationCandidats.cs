using Candidature.entité;
using MySql.Data.MySqlClient;
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

namespace Candidature
{
    public partial class ModificationCandidats : Form
    {
        int id;
        string image_;
        public ModificationCandidats(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //Initialiser les champs
        public void initialization(int id)
        {
            Candidats candidats = new Candidats(id);

            string pathimage;
            pathimage = candidats.image;

            if (candidats.sexe == "Mascullin")
            {
                mascullin.Checked = true;
            }
            else if (candidats.sexe == "Feminin")
            {
                feminin.Checked = true;
            }
            else
            {
                autres.Checked = true;
            }
            nom.Text = candidats.nom;
            prenom.Text = candidats.prenoms;
            lieunaissance.Text = candidats.lieunaissance;
            datenaissance.Value = candidats.datenaissance;
            adresse.Text = candidats.adresse;
            tel.Text = candidats.tel;
            cin.Text = candidats.cin;
            politique.Text = candidats.politique;

            Image image_ = Image.FromFile(pathimage);
            image.Image = image_;
        }

        private void ModificationCandidats_Load(object sender, EventArgs e)
        {
            initialization(id);
        }

        private void modification_Click(object sender, EventArgs e)
        {
            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(nom.Text) ||
                string.IsNullOrWhiteSpace(prenom.Text) ||
                string.IsNullOrWhiteSpace(lieunaissance.Text) ||
                string.IsNullOrWhiteSpace(adresse.Text) ||
                string.IsNullOrWhiteSpace(tel.Text) ||
                string.IsNullOrWhiteSpace(cin.Text) ||
                string.IsNullOrWhiteSpace(politique.Text) ||
                (image_ == null && image.Image == null))
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

            string etat;

            Candidats candidats = new Candidats(id);
            candidats.nom = nom.Text;
            candidats.prenoms = prenom.Text;
            candidats.sexe = (mascullin.Checked) ? "Mascullin" : (feminin.Checked) ? "Feminin" : "Non defini";
            candidats.lieunaissance = lieunaissance.Text;
            candidats.datenaissance = datenaissance.Value;
            candidats.adresse = adresse.Text;
            candidats.tel = tel.Text;
            candidats.cin = cin.Text;
            candidats.politique = politique.Text;
            if (image_ != null)
            {
                candidats.image = image_;
            }

            etat = candidats.Modifiecandidat();
            MessageBox.Show(etat);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new Listecandidat(), conteneur);
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
