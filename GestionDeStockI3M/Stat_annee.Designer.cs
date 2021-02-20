
namespace GestionDeStockI3M
{
    partial class Stat_annee
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.annee = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.Label();
            this.nb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_vente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prix_total = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search2 = new System.Windows.Forms.Button();
            this.comboBoxYear2 = new System.Windows.Forms.ComboBox();
            this.annee2 = new System.Windows.Forms.Label();
            this.chart_commande = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.commande = new System.Windows.Forms.Button();
            this.vente = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.perte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nb_com = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nb_commande = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_commande)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // annee
            // 
            this.annee.AutoSize = true;
            this.annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annee.Location = new System.Drawing.Point(26, 72);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(277, 20);
            this.annee.TabIndex = 37;
            this.annee.Text = "Choissisez l\'année que vous voulez   : ";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(309, 71);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(179, 21);
            this.comboBoxYear.TabIndex = 38;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Highlight;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Consolas", 12F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(543, 67);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(141, 30);
            this.search.TabIndex = 39;
            this.search.Text = "Chercher";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.Location = new System.Drawing.Point(308, 8);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(18, 20);
            this.des.TabIndex = 55;
            this.des.Text = "0";
            // 
            // gain
            // 
            this.gain.AutoSize = true;
            this.gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gain.Location = new System.Drawing.Point(308, 12);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(18, 20);
            this.gain.TabIndex = 53;
            this.gain.Text = "0";
            // 
            // nb
            // 
            this.nb.AutoSize = true;
            this.nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb.Location = new System.Drawing.Point(308, 8);
            this.nb.Name = "nb";
            this.nb.Size = new System.Drawing.Size(18, 20);
            this.nb.TabIndex = 52;
            this.nb.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nombre de produits déstockés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Le gain :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre de ventes:";
            // 
            // chart_vente
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_vente.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_vente.Legends.Add(legend3);
            this.chart_vente.Location = new System.Drawing.Point(16, 114);
            this.chart_vente.Name = "chart_vente";
            this.chart_vente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "ventes";
            series3.YValuesPerPoint = 4;
            this.chart_vente.Series.Add(series3);
            this.chart_vente.Size = new System.Drawing.Size(368, 351);
            this.chart_vente.TabIndex = 47;
            this.chart_vente.Text = "chart_nb_vente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search2);
            this.panel1.Controls.Add(this.comboBoxYear2);
            this.panel1.Controls.Add(this.annee2);
            this.panel1.Controls.Add(this.chart_commande);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 418);
            this.panel1.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.prix_total);
            this.panel4.Controls.Add(this.label13);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(18, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 43);
            this.panel4.TabIndex = 92;
            // 
            // prix_total
            // 
            this.prix_total.AutoSize = true;
            this.prix_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_total.Location = new System.Drawing.Point(308, 12);
            this.prix_total.Name = "prix_total";
            this.prix_total.Size = new System.Drawing.Size(18, 20);
            this.prix_total.TabIndex = 82;
            this.prix_total.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 20);
            this.label13.TabIndex = 78;
            this.label13.Text = "Le prix total des commande:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.prix);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(18, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 43);
            this.panel3.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 20);
            this.label14.TabIndex = 77;
            this.label14.Text = "Le  prix moyen des commandes :";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(309, 12);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(18, 20);
            this.prix.TabIndex = 81;
            this.prix.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel5.Controls.Add(this.nb_commande);
            this.panel5.Controls.Add(this.label15);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(18, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 43);
            this.panel5.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nb_com);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(18, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 43);
            this.panel2.TabIndex = 89;
            // 
            // search2
            // 
            this.search2.BackColor = System.Drawing.SystemColors.Highlight;
            this.search2.FlatAppearance.BorderSize = 0;
            this.search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search2.Font = new System.Drawing.Font("Consolas", 12F);
            this.search2.ForeColor = System.Drawing.Color.White;
            this.search2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search2.Location = new System.Drawing.Point(531, 16);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(141, 30);
            this.search2.TabIndex = 85;
            this.search2.Text = "Chercher";
            this.search2.UseVisualStyleBackColor = false;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // comboBoxYear2
            // 
            this.comboBoxYear2.FormattingEnabled = true;
            this.comboBoxYear2.Location = new System.Drawing.Point(297, 20);
            this.comboBoxYear2.Name = "comboBoxYear2";
            this.comboBoxYear2.Size = new System.Drawing.Size(174, 21);
            this.comboBoxYear2.TabIndex = 84;
            // 
            // annee2
            // 
            this.annee2.AutoSize = true;
            this.annee2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annee2.Location = new System.Drawing.Point(14, 21);
            this.annee2.Name = "annee2";
            this.annee2.Size = new System.Drawing.Size(277, 20);
            this.annee2.TabIndex = 83;
            this.annee2.Text = "Choissisez l\'année que vous voulez   : ";
            // 
            // chart_commande
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_commande.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_commande.Legends.Add(legend4);
            this.chart_commande.Location = new System.Drawing.Point(442, 55);
            this.chart_commande.Name = "chart_commande";
            this.chart_commande.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "commandes";
            series4.YValuesPerPoint = 6;
            this.chart_commande.Series.Add(series4);
            this.chart_commande.Size = new System.Drawing.Size(368, 350);
            this.chart_commande.TabIndex = 75;
            this.chart_commande.Text = "chart_commande";
            // 
            // commande
            // 
            this.commande.BackColor = System.Drawing.SystemColors.Highlight;
            this.commande.FlatAppearance.BorderSize = 0;
            this.commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commande.Font = new System.Drawing.Font("Consolas", 12F);
            this.commande.ForeColor = System.Drawing.Color.White;
            this.commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commande.Location = new System.Drawing.Point(454, 12);
            this.commande.Name = "commande";
            this.commande.Size = new System.Drawing.Size(141, 30);
            this.commande.TabIndex = 39;
            this.commande.Text = "Commande";
            this.commande.UseVisualStyleBackColor = false;
            this.commande.Click += new System.EventHandler(this.commande_Click);
            // 
            // vente
            // 
            this.vente.BackColor = System.Drawing.SystemColors.Highlight;
            this.vente.FlatAppearance.BorderSize = 0;
            this.vente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vente.Font = new System.Drawing.Font("Consolas", 12F);
            this.vente.ForeColor = System.Drawing.Color.White;
            this.vente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vente.Location = new System.Drawing.Point(243, 12);
            this.vente.Name = "vente";
            this.vente.Size = new System.Drawing.Size(141, 30);
            this.vente.TabIndex = 39;
            this.vente.Text = "Vente";
            this.vente.UseVisualStyleBackColor = false;
            this.vente.Click += new System.EventHandler(this.vente_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel6.Controls.Add(this.perte);
            this.panel6.Controls.Add(this.label3);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(400, 257);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 43);
            this.panel6.TabIndex = 61;
            // 
            // perte
            // 
            this.perte.AutoSize = true;
            this.perte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perte.Location = new System.Drawing.Point(308, 11);
            this.perte.Name = "perte";
            this.perte.Size = new System.Drawing.Size(18, 20);
            this.perte.TabIndex = 56;
            this.perte.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "La perte :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.gain);
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Location = new System.Drawing.Point(400, 198);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 43);
            this.panel7.TabIndex = 60;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.nb);
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(400, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 43);
            this.panel8.TabIndex = 59;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.des);
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Location = new System.Drawing.Point(400, 317);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(392, 43);
            this.panel9.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Nombre de commandes :";
            // 
            // nb_com
            // 
            this.nb_com.AutoSize = true;
            this.nb_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_com.Location = new System.Drawing.Point(312, 11);
            this.nb_com.Name = "nb_com";
            this.nb_com.Size = new System.Drawing.Size(18, 20);
            this.nb_com.TabIndex = 89;
            this.nb_com.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Nombre de produits en commande :";
            // 
            // nb_commande
            // 
            this.nb_commande.AutoSize = true;
            this.nb_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_commande.Location = new System.Drawing.Point(309, 10);
            this.nb_commande.Name = "nb_commande";
            this.nb_commande.Size = new System.Drawing.Size(18, 20);
            this.nb_commande.TabIndex = 80;
            this.nb_commande.Text = "0";
            // 
            // Stat_annee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_vente);
            this.Controls.Add(this.vente);
            this.Controls.Add(this.commande);
            this.Controls.Add(this.search);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.annee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stat_annee";
            this.Text = "Stat_annee";
            this.Load += new System.EventHandler(this.Stat_annee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_vente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_commande)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annee;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.Label gain;
        private System.Windows.Forms.Label nb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prix_total;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_commande;
        private System.Windows.Forms.Button commande;
        private System.Windows.Forms.Button vente;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.ComboBox comboBoxYear2;
        private System.Windows.Forms.Label annee2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label perte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label nb_commande;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nb_com;
    }
}