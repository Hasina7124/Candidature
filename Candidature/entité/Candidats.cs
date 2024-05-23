using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidature.entité
{
    internal class Candidats : Personne
    {
        public Candidats(string nom, string prenoms, string sexe, string lieunaissance, DateTime datenaissance, 
            string adresse, string tel, string cin, string politique)
        {
            this.nom = nom;
            this.prenoms = prenoms;
            this.sexe = sexe;
            this.lieunaissance = lieunaissance;
            this.datenaissance = datenaissance;
            this.adresse = adresse;
            this.tel = tel;
            this.cin = cin;
            this.politique = politique;
        }

        //Pour l'ajout d'un candidat
        public void ajoutcandidat()
        {
            string sql = "INSERT INTO candidat";
        }
    }
}
