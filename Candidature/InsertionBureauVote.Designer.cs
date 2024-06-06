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
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertion = new System.Windows.Forms.Button();
            this.region = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom;";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(64, 93);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(163, 20);
            this.nom.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adresse";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(64, 142);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(205, 20);
            this.adresse.TabIndex = 30;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(64, 194);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(179, 20);
            this.ville.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ville";
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(688, 275);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(126, 38);
            this.insertion.TabIndex = 33;
            this.insertion.Text = "Insérer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(64, 243);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(163, 20);
            this.region.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Insértion bureau de vote";
            // 
            // InsertionBureauVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.region);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertion);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertionBureauVote";
            this.Text = "InsertionBureauVote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}