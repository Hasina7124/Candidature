using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Candidature.entité;
using MySql.Data.MySqlClient;

namespace Candidature
{
    public partial class Listecandidat : Form
    {
        int id;
        string pathimage;
        public Listecandidat()
        {
            InitializeComponent();

            Candidats candidats = new Candidats();
            candidats.numero();
            candidats.afficherlistecandidat(listcandidats);
        }

        private void modification_Click(object sender, EventArgs e)
        {
            if (listcandidats.SelectedItems.Count > 0)
            {
                Navigation navigation = new Navigation(new ModificationCandidats(id),conteneur);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le candidat à modifier");
            }
        }

        private void listcandidats_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listcandidats.SelectedItems.Count > 0)
            {
                int idCandidat = Convert.ToInt32(listcandidats.SelectedItems[0].Tag);
                id = idCandidat;

                Connexion conn = new Connexion();
                try
                {
                    using (MySqlConnection connexion = conn.GetConnection())
                    {
                        connexion.Open();
                        string sql = "SELECT image FROM candidat";

                        MySqlCommand command = new MySqlCommand(sql, connexion);
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            pathimage = reader.GetString(0);
                        }
                        Image image = Image.FromFile(pathimage);
                        imagecandidats.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }
    }
}
