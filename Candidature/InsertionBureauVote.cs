using Candidature.entité;
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
    public partial class InsertionBureauVote : Form
    {
        public InsertionBureauVote()
        {
            InitializeComponent();
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            string etat = "";
            BureauVote vote = new BureauVote();

            vote.nom = nom.Text;
            vote.adresse = adresse.Text;
            vote.ville = ville.Text;
            vote.region = region.Text;

            etat = vote.insertionbv();
            MessageBox.Show(etat);
        }
    }
}
