﻿namespace Candidature
{
    partial class MenuCandidats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conteneur = new System.Windows.Forms.Panel();
            this.retour = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.listecandidat = new System.Windows.Forms.Button();
            this.insertion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackgroundImage = global::Candidature.Properties.Resources.madagascar_balloon;
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.Quitter);
            this.conteneur.Controls.Add(this.listecandidat);
            this.conteneur.Controls.Add(this.insertion);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Margin = new System.Windows.Forms.Padding(2);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 1;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(31, 287);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(121, 27);
            this.retour.TabIndex = 4;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(710, 287);
            this.Quitter.Margin = new System.Windows.Forms.Padding(2);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(121, 27);
            this.Quitter.TabIndex = 3;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // listecandidat
            // 
            this.listecandidat.Location = new System.Drawing.Point(377, 190);
            this.listecandidat.Margin = new System.Windows.Forms.Padding(2);
            this.listecandidat.Name = "listecandidat";
            this.listecandidat.Size = new System.Drawing.Size(121, 45);
            this.listecandidat.TabIndex = 2;
            this.listecandidat.Text = "Liste candidat";
            this.listecandidat.UseVisualStyleBackColor = true;
            this.listecandidat.Click += new System.EventHandler(this.listecandidat_Click);
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(377, 112);
            this.insertion.Margin = new System.Windows.Forms.Padding(2);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(121, 45);
            this.insertion.TabIndex = 1;
            this.insertion.Text = "Insérer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(356, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANDIDAT";
            // 
            // MenuCandidats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCandidats";
            this.Text = "Acceuil";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Button listecandidat;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button retour;
    }
}