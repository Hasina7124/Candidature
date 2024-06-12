using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidature.entité
{
    internal class Resultat
    {
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
    }
}
