namespace Candidature
{
    partial class InsertionCandidat
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
            this.label10 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.insertion = new System.Windows.Forms.Button();
            this.politique = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.autres = new System.Windows.Forms.RadioButton();
            this.feminin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.mascullin = new System.Windows.Forms.RadioButton();
            this.cin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datenaissance = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lieunaissance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenoms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parcourir = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackgroundImage = global::Candidature.Properties.Resources.vert;
            this.conteneur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conteneur.Controls.Add(this.quitter);
            this.conteneur.Controls.Add(this.label10);
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.insertion);
            this.conteneur.Controls.Add(this.politique);
            this.conteneur.Controls.Add(this.label9);
            this.conteneur.Controls.Add(this.autres);
            this.conteneur.Controls.Add(this.feminin);
            this.conteneur.Controls.Add(this.label8);
            this.conteneur.Controls.Add(this.mascullin);
            this.conteneur.Controls.Add(this.cin);
            this.conteneur.Controls.Add(this.label7);
            this.conteneur.Controls.Add(this.tel);
            this.conteneur.Controls.Add(this.label6);
            this.conteneur.Controls.Add(this.adresse);
            this.conteneur.Controls.Add(this.label5);
            this.conteneur.Controls.Add(this.datenaissance);
            this.conteneur.Controls.Add(this.label4);
            this.conteneur.Controls.Add(this.lieunaissance);
            this.conteneur.Controls.Add(this.label3);
            this.conteneur.Controls.Add(this.prenoms);
            this.conteneur.Controls.Add(this.label2);
            this.conteneur.Controls.Add(this.nom);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Controls.Add(this.parcourir);
            this.conteneur.Controls.Add(this.image);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Margin = new System.Windows.Forms.Padding(2);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(692, 281);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(124, 33);
            this.quitter.TabIndex = 26;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(641, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Insértion candidat";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(702, 167);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(105, 33);
            this.retour.TabIndex = 24;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(702, 116);
            this.insertion.Margin = new System.Windows.Forms.Padding(2);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(105, 33);
            this.insertion.TabIndex = 23;
            this.insertion.Text = "Inserer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // politique
            // 
            this.politique.Location = new System.Drawing.Point(362, 271);
            this.politique.Margin = new System.Windows.Forms.Padding(2);
            this.politique.Name = "politique";
            this.politique.Size = new System.Drawing.Size(234, 20);
            this.politique.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(359, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Partie politique";
            // 
            // autres
            // 
            this.autres.AutoSize = true;
            this.autres.BackColor = System.Drawing.Color.Transparent;
            this.autres.ForeColor = System.Drawing.Color.White;
            this.autres.Location = new System.Drawing.Point(178, 298);
            this.autres.Margin = new System.Windows.Forms.Padding(2);
            this.autres.Name = "autres";
            this.autres.Size = new System.Drawing.Size(55, 17);
            this.autres.TabIndex = 20;
            this.autres.TabStop = true;
            this.autres.Text = "Autres";
            this.autres.UseVisualStyleBackColor = false;
            // 
            // feminin
            // 
            this.feminin.AutoSize = true;
            this.feminin.BackColor = System.Drawing.Color.Transparent;
            this.feminin.ForeColor = System.Drawing.Color.White;
            this.feminin.Location = new System.Drawing.Point(102, 298);
            this.feminin.Margin = new System.Windows.Forms.Padding(2);
            this.feminin.Name = "feminin";
            this.feminin.Size = new System.Drawing.Size(61, 17);
            this.feminin.TabIndex = 19;
            this.feminin.TabStop = true;
            this.feminin.Text = "Feminin";
            this.feminin.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sexe";
            // 
            // mascullin
            // 
            this.mascullin.AutoSize = true;
            this.mascullin.BackColor = System.Drawing.Color.Transparent;
            this.mascullin.ForeColor = System.Drawing.Color.White;
            this.mascullin.Location = new System.Drawing.Point(22, 298);
            this.mascullin.Margin = new System.Windows.Forms.Padding(2);
            this.mascullin.Name = "mascullin";
            this.mascullin.Size = new System.Drawing.Size(69, 17);
            this.mascullin.TabIndex = 17;
            this.mascullin.TabStop = true;
            this.mascullin.Text = "Mascullin";
            this.mascullin.UseVisualStyleBackColor = false;
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(362, 225);
            this.cin.Margin = new System.Windows.Forms.Padding(2);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(234, 20);
            this.cin.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(359, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numéros CIN";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(362, 181);
            this.tel.Margin = new System.Windows.Forms.Padding(2);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(234, 20);
            this.tel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numéros téléphone";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(362, 137);
            this.adresse.Margin = new System.Windows.Forms.Padding(2);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(234, 20);
            this.adresse.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(359, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresse";
            // 
            // datenaissance
            // 
            this.datenaissance.Location = new System.Drawing.Point(362, 93);
            this.datenaissance.Margin = new System.Windows.Forms.Padding(2);
            this.datenaissance.Name = "datenaissance";
            this.datenaissance.Size = new System.Drawing.Size(176, 20);
            this.datenaissance.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(359, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date de naissance";
            // 
            // lieunaissance
            // 
            this.lieunaissance.Location = new System.Drawing.Point(362, 51);
            this.lieunaissance.Margin = new System.Windows.Forms.Padding(2);
            this.lieunaissance.Name = "lieunaissance";
            this.lieunaissance.Size = new System.Drawing.Size(176, 20);
            this.lieunaissance.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(359, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lieu de naissance";
            // 
            // prenoms
            // 
            this.prenoms.Location = new System.Drawing.Point(22, 253);
            this.prenoms.Margin = new System.Windows.Forms.Padding(2);
            this.prenoms.Name = "prenoms";
            this.prenoms.Size = new System.Drawing.Size(254, 20);
            this.prenoms.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenoms";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(22, 210);
            this.nom.Margin = new System.Windows.Forms.Padding(2);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(176, 20);
            this.nom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // parcourir
            // 
            this.parcourir.Location = new System.Drawing.Point(64, 162);
            this.parcourir.Margin = new System.Windows.Forms.Padding(2);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(63, 26);
            this.parcourir.TabIndex = 1;
            this.parcourir.Text = "Parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // image
            // 
            this.image.Image = global::Candidature.Properties.Resources.defaut;
            this.image.Location = new System.Drawing.Point(22, 11);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(158, 143);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // InsertionCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertionCandidat";
            this.Text = "Candidat";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prenoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datenaissance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lieunaissance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton autres;
        private System.Windows.Forms.RadioButton feminin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton mascullin;
        private System.Windows.Forms.TextBox politique;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button quitter;
    }
}