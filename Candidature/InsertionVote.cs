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
    public partial class InsertionVote : Form
    {
        public int idcandidats;
        public int idBureauVote;

        public InsertionVote()
        {
            InitializeComponent();
            bureauvote();
            candidats();
        }

        public void bureauvote()
        {
            BureauVote bureauVote = new BureauVote();
            bureauVote.GetBureauxVote();
            bureauVote.ChargerBureauxVoteDansComboBox(nombureauvote);
        }

        public void candidats()
        {
            Candidats candidats = new Candidats();
            candidats.GetCandidats();
            candidats.ChargerCandidatsDansComboBox(nomcandidats);
        }

        private void nombureauvote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nombureauvote.SelectedItem != null)
            {
                KeyValuePair<string, int> selectedItem = (KeyValuePair<string, int>)nombureauvote.SelectedItem;
                idBureauVote = selectedItem.Value;
            }
        }

        private void nomcandidats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nomcandidats.SelectedItem != null)
            {
                string image = "";
                KeyValuePair<string, int> selectedItem = (KeyValuePair<string, int>)nomcandidats.SelectedItem;
                idcandidats = selectedItem.Value;

                //Affiche l'image
                Candidats candidats = new Candidats();
                image = candidats.afficheimage(idcandidats);
                Image image_ = Image.FromFile(image);
                candidatimage.Image = image_;
            }
        }

        public string insertionVote()
        {
            Vote vote = new Vote();
            vote.id_bvote = idBureauVote;
            vote.id_cdt = idcandidats;
            vote.nbvote = int.Parse(nbvote.Text);

            return vote.ajoutvote();
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            //Vérification des champs vides et valeurs incorrectes
            if (nombureauvote.SelectedItem == null ||
                nomcandidats.SelectedItem == null ||
                string.IsNullOrWhiteSpace(nbvote.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Vérification que nbvote est un entier positif
            if (!int.TryParse(nbvote.Text, out int nbVoteValue) || nbVoteValue < 0)
            {
                MessageBox.Show("Le nombre de votes doit être un entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string etat = insertionVote();
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
