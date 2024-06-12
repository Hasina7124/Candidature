using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidature.entité
{
    internal class Vote
    {
        public int id_vote { get; set; }
        public int id_bvote { get; set; }
        public int id_cdt { get; set; }
        public int nbvote { get; set; }

        public string ajoutvote()
        {
            string etat = "";
            //Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();


            //Requête
            string sql = "INSERT INTO vote(id_bvote, id_cdt, nbvote) " +
                "VALUES (@id_bvote, @id_cdt, @nbvote)";

            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.Parameters.AddWithValue("@id_bvote", id_bvote);
            cmd.Parameters.AddWithValue("@id_cdt", id_cdt);
            cmd.Parameters.AddWithValue("@nbvote", nbvote);

            try
            {
                connexion.Open();
                cmd.ExecuteNonQuery();
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
