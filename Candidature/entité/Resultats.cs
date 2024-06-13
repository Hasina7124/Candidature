using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Candidature.entité
{
    internal class Resultats
    {
        public string afficherresultat(ListView resultat)
        {
            string etat = "";
            int rang = 1;
            Connexion conn = new Connexion();
            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT candidat.nom AS candidat_nom, candidat.politique AS partie_politique," +
                        "SUM(vote.nbvote) AS total_nbvote, vote.id_cdt FROM vote INNER JOIN candidat ON vote.id_cdt = candidat.id_candidat " +
                        "INNER JOIN bureauvote ON vote.id_bvote = bureauvote.id_bv GROUP BY candidat.nom, candidat.politique,vote.id_cdt ORDER BY total_nbvote DESC;";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem listView = new ListViewItem(rang.ToString());
                        listView.SubItems.Add(reader[0].ToString());
                        listView.SubItems.Add(reader[1].ToString());
                        listView.SubItems.Add(reader[2].ToString());
                        listView.Tag = reader[3].ToString();
                        resultat.Items.Add(listView);
                        rang++;
                    }
                    reader.Close();
                }
                etat = "reussi";
            }
            catch (Exception ex)
            {
                etat = "erreur: "+ex.Message;
            }
            return etat;
        }
        public string afficherresultatchart(Chart chart)
        {
            string etat = "";
            Connexion conn = new Connexion();
            try
            {
                using (MySqlConnection connexion = conn.GetConnection())
                {
                    connexion.Open();
                    string sql = "SELECT candidat.nom AS candidat_nom, SUM(vote.nbvote) AS total_nbvote FROM vote INNER JOIN candidat ON vote.id_cdt = candidat.id_candidat " +
                        "INNER JOIN bureauvote ON vote.id_bvote = bureauvote.id_bv GROUP BY candidat.nom, candidat.politique,vote.id_cdt ORDER BY total_nbvote DESC;";

                    MySqlCommand command = new MySqlCommand(sql, connexion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["candidat_nom"].ToString();
                        int value = Convert.ToInt32(reader["total_nbvote"]);
                        chart.Series[0].Points.AddXY(name, value);
                    }
                    reader.Close();
                }
                etat = "reussi";
            }
            catch (Exception ex)
            {
                etat = "erreur: " + ex.Message;
            }
            return etat;
        }
    }
}
