namespace GestionDeStockI3M
{
    partial class Ventes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventes));
            this.labelProduit = new System.Windows.Forms.Label();
            this.comboBox_prod = new System.Windows.Forms.ComboBox();
            this.labelQtAVendre = new System.Windows.Forms.Label();
            this.labelQtRestante = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxQtRestante = new System.Windows.Forms.TextBox();
            this.textBoxQtVendu = new System.Windows.Forms.TextBox();
            this.labelAjouterVente = new System.Windows.Forms.Label();
            this.labelListeDesVentes = new System.Windows.Forms.Label();
            this.dataGridViewVente = new System.Windows.Forms.DataGridView();
            this.labelPrixvente = new System.Windows.Forms.Label();
            this.textBoxPrixVente = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.id_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite_vendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelProduit.ForeColor = System.Drawing.Color.Black;
            this.labelProduit.Location = new System.Drawing.Point(7, 189);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(182, 15);
            this.labelProduit.TabIndex = 1;
            this.labelProduit.Text = "Séléctionnez un produit :";
            // 
            // comboBox_prod
            // 
            this.comboBox_prod.FormattingEnabled = true;
            this.comboBox_prod.Location = new System.Drawing.Point(190, 187);
            this.comboBox_prod.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_prod.Name = "comboBox_prod";
            this.comboBox_prod.Size = new System.Drawing.Size(185, 21);
            this.comboBox_prod.TabIndex = 2;
            this.comboBox_prod.SelectedIndexChanged += new System.EventHandler(this.comboBox_prod_SelectedIndexChanged);
            // 
            // labelQtAVendre
            // 
            this.labelQtAVendre.AutoSize = true;
            this.labelQtAVendre.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelQtAVendre.ForeColor = System.Drawing.Color.Black;
            this.labelQtAVendre.Location = new System.Drawing.Point(25, 355);
            this.labelQtAVendre.Name = "labelQtAVendre";
            this.labelQtAVendre.Size = new System.Drawing.Size(140, 15);
            this.labelQtAVendre.TabIndex = 3;
            this.labelQtAVendre.Text = "Quantité à vendre :";
            // 
            // labelQtRestante
            // 
            this.labelQtRestante.AutoSize = true;
            this.labelQtRestante.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelQtRestante.ForeColor = System.Drawing.Color.Black;
            this.labelQtRestante.Location = new System.Drawing.Point(25, 280);
            this.labelQtRestante.Name = "labelQtRestante";
            this.labelQtRestante.Size = new System.Drawing.Size(140, 15);
            this.labelQtRestante.TabIndex = 4;
            this.labelQtRestante.Text = "Quantité restante :";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnValider.Location = new System.Drawing.Point(131, 224);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(88, 26);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.buttonAjouter.Location = new System.Drawing.Point(49, 393);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(88, 28);
            this.buttonAjouter.TabIndex = 5;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxQtRestante
            // 
            this.textBoxQtRestante.Location = new System.Drawing.Point(196, 276);
            this.textBoxQtRestante.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxQtRestante.Name = "textBoxQtRestante";
            this.textBoxQtRestante.Size = new System.Drawing.Size(91, 22);
            this.textBoxQtRestante.TabIndex = 6;
            // 
            // textBoxQtVendu
            // 
            this.textBoxQtVendu.Location = new System.Drawing.Point(196, 348);
            this.textBoxQtVendu.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxQtVendu.Name = "textBoxQtVendu";
            this.textBoxQtVendu.Size = new System.Drawing.Size(91, 22);
            this.textBoxQtVendu.TabIndex = 6;
            this.textBoxQtVendu.TextChanged += new System.EventHandler(this.textBoxQtVendu_TextChanged);
            // 
            // labelAjouterVente
            // 
            this.labelAjouterVente.AutoSize = true;
            this.labelAjouterVente.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.labelAjouterVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelAjouterVente.Location = new System.Drawing.Point(12, 126);
            this.labelAjouterVente.Name = "labelAjouterVente";
            this.labelAjouterVente.Size = new System.Drawing.Size(180, 22);
            this.labelAjouterVente.TabIndex = 7;
            this.labelAjouterVente.Text = "Ajouter une vente";
            // 
            // labelListeDesVentes
            // 
            this.labelListeDesVentes.AutoSize = true;
            this.labelListeDesVentes.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.labelListeDesVentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelListeDesVentes.Location = new System.Drawing.Point(377, 46);
            this.labelListeDesVentes.Name = "labelListeDesVentes";
            this.labelListeDesVentes.Size = new System.Drawing.Size(170, 22);
            this.labelListeDesVentes.TabIndex = 7;
            this.labelListeDesVentes.Text = "Liste des ventes";
            // 
            // dataGridViewVente
            // 
            this.dataGridViewVente.AllowUserToAddRows = false;
            this.dataGridViewVente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewVente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dataGridViewVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vente,
            this.Id_Produit,
            this.date_ajout,
            this.quantite_vendu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVente.Location = new System.Drawing.Point(381, 83);
            this.dataGridViewVente.Name = "dataGridViewVente";
            this.dataGridViewVente.ReadOnly = true;
            this.dataGridViewVente.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewVente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVente.Size = new System.Drawing.Size(454, 320);
            this.dataGridViewVente.TabIndex = 8;
            this.dataGridViewVente.Text = "dataGridView1";
            // 
            // labelPrixvente
            // 
            this.labelPrixvente.AutoSize = true;
            this.labelPrixvente.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelPrixvente.ForeColor = System.Drawing.Color.Black;
            this.labelPrixvente.Location = new System.Drawing.Point(25, 315);
            this.labelPrixvente.Name = "labelPrixvente";
            this.labelPrixvente.Size = new System.Drawing.Size(112, 15);
            this.labelPrixvente.TabIndex = 4;
            this.labelPrixvente.Text = "Prix de Vente :";
            // 
            // textBoxPrixVente
            // 
            this.textBoxPrixVente.Location = new System.Drawing.Point(196, 313);
            this.textBoxPrixVente.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPrixVente.Name = "textBoxPrixVente";
            this.textBoxPrixVente.Size = new System.Drawing.Size(91, 22);
            this.textBoxPrixVente.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(196, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(615, 443);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(220, 39);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Exporter la liste";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // id_vente
            // 
            this.id_vente.DataPropertyName = "id_vente";
            this.id_vente.HeaderText = "id_vente";
            this.id_vente.Name = "id_vente";
            this.id_vente.ReadOnly = true;
            // 
            // Id_Produit
            // 
            this.Id_Produit.DataPropertyName = "id_produit";
            this.Id_Produit.HeaderText = "Id du Produit";
            this.Id_Produit.Name = "Id_Produit";
            this.Id_Produit.ReadOnly = true;
            // 
            // date_ajout
            // 
            this.date_ajout.DataPropertyName = "date_ajout";
            this.date_ajout.HeaderText = "Date de Vente";
            this.date_ajout.Name = "date_ajout";
            this.date_ajout.ReadOnly = true;
            // 
            // quantite_vendu
            // 
            this.quantite_vendu.DataPropertyName = "quantite_vendu";
            this.quantite_vendu.HeaderText = "Quantite Vendu";
            this.quantite_vendu.Name = "quantite_vendu";
            this.quantite_vendu.ReadOnly = true;
            // 
            // Ventes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 649);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dataGridViewVente);
            this.Controls.Add(this.labelListeDesVentes);
            this.Controls.Add(this.labelAjouterVente);
            this.Controls.Add(this.textBoxQtVendu);
            this.Controls.Add(this.textBoxPrixVente);
            this.Controls.Add(this.textBoxQtRestante);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.labelPrixvente);
            this.Controls.Add(this.labelQtRestante);
            this.Controls.Add(this.labelQtAVendre);
            this.Controls.Add(this.comboBox_prod);
            this.Controls.Add(this.labelProduit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventes";
            this.Text = "Ventes";
            this.Load += new System.EventHandler(this.Ventes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.ComboBox comboBox_prod;
        private System.Windows.Forms.Label labelQtAVendre;
        private System.Windows.Forms.Label labelQtRestante;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxQtRestante;
        private System.Windows.Forms.TextBox textBoxQtVendu;
        private System.Windows.Forms.Label labelAjouterVente;
        private System.Windows.Forms.Label labelListeDesVentes;
        public System.Windows.Forms.DataGridView dataGridViewVente;
        private System.Windows.Forms.Label labelPrixvente;
        private System.Windows.Forms.TextBox textBoxPrixVente;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ajout;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite_vendu;
    }
}