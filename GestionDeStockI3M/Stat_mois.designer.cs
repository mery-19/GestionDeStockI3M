
namespace GestionDeStockI3M
{
    partial class Stat_mois
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
            this.chart_nb_vente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.cherch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.achat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.perte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nb_vente)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_nb_vente
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_nb_vente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_nb_vente.Legends.Add(legend1);
            this.chart_nb_vente.Location = new System.Drawing.Point(16, 80);
            this.chart_nb_vente.Name = "chart_nb_vente";
            this.chart_nb_vente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "ventes";
            series1.YValuesPerPoint = 4;
            this.chart_nb_vente.Series.Add(series1);
            this.chart_nb_vente.Size = new System.Drawing.Size(368, 364);
            this.chart_nb_vente.TabIndex = 24;
            this.chart_nb_vente.Text = "chart_nb_vente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.comboBox1.Location = new System.Drawing.Point(338, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxYears.Location = new System.Drawing.Point(338, 40);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(179, 21);
            this.comboBoxYears.TabIndex = 26;
            // 
            // cherch
            // 
            this.cherch.BackColor = System.Drawing.SystemColors.Highlight;
            this.cherch.FlatAppearance.BorderSize = 0;
            this.cherch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cherch.Font = new System.Drawing.Font("Consolas", 12F);
            this.cherch.ForeColor = System.Drawing.Color.White;
            this.cherch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cherch.Location = new System.Drawing.Point(561, 12);
            this.cherch.Name = "cherch";
            this.cherch.Size = new System.Drawing.Size(141, 30);
            this.cherch.TabIndex = 35;
            this.cherch.Text = "Chercher";
            this.cherch.UseVisualStyleBackColor = false;
            this.cherch.Click += new System.EventHandler(this.cherch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "choissisez le mois   que vous voulez    : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "choissisez l\'année également  ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.achat);
            this.panel5.Location = new System.Drawing.Point(402, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 43);
            this.panel5.TabIndex = 52;
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
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.des);
            this.panel4.Location = new System.Drawing.Point(402, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 43);
            this.panel4.TabIndex = 51;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.perte);
            this.panel3.Location = new System.Drawing.Point(402, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 43);
            this.panel3.TabIndex = 50;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gain);
            this.panel2.Location = new System.Drawing.Point(402, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 43);
            this.panel2.TabIndex = 49;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nb);
            this.panel1.Location = new System.Drawing.Point(402, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 43);
            this.panel1.TabIndex = 48;
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
            // Stat_mois
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cherch);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart_nb_vente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stat_mois";
            this.Text = "Stat_mois";
            this.Load += new System.EventHandler(this.Stat_mois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_nb_vente)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_nb_vente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button cherch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label achat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label perte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nb;
    }
}