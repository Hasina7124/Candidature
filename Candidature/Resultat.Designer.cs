namespace Candidature
{
    partial class Resultat
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
            this.graphicsdisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picturecandidat = new System.Windows.Forms.PictureBox();
            this.displayresultat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturecandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.graphicsdisplay);
            this.conteneur.Controls.Add(this.button1);
            this.conteneur.Controls.Add(this.picturecandidat);
            this.conteneur.Controls.Add(this.displayresultat);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Controls.Add(this.quitter);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // graphicsdisplay
            // 
            this.graphicsdisplay.Location = new System.Drawing.Point(326, 284);
            this.graphicsdisplay.Name = "graphicsdisplay";
            this.graphicsdisplay.Size = new System.Drawing.Size(195, 29);
            this.graphicsdisplay.TabIndex = 33;
            this.graphicsdisplay.Text = "Sous Forme Graphique";
            this.graphicsdisplay.UseVisualStyleBackColor = true;
            this.graphicsdisplay.Click += new System.EventHandler(this.graphicsdisplay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picturecandidat
            // 
            this.picturecandidat.ErrorImage = null;
            this.picturecandidat.Image = global::Candidature.Properties.Resources.defaut;
            this.picturecandidat.InitialImage = null;
            this.picturecandidat.Location = new System.Drawing.Point(659, 77);
            this.picturecandidat.Name = "picturecandidat";
            this.picturecandidat.Size = new System.Drawing.Size(191, 177);
            this.picturecandidat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturecandidat.TabIndex = 31;
            this.picturecandidat.TabStop = false;
            // 
            // displayresultat
            // 
            this.displayresultat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.displayresultat.FullRowSelect = true;
            this.displayresultat.HideSelection = false;
            this.displayresultat.Location = new System.Drawing.Point(12, 100);
            this.displayresultat.Name = "displayresultat";
            this.displayresultat.Size = new System.Drawing.Size(619, 154);
            this.displayresultat.TabIndex = 30;
            this.displayresultat.UseCompatibleStateImageBehavior = false;
            this.displayresultat.View = System.Windows.Forms.View.Details;
            this.displayresultat.SelectedIndexChanged += new System.EventHandler(this.displayresultat_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rang";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 241;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Patie politique";
            this.columnHeader3.Width = 197;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vote obtenue";
            this.columnHeader4.Width = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "RESULTAT DE L\'ELECTIONS";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(692, 281);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(124, 33);
            this.quitter.TabIndex = 28;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // Resultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resultat";
            this.Text = "Resultat";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturecandidat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picturecandidat;
        private System.Windows.Forms.ListView displayresultat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button graphicsdisplay;
    }
}