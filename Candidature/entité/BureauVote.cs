using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Candidature.entité
{
    internal class BureauVote
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string region { get; set; }

        public string InsertionBv()
        {
            string etat = "";
            // Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();

            string insertBv = "INSERT INTO bureauvote(nom, adresse, ville, region) VALUES(@nom, @adresse, @ville, @region)";

            MySqlCommand cmdInsertBv = new MySqlCommand(insertBv, connexion);
            cmdInsertBv.Parameters.AddWithValue("@nom", nom);
            cmdInsertBv.Parameters.AddWithValue("@adresse", adresse);
            cmdInsertBv.Parameters.AddWithValue("@ville", ville);
            cmdInsertBv.Parameters.AddWithValue("@region", region);
            try
            {
                connexion.Open();
                cmdInsertBv.ExecuteNonQuery();
                etat = "Insertion réussie";
            }
            catch (Exception ex)
            {
                etat = "Erreur : " + ex.Message;
            }
            return etat;
        }

        public List<KeyValuePair<string, int>> GetBureauxVote()
        {
            List<KeyValuePair<string, int>> bureauxVote = new List<KeyValuePair<string, int>>();
            Connexion conn = new Connexion();

            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT nom, adresse, id_bv FROM bureauvote";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nomBureau = reader.GetString(0);
                            string adresseBureau = reader.GetString(1);
                            int idBureau = reader.GetInt32(2);
                            bureauxVote.Add(new KeyValuePair<string, int>($"{nomBureau} - {adresseBureau}", idBureau));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return bureauxVote;
        }

        public void ChargerBureauxVoteDansComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            List<KeyValuePair<string, int>> bureauxVote = GetBureauxVote();
            foreach (KeyValuePair<string, int> bureau in bureauxVote)
            {
                comboBox.Items.Add(bureau);
            }
        }
    }
}
