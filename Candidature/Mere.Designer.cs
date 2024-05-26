namespace Candidature
{
    partial class Mere
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
            this.listecandidat = new System.Windows.Forms.Button();
            this.insertion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.listecandidat);
            this.conteneur.Controls.Add(this.insertion);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(1150, 400);
            this.conteneur.TabIndex = 0;
            // 
            // listecandidat
            // 
            this.listecandidat.Location = new System.Drawing.Point(503, 234);
            this.listecandidat.Name = "listecandidat";
            this.listecandidat.Size = new System.Drawing.Size(161, 55);
            this.listecandidat.TabIndex = 2;
            this.listecandidat.Text = "Liste candidat";
            this.listecandidat.UseVisualStyleBackColor = true;
            this.listecandidat.Click += new System.EventHandler(this.listecandidat_Click);
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(503, 138);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(161, 55);
            this.insertion.TabIndex = 1;
            this.insertion.Text = "Insérer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERTION CANDIDAT";
            // 
            // Mere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 400);
            this.Controls.Add(this.conteneur);
            this.Name = "Mere";
            this.Text = "Master";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listecandidat;
        private System.Windows.Forms.Button insertion;
    }
}

