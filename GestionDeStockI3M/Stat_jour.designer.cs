
namespace GestionDeStockI3M
{
    partial class Stat_jour
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
            this.label4 = new System.Windows.Forms.Label();
            this.chart_nb_vente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nb = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.Label();
            this.perte = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.achat = new System.Windows.Forms.Label();
            this.btnJour = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nb_vente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "choissisez la date du jour  que vous voulez    : ";
            // 
            // chart_nb_vente
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_nb_vente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_nb_vente.Legends.Add(legend1);
            this.chart_nb_vente.Location = new System.Drawing.Point(25, 84);
            this.chart_nb_vente.Name = "chart_nb_vente";
            this.chart_nb_vente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "ventes";
            series1.YValuesPerPoint = 4;
            this.chart_nb_vente.Series.Add(series1);
            this.chart_nb_vente.Size = new System.Drawing.Size(368, 361);
            this.chart_nb_vente.TabIndex = 23;
            this.chart_nb_vente.Text = "chart_nb_vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre de ventes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Le gain :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "La perte :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nombre de produits destockes :";
            // 
            // nb
            // 
            this.nb.AutoSize = true;
            this.nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb.ForeColor = System.Drawing.Color.Black;
            this.nb.Location = new System.Drawing.Point(330, 11);
            this.nb.Name = "nb";
            this.nb.Size = new System.Drawing.Size(18, 20);
            this.nb.TabIndex = 28;
            this.nb.Text = "0";
            // 
            // gain
            // 
            this.gain.AutoSize = true;
            this.gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gain.ForeColor = System.Drawing.Color.Black;
            this.gain.Location = new System.Drawing.Point(330, 11);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(18, 20);
            this.gain.TabIndex = 29;
            this.gain.Text = "0";
            // 
            // perte
            // 
            this.perte.AutoSize = true;
            this.perte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perte.ForeColor = System.Drawing.Color.Black;
            this.perte.Location = new System.Drawing.Point(330, 10);
            this.perte.Name = "perte";
            this.perte.Size = new System.Drawing.Size(18, 20);
            this.perte.TabIndex = 30;
            this.perte.Text = "0";
            this.perte.Click += new System.EventHandler(this.perte_Click);
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.Black;
            this.des.Location = new System.Drawing.Point(330, 11);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(18, 20);
            this.des.TabIndex = 31;
            this.des.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nombre d\'achats:";
            // 
            // achat
            // 
            this.achat.AutoSize = true;
            this.achat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achat.ForeColor = System.Drawing.Color.Black;
            this.achat.Location = new System.Drawing.Point(330, 13);
            this.achat.Name = "achat";
            this.achat.Size = new System.Drawing.Size(18, 20);
            this.achat.TabIndex = 33;
            this.achat.Text = "0";
            this.achat.Click += new System.EventHandler(this.achat_Click);
            // 
            // btnJour
            // 
            this.btnJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnJour.FlatAppearance.BorderSize = 0;
            this.btnJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJour.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnJour.ForeColor = System.Drawing.Color.Black;
            this.btnJour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJour.Location = new System.Drawing.Point(638, 41);
            this.btnJour.Name = "btnJour";
            this.btnJour.Size = new System.Drawing.Size(141, 30);
            this.btnJour.TabIndex = 34;
            this.btnJour.Text = "Chercher";
            this.btnJour.UseVisualStyleBackColor = false;
            this.btnJour.Click += new System.EventHandler(this.btnJour_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nb);
            this.panel1.Location = new System.Drawing.Point(420, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 43);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gain);
            this.panel2.Location = new System.Drawing.Point(420, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 43);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.perte);
            this.panel3.Location = new System.Drawing.Point(420, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 43);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.des);
            this.panel4.Location = new System.Drawing.Point(420, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 43);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.achat);
            this.panel5.Location = new System.Drawing.Point(420, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 43);
            this.panel5.TabIndex = 39;
            // 
            // Stat_jour
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJour);
            this.Controls.Add(this.chart_nb_vente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stat_jour";
            this.Text = "Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.chart_nb_vente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_nb_vente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nb;
        private System.Windows.Forms.Label gain;
        private System.Windows.Forms.Label perte;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label achat;
        private System.Windows.Forms.Button btnJour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}