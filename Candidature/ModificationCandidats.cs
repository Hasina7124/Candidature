using Candidature.entité;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidature
{
    public partial class ModificationCandidats : Form
    {
        int id;
        public string pathimage_ { get; set; }
        public string nom_ { get; set; }
        public string prenoms_ { get; set; }
        public string sexe_ { get; set; }
        public string lieunaissance_ { get; set; }
        public string adresse_ { get; set; }
        public string tel_ { get; set; }
        public string cin_ { get; set; }
        public string politique_ { get; set; }
        public DateTime datenaissance_ { get; set; }

        public ModificationCandidats(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //Initialiser les champs
        public void initialization(int id)
        {
            Candidats candidats = new Candidats(id);
            candidats.initialisation();
            ModificationCandidats modification = candidats.initialisation();

            string pathimage;
            pathimage = modification.pathimage_;

            if(modification.sexe_ == "Mascullin")
            {
                mascullin.Checked = true;
            }
            else if(modification.sexe_ == "Feminin")
            {
                feminin.Checked = true;
            }
            else
            {
                autres.Checked = true;
            }
            nom.Text = modification.nom_;
            prenom.Text = modification.prenoms_;
            lieunaissance.Text = modification.lieunaissance_;
            datenaissance.Value = modification.datenaissance_;
            adresse.Text = modification.adresse_;
            tel.Text = modification.tel_;
            cin.Text = modification.cin_;
            politique.Text = modification.politique_;

            Image image_ = Image.FromFile(pathimage);
            image.Image = image_;
        }

        private void ModificationCandidats_Load(object sender, EventArgs e)
        {
            initialization(id);
        }
    }
}
