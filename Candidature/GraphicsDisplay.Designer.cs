﻿namespace Candidature
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.conteneur = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.affichecandidat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affichecandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.affichecandidat);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(862, 325);
            this.conteneur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "RESULTAT DE L\'ELECTIONS";
            // 
            // affichecandidat
            // 
            chartArea1.Name = "ChartArea1";
            this.affichecandidat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.affichecandidat.Legends.Add(legend1);
            this.affichecandidat.Location = new System.Drawing.Point(79, 13);
            this.affichecandidat.Name = "affichecandidat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.affichecandidat.Series.Add(series1);
            this.affichecandidat.Size = new System.Drawing.Size(325, 300);
            this.affichecandidat.TabIndex = 31;
            this.affichecandidat.Text = "chart1";
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
    }
}