namespace Candidature
{
    partial class Acceuil
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
            this.button1 = new System.Windows.Forms.Button();
            this.listecandidat = new System.Windows.Forms.Button();
            this.candidat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.button1);
            this.conteneur.Controls.Add(this.listecandidat);
            this.conteneur.Controls.Add(this.candidat);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Margin = new System.Windows.Forms.Padding(2);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listecandidat
            // 
            this.listecandidat.Location = new System.Drawing.Point(377, 172);
            this.listecandidat.Margin = new System.Windows.Forms.Padding(2);
            this.listecandidat.Name = "listecandidat";
            this.listecandidat.Size = new System.Drawing.Size(121, 45);
            this.listecandidat.TabIndex = 2;
            this.listecandidat.Text = "Bureau Vote";
            this.listecandidat.UseVisualStyleBackColor = true;
            this.listecandidat.Click += new System.EventHandler(this.listecandidat_Click);
            // 
            // candidat
            // 
            this.candidat.Location = new System.Drawing.Point(377, 100);
            this.candidat.Margin = new System.Windows.Forms.Padding(2);
            this.candidat.Name = "candidat";
            this.candidat.Size = new System.Drawing.Size(121, 45);
            this.candidat.TabIndex = 1;
            this.candidat.Text = "Candidat";
            this.candidat.UseVisualStyleBackColor = true;
            this.candidat.Click += new System.EventHandler(this.candidat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELECTION PRESIDENTIELLE";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.Text = "Accuil";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Button listecandidat;
        private System.Windows.Forms.Button candidat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}