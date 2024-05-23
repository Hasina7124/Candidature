using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Candidature
{
    internal class Connexion
    {
        MySqlConnection connection;
        public Connexion()
        {
            string etat;
            string connexion = "Server=localhost; port=3306; Database=candidature; user=root; password=";
            MySqlConnection mySqlConnection = null;
            try
            {
                mySqlConnection = new MySqlConnection(connexion);
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                etat = "Erreur: "+ex.Message;
            }
            this.connection = mySqlConnection;
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
