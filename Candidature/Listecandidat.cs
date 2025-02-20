﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Candidature.entité;
using MySql.Data.MySqlClient;

namespace Candidature
{
    public partial class Listecandidat : Form
    {
        //Id du candidats selectionner
        int id;
        //Chemin du candidat selectionner
        string pathimage;
        public Listecandidat()
        {
            InitializeComponent();

            Candidats candidats = new Candidats();
            //Inserer les numeros
            candidats.numero();
            //Afficher les candidats
            candidats.afficherlistecandidat(listcandidats);
        }
        
        private void modification_Click(object sender, EventArgs e)
        {
            if (listcandidats.SelectedItems.Count > 0)
            {
                Navigation navigation = new Navigation(new ModificationCandidats(id),conteneur);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le candidat à modifier");
            }
        }

        private void listcandidats_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listcandidats.SelectedItems.Count > 0)
            {
                int idCandidat = Convert.ToInt32(listcandidats.SelectedItems[0].Tag);
                id = idCandidat;


                Candidats candidats = new Candidats();
                pathimage = candidats.afficheimage(id);
                Image image = Image.FromFile(pathimage);
                imagecandidats.Image = image;
            }
        }
        
        private void suppression_Click(object sender, EventArgs e)
        {
            string etat;
            Candidats candidats = new Candidats();
            etat = candidats.supprimecandidat(id);
            listcandidats.Items.Clear();
            candidats.afficherlistecandidat(listcandidats);
            MessageBox.Show(etat);
            imagecandidats.Image = null;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation(new MenuCandidats(), conteneur);
        }
    }
}