namespace Candidature
{
    partial class InsertionVote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.insertion = new System.Windows.Forms.Button();
            this.nbvote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nomcandidats = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombureauvote = new System.Windows.Forms.ComboBox();
            this.nomcdt = new System.Windows.Forms.Label();
            this.candidatimage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.panel1);
            this.conteneur.Controls.Add(this.comboBox1);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Controls.Add(this.pictureBox1);
            this.conteneur.Controls.Add(this.label5);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 325);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Candidature.Properties.Resources.rouge;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.quitter);
            this.panel2.Controls.Add(this.retour);
            this.panel2.Controls.Add(this.insertion);
            this.panel2.Controls.Add(this.nbvote);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nomcandidats);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nombureauvote);
            this.panel2.Controls.Add(this.nomcdt);
            this.panel2.Controls.Add(this.candidatimage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 325);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Image du candidat";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(692, 281);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(124, 33);
            this.quitter.TabIndex = 48;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(702, 167);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(105, 33);
            this.retour.TabIndex = 47;
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
            this.insertion.TabIndex = 46;
            this.insertion.Text = "Inserer";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // nbvote
            // 
            this.nbvote.Location = new System.Drawing.Point(12, 249);
            this.nbvote.Name = "nbvote";
            this.nbvote.Size = new System.Drawing.Size(138, 20);
            this.nbvote.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nombre de vote(s)";
            // 
            // nomcandidats
            // 
            this.nomcandidats.FormattingEnabled = true;
            this.nomcandidats.Location = new System.Drawing.Point(12, 163);
            this.nomcandidats.Name = "nomcandidats";
            this.nomcandidats.Size = new System.Drawing.Size(240, 21);
            this.nomcandidats.TabIndex = 43;
            this.nomcandidats.SelectedIndexChanged += new System.EventHandler(this.nomcandidats_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Candidats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Bureau de vote";
            // 
            // nombureauvote
            // 
            this.nombureauvote.FormattingEnabled = true;
            this.nombureauvote.Location = new System.Drawing.Point(12, 77);
            this.nombureauvote.Name = "nombureauvote";
            this.nombureauvote.Size = new System.Drawing.Size(240, 21);
            this.nombureauvote.TabIndex = 40;
            this.nombureauvote.SelectedIndexChanged += new System.EventHandler(this.nombureauvote_SelectedIndexChanged);
            // 
            // nomcdt
            // 
            this.nomcdt.AutoSize = true;
            this.nomcdt.Location = new System.Drawing.Point(380, 50);
            this.nomcdt.Name = "nomcdt";
            this.nomcdt.Size = new System.Drawing.Size(0, 13);
            this.nomcdt.TabIndex = 39;
            // 
            // candidatimage
            // 
            this.candidatimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.candidatimage.Location = new System.Drawing.Point(393, 89);
            this.candidatimage.Name = "candidatimage";
            this.candidatimage.Size = new System.Drawing.Size(157, 147);
            this.candidatimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candidatimage.TabIndex = 38;
            this.candidatimage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(632, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Insértion des votes";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 21);
            this.comboBox2.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(636, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 177);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Insértion des votes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(636, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 177);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Insértion des votes";
            // 
            // InsertionVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertionVote";
            this.Text = "InsertionVote";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nbvote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox nomcandidats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox nombureauvote;
        private System.Windows.Forms.Label nomcdt;
        private System.Windows.Forms.PictureBox candidatimage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.Label label4;
    }
}