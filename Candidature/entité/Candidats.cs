using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Candidature.entité
{
    internal class Candidats
    {
        public string nom { get; set; }
        public string prenoms { get; set; }
        public string sexe { get; set; }
        public string lieunaissance { get; set; }
        public DateTime datenaissance { get; set; }
        public string adresse { get; set; }
        public string tel { get; set; }
        public string cin { get; set; }
        public string politique { get; set; }
        public string image { get; set; }


        int id;

        public Candidats(int id)
        {
            initialisation(id);
            this.id = id;
        }

        public Candidats() { }

        //Pour l'ajout d'un candidat
        public string ajoutcandidat(string nom, string prenoms, string sexe, string lieunaissance, DateTime datenaissance,
            string adresse, string tel, string cin, string politique, string image)
        {
            string etat="";
            //Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();
            connexion.Open();

            //Requête
            string sql = "INSERT INTO candidat(nom, prenoms, image, sexe, lieunaissance, datenaissance, adresse, tel, cin,politique) " +
                "VALUES (@nom, @prenoms, @image, @sexe, @lieunaissance, @datenaissance, @adresse, @tel, @cin, @politique)";

            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenoms", prenoms);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@sexe", sexe);
            cmd.Parameters.AddWithValue("@lieunaissance", lieunaissance);
            cmd.Parameters.AddWithValue("@datenaissance", datenaissance);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@politique", politique);
            try
            {
                cmd.ExecuteNonQuery();
                etat = "Insertion réussi";
            }catch (Exception ex)
            {
                etat = "error"+ex.Message;
            }
            return etat;
        }

        //Pour l'insertion des numeros
        public string numero()
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
                                etat = "reussi";
                            }
                            catch (Exception ex)
                            {
                                etat = "Erreur: " + ex.Message;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    etat = "Erreur: " + ex.Message;
                }
                return etat;
            }
        }

        //Afficher les candidats
        public string afficherlistecandidat(ListView listecandidat)
        {
            string etat = "";

            Connexion conn = new Connexion();
            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT nom, prenoms, numeros, politique, id_candidat FROM candidat";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem listView = new ListViewItem(reader[0].ToString());
                        listView.SubItems.Add(reader[1].ToString());
                        listView.SubItems.Add(reader[2].ToString());
                        listView.SubItems.Add(reader[3].ToString());
                        listView.Tag = reader[4].ToString();
                        listecandidat.Items.Add(listView);
                    }
                    reader.Close();
                }
                etat = "reussi";
            }
            catch (Exception ex)
            {
                etat = "erreur";
            }
            return etat;
        }

        //Initialiser la modification
        public ModificationCandidats initialisation(int id)
        {
            ModificationCandidats modification = new ModificationCandidats(id);

            Connexion conn = new Connexion();
            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT image,nom,prenoms,sexe,lieunaissance,datenaissance,adresse,tel,cin,politique FROM candidat WHERE id_candidat = @id";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    command.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        image = reader.GetString(0);
                        nom = reader.GetString(1);
                        prenoms = reader.GetString(2);
                        sexe = reader.GetString(3);
                        lieunaissance = reader.GetString(4);
                        datenaissance = reader.GetDateTime(5);
                        adresse = reader.GetString(6);
                        tel = reader.GetString(7);
                        cin = reader.GetString(8);
                        politique = reader.GetString(9);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            return modification;
        }

        //Pour l'ajout d'un candidat
        public string Modifiecandidat()
        {
            string etat = "";
            //Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();
            connexion.Open();

            //Requête
            string sql = "UPDATE candidat SET nom=@nom, prenoms=@prenoms, image=@image, sexe=@sexe, lieunaissance=@lieunaissance, datenaissance=@datenaissance, adresse=@adresse, tel=@tel, cin=@cin, politique=@politique WHERE id_candidat=@id";

            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenoms", prenoms);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@sexe", sexe);
            cmd.Parameters.AddWithValue("@lieunaissance", lieunaissance);
            cmd.Parameters.AddWithValue("@datenaissance", datenaissance);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@politique", politique);
            try
            {
                cmd.ExecuteNonQuery();
                etat = "Modification réussi";
            }
            catch (Exception ex)
            {
                etat = "error" + ex.Message;
            }
            return etat;
        }
    }
}
