using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Candidature.entité
{
    internal class Candidats
    {
        //Pour l'ajout d'un candidat
        public string ajoutcandidat(string nom, string prenoms, string sexe, string lieunaissance, DateTime datenaissance,
            string adresse, string tel, string cin, string politique, string image)
        {
            string etat="";
            //Connexion
            Connexion conn = new Connexion();
            MySqlConnection connexion = conn.GetConnection();

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
    }
}
