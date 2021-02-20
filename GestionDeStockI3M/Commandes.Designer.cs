namespace GestionDeStockI3M
{
    partial class Commandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commandes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.comboBoxCommandes = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.labelListeDesCommndes = new System.Windows.Forms.Label();
            this.labelAjouterUneCommande = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.comboBoxFourn = new System.Windows.Forms.ComboBox();
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.btnChercherProduitPourFournisseur = new System.Windows.Forms.Button();
            this.btnCommander = new System.Windows.Forms.Button();
            this.comboBoxProduits = new System.Windows.Forms.ComboBox();
            this.dateTimePickerArriveSouhaite = new System.Windows.Forms.DateTimePicker();
            this.labelDateArrive = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.id_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_souhaite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.commandesTable = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commandesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnFiltrer.FlatAppearance.BorderSize = 0;
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrer.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnFiltrer.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrer.Location = new System.Drawing.Point(267, 269);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(86, 39);
            this.btnFiltrer.TabIndex = 4;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // comboBoxCommandes
            // 
            this.comboBoxCommandes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommandes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxCommandes.FormattingEnabled = true;
            this.comboBoxCommandes.Items.AddRange(new object[] {
            "Commandes en cours",
            "Commandes en retard",
            "Commandes arrivés"});
            this.comboBoxCommandes.Location = new System.Drawing.Point(23, 280);
            this.comboBoxCommandes.Name = "comboBoxCommandes";
            this.comboBoxCommandes.Size = new System.Drawing.Size(224, 21);
            this.comboBoxCommandes.TabIndex = 8;
            // 
            // btnAfficher
            // 
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnAfficher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficher.Location = new System.Drawing.Point(583, 269);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(119, 39);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // labelListeDesCommndes
            // 
            this.labelListeDesCommndes.AutoSize = true;
            this.labelListeDesCommndes.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.labelListeDesCommndes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelListeDesCommndes.Location = new System.Drawing.Point(23, 243);
            this.labelListeDesCommndes.Name = "labelListeDesCommndes";
            this.labelListeDesCommndes.Size = new System.Drawing.Size(200, 22);
            this.labelListeDesCommndes.TabIndex = 7;
            this.labelListeDesCommndes.Text = "Liste des commandes";
            // 
            // labelAjouterUneCommande
            // 
            this.labelAjouterUneCommande.AutoSize = true;
            this.labelAjouterUneCommande.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.labelAjouterUneCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelAjouterUneCommande.Location = new System.Drawing.Point(23, 19);
            this.labelAjouterUneCommande.Name = "labelAjouterUneCommande";
            this.labelAjouterUneCommande.Size = new System.Drawing.Size(210, 22);
            this.labelAjouterUneCommande.TabIndex = 7;
            this.labelAjouterUneCommande.Text = "Ajouter une commande";
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelNomFournisseur.ForeColor = System.Drawing.Color.Black;
            this.labelNomFournisseur.Location = new System.Drawing.Point(203, 62);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(119, 15);
            this.labelNomFournisseur.TabIndex = 9;
            this.labelNomFournisseur.Text = "Nom Fourisseur :";
            // 
            // comboBoxFourn
            // 
            this.comboBoxFourn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFourn.FormattingEnabled = true;
            this.comboBoxFourn.Location = new System.Drawing.Point(328, 60);
            this.comboBoxFourn.Name = "comboBoxFourn";
            this.comboBoxFourn.Size = new System.Drawing.Size(258, 21);
            this.comboBoxFourn.TabIndex = 10;
            this.comboBoxFourn.DropDownClosed += new System.EventHandler(this.comboBoxFourn_DropDownClosed);
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelNomProduit.ForeColor = System.Drawing.Color.Black;
            this.labelNomProduit.Location = new System.Drawing.Point(252, 99);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(70, 15);
            this.labelNomProduit.TabIndex = 9;
            this.labelNomProduit.Text = "Produit :";
            // 
            // btnChercherProduitPourFournisseur
            // 
            this.btnChercherProduitPourFournisseur.BackColor = System.Drawing.Color.White;
            this.btnChercherProduitPourFournisseur.FlatAppearance.BorderSize = 0;
            this.btnChercherProduitPourFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChercherProduitPourFournisseur.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.btnChercherProduitPourFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnChercherProduitPourFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btnChercherProduitPourFournisseur.Image")));
            this.btnChercherProduitPourFournisseur.Location = new System.Drawing.Point(605, 54);
            this.btnChercherProduitPourFournisseur.Name = "btnChercherProduitPourFournisseur";
            this.btnChercherProduitPourFournisseur.Size = new System.Drawing.Size(41, 33);
            this.btnChercherProduitPourFournisseur.TabIndex = 13;
            this.btnChercherProduitPourFournisseur.UseVisualStyleBackColor = false;
            this.btnChercherProduitPourFournisseur.Click += new System.EventHandler(this.btnChercherProduitPourFournisseur_Click);
            // 
            // btnCommander
            // 
            this.btnCommander.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCommander.FlatAppearance.BorderSize = 0;
            this.btnCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommander.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnCommander.ForeColor = System.Drawing.Color.White;
            this.btnCommander.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommander.Location = new System.Drawing.Point(333, 182);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(119, 39);
            this.btnCommander.TabIndex = 4;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = false;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // comboBoxProduits
            // 
            this.comboBoxProduits.FormattingEnabled = true;
            this.comboBoxProduits.Location = new System.Drawing.Point(328, 99);
            this.comboBoxProduits.Name = "comboBoxProduits";
            this.comboBoxProduits.Size = new System.Drawing.Size(258, 21);
            this.comboBoxProduits.TabIndex = 10;
            // 
            // dateTimePickerArriveSouhaite
            // 
            this.dateTimePickerArriveSouhaite.Location = new System.Drawing.Point(328, 136);
            this.dateTimePickerArriveSouhaite.Name = "dateTimePickerArriveSouhaite";
            this.dateTimePickerArriveSouhaite.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerArriveSouhaite.TabIndex = 4;
            // 
            // labelDateArrive
            // 
            this.labelDateArrive.AutoSize = true;
            this.labelDateArrive.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelDateArrive.ForeColor = System.Drawing.Color.Black;
            this.labelDateArrive.Location = new System.Drawing.Point(87, 141);
            this.labelDateArrive.Name = "labelDateArrive";
            this.labelDateArrive.Size = new System.Drawing.Size(175, 15);
            this.labelDateArrive.TabIndex = 9;
            this.labelDateArrive.Text = "Date d’arrivé souhaité :";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Consolas", 12F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(467, 182);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(119, 39);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // id_commande
            // 
            this.id_commande.DataPropertyName = "id_commande";
            this.id_commande.HeaderText = "id de Commande";
            this.id_commande.MinimumWidth = 8;
            this.id_commande.Name = "id_commande";
            this.id_commande.ReadOnly = true;
            this.id_commande.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // date_arrive
            // 
            this.date_arrive.DataPropertyName = "date_arrive";
            this.date_arrive.HeaderText = "Date d\'arrivé";
            this.date_arrive.MinimumWidth = 8;
            this.date_arrive.Name = "date_arrive";
            this.date_arrive.ReadOnly = true;
            this.date_arrive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_arrive.Visible = false;
            // 
            // date_souhaite
            // 
            this.date_souhaite.DataPropertyName = "date_souhaite";
            this.date_souhaite.HeaderText = "Date d’arrivé souhaitée";
            this.date_souhaite.MinimumWidth = 8;
            this.date_souhaite.Name = "date_souhaite";
            this.date_souhaite.ReadOnly = true;
            this.date_souhaite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // confirme
            // 
            this.confirme.DataPropertyName = "confirme";
            this.confirme.HeaderText = "confirme";
            this.confirme.MinimumWidth = 8;
            this.confirme.Name = "confirme";
            this.confirme.ReadOnly = true;
            this.confirme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.confirme.Visible = false;
            // 
            // date_commande
            // 
            this.date_commande.DataPropertyName = "date_commande";
            this.date_commande.HeaderText = "Date de commande";
            this.date_commande.MinimumWidth = 8;
            this.date_commande.Name = "date_commande";
            this.date_commande.ReadOnly = true;
            this.date_commande.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // action
            // 
            this.action.DataPropertyName = "confirme";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.action.DefaultCellStyle = dataGridViewCellStyle1;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action.HeaderText = "action";
            this.action.MinimumWidth = 8;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.action.Text = "Confirmé";
            this.action.UseColumnTextForButtonValue = true;
            this.action.Visible = false;
            // 
            // commandesTable
            // 
            this.commandesTable.AllowUserToAddRows = false;
            this.commandesTable.AllowUserToDeleteRows = false;
            this.commandesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commandesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.commandesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_commande,
            this.date_arrive,
            this.date_souhaite,
            this.confirme,
            this.date_commande,
            this.action});
            this.commandesTable.Location = new System.Drawing.Point(23, 317);
            this.commandesTable.Name = "commandesTable";
            this.commandesTable.ReadOnly = true;
            this.commandesTable.RowHeadersWidth = 62;
            this.commandesTable.Size = new System.Drawing.Size(804, 320);
            this.commandesTable.TabIndex = 6;
            this.commandesTable.Text = "dataGridView1";
            this.commandesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commandesTable_CellClick);
           
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(708, 269);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(119, 39);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Commandes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 649);
            this.Controls.Add(this.labelDateArrive);
            this.Controls.Add(this.dateTimePickerArriveSouhaite);
            this.Controls.Add(this.comboBoxProduits);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.btnChercherProduitPourFournisseur);
            this.Controls.Add(this.labelNomProduit);
            this.Controls.Add(this.comboBoxFourn);
            this.Controls.Add(this.labelNomFournisseur);
            this.Controls.Add(this.labelAjouterUneCommande);
            this.Controls.Add(this.labelListeDesCommndes);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.commandesTable);
            this.Controls.Add(this.comboBoxCommandes);
            this.Controls.Add(this.btnFiltrer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnFiltrer;
        public System.Windows.Forms.ComboBox comboBoxCommandes;
        public System.Windows.Forms.DataGridView commandesTable;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.Label labelListeDesCommndes;
        public System.Windows.Forms.Label labelAjouterUneCommande;
        public System.Windows.Forms.Label labelNomFournisseur;
        public System.Windows.Forms.ComboBox comboBoxFourn;
        public System.Windows.Forms.Label labelNomProduit;
        public System.Windows.Forms.Button btnChercherProduitPourFournisseur;
        public System.Windows.Forms.Button btnCommander;
        public System.Windows.Forms.ComboBox comboBoxProduits;
        public System.Windows.Forms.DateTimePicker dateTimePickerArriveSouhaite;
        private System.Windows.Forms.Label labelDateArrive;
        
        /*Task Start*/
        private int id_fournisseur = 0;
        public System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_souhaite;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirme;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        public System.Windows.Forms.Button btnSupprimer;

        public int Id_fournisseur { get => id_fournisseur; set => id_fournisseur = value; }

        /*Task End*/
    }
}