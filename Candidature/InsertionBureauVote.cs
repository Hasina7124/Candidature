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
    public partial class InsertionBureauVote : Form
    {
        public InsertionBureauVote()
        {
            InitializeComponent();
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) ||
                string.IsNullOrWhiteSpace(adresse.Text) ||
                string.IsNullOrWhiteSpace(ville.Text) ||
                string.IsNullOrWhiteSpace(region.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string etat = "";
            BureauVote vote = new BureauVote();

            vote.nom = nom.Text;
            vote.adresse = adresse.Text;
            vote.ville = ville.Text;
            vote.region = region.Text;

            etat = vote.InsertionBv();
            MessageBox.Show(etat);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new MenuBV(), conteneur);
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
