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
    public partial class MenuBV : Form
    {
        public MenuBV()
        {
            InitializeComponent();
        }

        private void insertionbureauvote_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new InsertionBureauVote(), conteneur);
        }

        private void insertionvote_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new InsertionVote(), conteneur);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new Acceuil(), conteneur);
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Quitter quitter = new Quitter();
            Form Mere = quitter.FindTopLevelForm(this);
            if (Mere != null)
            {
                Mere.Close();
            }
        }
    }
}
