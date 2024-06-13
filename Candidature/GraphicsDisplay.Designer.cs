namespace Candidature
{
    partial class GraphicsDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.conteneur = new System.Windows.Forms.Panel();
            this.affichecandidat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affichecandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackgroundImage = global::Candidature.Properties.Resources.madagascar_flag_wrinkled_dark_background_3d_render;
            this.conteneur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conteneur.Controls.Add(this.quitter);
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.affichecandidat);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // affichecandidat
            // 
            chartArea4.Name = "ChartArea1";
            this.affichecandidat.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.affichecandidat.Legends.Add(legend4);
            this.affichecandidat.Location = new System.Drawing.Point(72, 13);
            this.affichecandidat.Name = "affichecandidat";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.affichecandidat.Series.Add(series4);
            this.affichecandidat.Size = new System.Drawing.Size(325, 300);
            this.affichecandidat.TabIndex = 31;
            this.affichecandidat.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "RESULTAT DE L\'ELECTIONS";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(597, 165);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(146, 33);
            this.quitter.TabIndex = 34;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(597, 115);
            this.retour.Margin = new System.Windows.Forms.Padding(2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(146, 33);
            this.retour.TabIndex = 33;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // GraphicsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphicsDisplay";
            this.Text = "GraphicsDisplay";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affichecandidat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart affichecandidat;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button retour;
    }
}