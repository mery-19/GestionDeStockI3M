namespace GestionDeStockI3M
{
    partial class Produits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produits));
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.comboBoxFiltrage = new System.Windows.Forms.ComboBox();
            this.id_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProduits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(314, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 39);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnAfficher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficher.Location = new System.Drawing.Point(681, 12);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(119, 39);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(430, 12);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(123, 39);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(559, 12);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(116, 39);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(262, 76);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(200, 22);
            this.textBoxRecherche.TabIndex = 5;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.White;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnRechercher.Image")));
            this.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.Location = new System.Drawing.Point(478, 66);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(128, 39);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(569, 529);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(220, 39);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Exporter la liste";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnFiltrer.FlatAppearance.BorderSize = 0;
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrer.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnFiltrer.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrer.Location = new System.Drawing.Point(492, 119);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(86, 39);
            this.btnFiltrer.TabIndex = 4;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // comboBoxFiltrage
            // 
            this.comboBoxFiltrage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxFiltrage.FormattingEnabled = true;
            this.comboBoxFiltrage.Items.AddRange(new object[] {
            "Tous les produits",
            "Produits disponibles",
            "Produits non disponibles",
            "Produits déstockés"});
            this.comboBoxFiltrage.Location = new System.Drawing.Point(262, 130);
            this.comboBoxFiltrage.Name = "comboBoxFiltrage";
            this.comboBoxFiltrage.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFiltrage.TabIndex = 8;
            // 
            // id_produit
            // 
            this.id_produit.DataPropertyName = "id_produit";
            this.id_produit.HeaderText = "ID";
            this.id_produit.Name = "id_produit";
            this.id_produit.ReadOnly = true;
            this.id_produit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_produit.Visible = false;
            // 
            // id_fournisseur
            // 
            this.id_fournisseur.DataPropertyName = "id_fournisseur";
            this.id_fournisseur.HeaderText = "ID Fournisseur";
            this.id_fournisseur.Name = "id_fournisseur";
            this.id_fournisseur.ReadOnly = true;
            this.id_fournisseur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_fournisseur.Visible = false;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // prix_vente
            // 
            this.prix_vente.DataPropertyName = "prix_vente";
            this.prix_vente.HeaderText = "Prix de vente";
            this.prix_vente.Name = "prix_vente";
            this.prix_vente.ReadOnly = true;
            this.prix_vente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.Visible = false;
            // 
            // date_expiration
            // 
            this.date_expiration.DataPropertyName = "date_expiration";
            this.date_expiration.HeaderText = "Date d\'expiration";
            this.date_expiration.Name = "date_expiration";
            this.date_expiration.ReadOnly = true;
            this.date_expiration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // date_ajout
            // 
            this.date_ajout.DataPropertyName = "date_ajout";
            this.date_ajout.HeaderText = "Date d\'ajout";
            this.date_ajout.Name = "date_ajout";
            this.date_ajout.ReadOnly = true;
            this.date_ajout.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_ajout.Visible = false;
            // 
            // dataGridProduits
            // 
            this.dataGridProduits.AllowUserToAddRows = false;
            this.dataGridProduits.AllowUserToDeleteRows = false;
            this.dataGridProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dataGridProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produit,
            this.id_fournisseur,
            this.nom,
            this.prix_vente,
            this.quantite,
            this.image,
            this.date_expiration,
            this.date_ajout});
            this.dataGridProduits.Location = new System.Drawing.Point(29, 183);
            this.dataGridProduits.Name = "dataGridProduits";
            this.dataGridProduits.ReadOnly = true;
            this.dataGridProduits.RowHeadersWidth = 62;
            this.dataGridProduits.Size = new System.Drawing.Size(760, 320);
            this.dataGridProduits.TabIndex = 6;
            this.dataGridProduits.Text = "dataGridView1";
            this.dataGridProduits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduits_CellClick);
            this.dataGridProduits.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridProduits_DataBindingComplete);
            // 
            // Produits
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 649);
            this.Controls.Add(this.comboBoxFiltrage);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dataGridProduits);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnAjouter);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produits";
            this.Text = "Rechercher";
            this.Load += new System.EventHandler(this.Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}