namespace Candidature
{
    partial class InsertionBureauVote
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
            this.quitter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertion = new System.Windows.Forms.Button();
            this.ville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackColor = System.Drawing.Color.Transparent;
            this.conteneur.BackgroundImage = global::Candidature.Properties.Resources.blanc;
            this.conteneur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.quitter);
            this.conteneur.Controls.Add(this.label5);
            this.conteneur.Controls.Add(this.region);
            this.conteneur.Controls.Add(this.label3);
            this.conteneur.Controls.Add(this.insertion);
            this.conteneur.Controls.Add(this.ville);
            this.conteneur.Controls.Add(this.label4);
            this.conteneur.Controls.Add(this.adresse);
            this.conteneur.Controls.Add(this.label2);
            this.conteneur.Controls.Add(this.nom);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(402, 281);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(124, 33);
            this.retour.TabIndex = 50;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(692, 281);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(124, 33);
            this.quitter.TabIndex = 49;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Insértion bureau de vote";
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(64, 226);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(196, 20);
            this.region.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Region";
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(81, 281);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(124, 33);
            this.insertion.TabIndex = 45;
            this.insertion.Text = "Insérer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(64, 177);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(196, 20);
            this.ville.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ville";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(64, 125);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(283, 20);
            this.adresse.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Adresse";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(64, 76);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(222, 20);
            this.nom.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nom;";
            // 
            // InsertionBureauVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertionBureauVote";
            this.Text = "InsertionBureauVote";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
    }
}