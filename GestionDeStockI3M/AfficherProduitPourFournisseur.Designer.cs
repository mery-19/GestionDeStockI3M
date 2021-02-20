namespace GestionDeStockI3M
{
    partial class AfficherProduitPourFournisseur
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
            this.btnChoisirProduit = new System.Windows.Forms.Button();
            this.labelListeProduits = new System.Windows.Forms.Label();
            this.textBoxPrixGrossite = new System.Windows.Forms.TextBox();
            this.labelPrixGrossiste = new System.Windows.Forms.Label();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.id_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produitsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisirProduit
            // 
            this.btnChoisirProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnChoisirProduit.FlatAppearance.BorderSize = 0;
            this.btnChoisirProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisirProduit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChoisirProduit.ForeColor = System.Drawing.Color.Black;
            this.btnChoisirProduit.Location = new System.Drawing.Point(600, 250);
            this.btnChoisirProduit.Name = "btnChoisirProduit";
            this.btnChoisirProduit.Size = new System.Drawing.Size(116, 32);
            this.btnChoisirProduit.TabIndex = 1;
            this.btnChoisirProduit.Text = "Valider";
            this.btnChoisirProduit.UseVisualStyleBackColor = false;
            this.btnChoisirProduit.Click += new System.EventHandler(this.btnChoisirProduit_Click);
            // 
            // labelListeProduits
            // 
            this.labelListeProduits.AutoSize = true;
            this.labelListeProduits.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListeProduits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.labelListeProduits.Location = new System.Drawing.Point(12, 20);
            this.labelListeProduits.Name = "labelListeProduits";
            this.labelListeProduits.Size = new System.Drawing.Size(341, 37);
            this.labelListeProduits.TabIndex = 2;
            this.labelListeProduits.Text = "Liste des produits";
            // 
            // textBoxPrixGrossite
            // 
            this.textBoxPrixGrossite.Location = new System.Drawing.Point(661, 163);
            this.textBoxPrixGrossite.Name = "textBoxPrixGrossite";
            this.textBoxPrixGrossite.Size = new System.Drawing.Size(114, 31);
            this.textBoxPrixGrossite.TabIndex = 11;
            // 
            // labelPrixGrossiste
            // 
            this.labelPrixGrossiste.AutoSize = true;
            this.labelPrixGrossiste.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrixGrossiste.ForeColor = System.Drawing.Color.Black;
            this.labelPrixGrossiste.Location = new System.Drawing.Point(518, 166);
            this.labelPrixGrossiste.Name = "labelPrixGrossiste";
            this.labelPrixGrossiste.Size = new System.Drawing.Size(175, 23);
            this.labelPrixGrossiste.TabIndex = 9;
            this.labelPrixGrossiste.Text = "Prix grossite :";
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(661, 115);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(114, 31);
            this.textBoxQuantite.TabIndex = 11;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantite.ForeColor = System.Drawing.Color.Black;
            this.labelQuantite.Location = new System.Drawing.Point(553, 118);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(120, 23);
            this.labelQuantite.TabIndex = 9;
            this.labelQuantite.Text = "Quantité :";
            // 
            // id_produit
            // 
            this.id_produit.DataPropertyName = "id_produit";
            this.id_produit.HeaderText = "Id de produit";
            this.id_produit.MinimumWidth = 8;
            this.id_produit.Name = "id_produit";
            this.id_produit.ReadOnly = true;
            this.id_produit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Fournisseur
            // 
            this.Fournisseur.DataPropertyName = "Fournisseur";
            this.Fournisseur.HeaderText = "Fournisseur";
            this.Fournisseur.MinimumWidth = 8;
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.ReadOnly = true;
            this.Fournisseur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fournisseur.Visible = false;
            // 
            // id_fournisseur
            // 
            this.id_fournisseur.DataPropertyName = "id_fournisseur";
            this.id_fournisseur.HeaderText = "id_fournisseur";
            this.id_fournisseur.MinimumWidth = 8;
            this.id_fournisseur.Name = "id_fournisseur";
            this.id_fournisseur.ReadOnly = true;
            this.id_fournisseur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_fournisseur.Visible = false;
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "quantite";
            this.quantite.MinimumWidth = 8;
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantite.Visible = false;
            // 
            // date_expiration
            // 
            this.date_expiration.DataPropertyName = "date_expiration";
            this.date_expiration.HeaderText = "date_expiration";
            this.date_expiration.MinimumWidth = 8;
            this.date_expiration.Name = "date_expiration";
            this.date_expiration.ReadOnly = true;
            this.date_expiration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_expiration.Visible = false;
            // 
            // date_ajout
            // 
            this.date_ajout.DataPropertyName = "date_ajout";
            this.date_ajout.HeaderText = "date_ajout";
            this.date_ajout.MinimumWidth = 8;
            this.date_ajout.Name = "date_ajout";
            this.date_ajout.ReadOnly = true;
            this.date_ajout.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_ajout.Visible = false;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.Visible = false;
            // 
            // prix_vente
            // 
            this.prix_vente.DataPropertyName = "prix_vente";
            this.prix_vente.HeaderText = "prix_vente";
            this.prix_vente.MinimumWidth = 8;
            this.prix_vente.Name = "prix_vente";
            this.prix_vente.ReadOnly = true;
            this.prix_vente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prix_vente.Visible = false;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // produitsTable
            // 
            this.produitsTable.AllowUserToAddRows = false;
            this.produitsTable.AllowUserToDeleteRows = false;
            this.produitsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produitsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.produitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produit,
            this.Fournisseur,
            this.id_fournisseur,
            this.quantite,
            this.date_expiration,
            this.date_ajout,
            this.image,
            this.prix_vente,
            this.nom});
            this.produitsTable.Location = new System.Drawing.Point(12, 57);
            this.produitsTable.Name = "produitsTable";
            this.produitsTable.ReadOnly = true;
            this.produitsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.produitsTable.RowHeadersWidth = 62;
            this.produitsTable.Size = new System.Drawing.Size(439, 261);
            this.produitsTable.TabIndex = 0;
            this.produitsTable.Text = "dataGridView1";
            this.produitsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produitsTable_CellClick);
            // 
            // AfficherProduitPourFournisseur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 346);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.labelPrixGrossiste);
            this.Controls.Add(this.textBoxPrixGrossite);
            this.Controls.Add(this.labelListeProduits);
            this.Controls.Add(this.btnChoisirProduit);
            this.Controls.Add(this.produitsTable);
            this.Name = "AfficherProduitPourFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les produits disponibles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfficherProduitPourFournisseur_FormClosed);
            this.Load += new System.EventHandler(this.AfficherProduitPourFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produitsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produitsTable;
        private System.Windows.Forms.Button btnChoisirProduit;
        private System.Windows.Forms.Label labelListeProduits;
        private System.Windows.Forms.TextBox textBoxPrixGrossite;
        private System.Windows.Forms.Label labelPrixGrossiste;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_expiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ajout;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    }
}