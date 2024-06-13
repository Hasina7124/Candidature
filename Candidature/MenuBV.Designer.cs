namespace Candidature
{
    partial class MenuBV
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
            this.quitter = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.insertionvote = new System.Windows.Forms.Button();
            this.insertionbureauvote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultat = new System.Windows.Forms.Button();
            this.conteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.resultat);
            this.conteneur.Controls.Add(this.quitter);
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.insertionvote);
            this.conteneur.Controls.Add(this.insertionbureauvote);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Margin = new System.Windows.Forms.Padding(2);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 3;
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(692, 281);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(124, 33);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(43, 281);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(124, 33);
            this.retour.TabIndex = 3;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // insertionvote
            // 
            this.insertionvote.Location = new System.Drawing.Point(377, 148);
            this.insertionvote.Margin = new System.Windows.Forms.Padding(2);
            this.insertionvote.Name = "insertionvote";
            this.insertionvote.Size = new System.Drawing.Size(121, 45);
            this.insertionvote.TabIndex = 2;
            this.insertionvote.Text = "Insertion de Vote";
            this.insertionvote.UseVisualStyleBackColor = true;
            this.insertionvote.Click += new System.EventHandler(this.insertionvote_Click);
            // 
            // insertionbureauvote
            // 
            this.insertionbureauvote.Location = new System.Drawing.Point(343, 88);
            this.insertionbureauvote.Margin = new System.Windows.Forms.Padding(2);
            this.insertionbureauvote.Name = "insertionbureauvote";
            this.insertionbureauvote.Size = new System.Drawing.Size(187, 45);
            this.insertionbureauvote.TabIndex = 1;
            this.insertionbureauvote.Text = "Insertion Bureau de  Vote";
            this.insertionbureauvote.UseVisualStyleBackColor = true;
            this.insertionbureauvote.Click += new System.EventHandler(this.insertionbureauvote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU BUREAU DE VOTE";
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(377, 207);
            this.resultat.Margin = new System.Windows.Forms.Padding(2);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(121, 45);
            this.resultat.TabIndex = 5;
            this.resultat.Text = "Resultat";
            this.resultat.UseVisualStyleBackColor = true;
            this.resultat.Click += new System.EventHandler(this.resultat_Click);
            // 
            // MenuBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBV";
            this.Text = "MenuBV";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button insertionvote;
        private System.Windows.Forms.Button insertionbureauvote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button resultat;
    }
}