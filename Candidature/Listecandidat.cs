using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Candidature
{
    public partial class Listecandidat : Form
    {
        public Listecandidat()
        {
            InitializeComponent();
            numero();
            affichercandidat();
        }

        //Pour l'insertion des numeros
        public void numero()
        {
            string etat = "";

            Connexion conn = new Connexion();
            using (MySqlConnection connexion = conn.GetConnection())
            {
                connexion.Open();

                // Trouver le nombre de ligne
                string sql = "SELECT COUNT(id_candidat) FROM candidat";
                MySqlCommand command = new MySqlCommand(sql, connexion);

                try
                {
                    int countrow = Convert.ToInt32(command.ExecuteScalar());
                    if (countrow > 0)
                    {
                        HashSet<int> num = new HashSet<int>();
                        Random rand = new Random();
                        int min = 1;
                        int max = countrow + 1;

                        while (num.Count < countrow)
                        {
                            int random = rand.Next(min, max);
                            num.Add(random);
                        }
                        List<int> numlist = new List<int>(num);

                        sql = "UPDATE candidat SET numeros = @numeros WHERE id_candidat = @id";
                        MySqlCommand command1 = new MySqlCommand(sql, connexion);

                        string query = "SELECT id_candidat FROM candidat";
                        MySqlCommand command2 = new MySqlCommand(query, connexion);
                        MySqlDataReader reader = command2.ExecuteReader();
                        List<int> id = new List<int>();
                        while (reader.Read())
                        {
                            id.Add(reader.GetInt32(0));
                        }
                        reader.Close();

                        for (int i = 0; i < num.Count; i++)
                        {
                            command1.Parameters.Clear();
                            command1.Parameters.AddWithValue("@id", id[i]);
                            command1.Parameters.AddWithValue("@numeros", numlist[i]);
                            try
                            {
                                int rowsAffected = command1.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                etat = "Erreur: " + ex.Message;
                                MessageBox.Show(etat);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        //Afficher les candidats
        public void affichercandidat()
        {
            Connexion conn = new Connexion();
            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT nom, prenoms, numeros, politique FROM candidat";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem listView = new ListViewItem(reader[0].ToString());
                        listView.SubItems.Add(reader[1].ToString());
                        listView.SubItems.Add(reader[2].ToString());
                        listView.SubItems.Add(reader[3].ToString());
                        listcandidats.Items.Add(listView);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }
    }
}
