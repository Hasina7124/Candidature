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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void candidat_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new CandidatForm(), conteneur);
        }

        private void listecandidat_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new InsertionBureauVote(), conteneur);
        }
    }
}
