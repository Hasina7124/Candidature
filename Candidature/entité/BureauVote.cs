using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidature.entité
{
    internal class BureauVote
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string region { get; set; }

        public string ajoutbureauvote()
        {
            string etat = "";
            //Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();

            string insertbv = "INSERT INTO bureauvote(nom, adresse, ville, region) VALUES(@nom, @adresse, @ville, @region)";

            MySqlCommand cmdinsertbv = new MySqlCommand(insertbv, connexion);
            cmdinsertbv.Parameters.AddWithValue("@nom", nom);
            cmdinsertbv.Parameters.AddWithValue("@adresse", adresse);
            cmdinsertbv.Parameters.AddWithValue("@ville", ville);
            cmdinsertbv.Parameters.AddWithValue("@region", region);
            try
            {
                connexion.Open();
                cmdinsertbv.ExecuteNonQuery();
                etat = "Insertion réussi";
            }
            catch (Exception ex)
            {
                etat = "error" + ex.Message;
            }
            return etat;
        }
    }
}
