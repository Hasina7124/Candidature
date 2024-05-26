namespace Candidature
{
    partial class Listecandidat
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
            this.suppression = new System.Windows.Forms.Button();
            this.modification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listescandidats = new System.Windows.Forms.ListBox();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.suppression);
            this.conteneur.Controls.Add(this.modification);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Controls.Add(this.listescandidats);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(1150, 400);
            this.conteneur.TabIndex = 0;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(953, 244);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(140, 41);
            this.retour.TabIndex = 27;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            // 
            // suppression
            // 
            this.suppression.Location = new System.Drawing.Point(953, 178);
            this.suppression.Name = "suppression";
            this.suppression.Size = new System.Drawing.Size(140, 41);
            this.suppression.TabIndex = 26;
            this.suppression.Text = "Supprimer";
            this.suppression.UseVisualStyleBackColor = true;
            // 
            // modification
            // 
            this.modification.Location = new System.Drawing.Point(953, 116);
            this.modification.Name = "modification";
            this.modification.Size = new System.Drawing.Size(140, 41);
            this.modification.TabIndex = 25;
            this.modification.Text = "Modification";
            this.modification.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTE CANDIDAT";
            // 
            // listescandidats
            // 
            this.listescandidats.FormattingEnabled = true;
            this.listescandidats.ItemHeight = 16;
            this.listescandidats.Location = new System.Drawing.Point(12, 76);
            this.listescandidats.Name = "listescandidats";
            this.listescandidats.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listescandidats.Size = new System.Drawing.Size(862, 308);
            this.listescandidats.TabIndex = 0;
            // 
            // Listecandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 400);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listecandidat";
            this.Text = "Listecandidat";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listescandidats;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button suppression;
        private System.Windows.Forms.Button modification;
    }
}