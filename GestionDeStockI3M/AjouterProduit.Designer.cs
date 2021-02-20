namespace GestionDeStockI3M
{
    partial class AjouterProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterProduit));
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dateTimePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.btnAjouterFournisseur = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(239, 36);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(211, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(98, 39);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(119, 15);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom du produit :";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(239, 200);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(211, 23);
            this.textBoxPrix.TabIndex = 0;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(124, 203);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(49, 15);
            this.labelPrix.TabIndex = 1;
            this.labelPrix.Text = "Prix :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(77, 147);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(140, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date d\'expiration :";
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAjouterProduit.FlatAppearance.BorderSize = 0;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterProduit.Location = new System.Drawing.Point(196, 496);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(162, 35);
            this.btnAjouterProduit.TabIndex = 2;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(52, 372);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(70, 15);
            this.labelImage.TabIndex = 1;
            this.labelImage.Text = "L\'image :";
            // 
            // btnUpload
            // 
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(123, 362);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(50, 35);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dateTimePickerExpiration
            // 
            this.dateTimePickerExpiration.Location = new System.Drawing.Point(239, 147);
            this.dateTimePickerExpiration.Name = "dateTimePickerExpiration";
            this.dateTimePickerExpiration.Size = new System.Drawing.Size(211, 23);
            this.dateTimePickerExpiration.TabIndex = 4;
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Location = new System.Drawing.Point(77, 101);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(147, 15);
            this.labelFournisseur.TabIndex = 1;
            this.labelFournisseur.Text = "Nom du Fournisseur :";
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(239, 93);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(211, 23);
            this.comboBoxFournisseur.TabIndex = 6;
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.FlatAppearance.BorderSize = 0;
            this.btnAjouterFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterFournisseur.Image")));
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(486, 86);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(35, 35);
            this.btnAjouterFournisseur.TabIndex = 7;
            this.btnAjouterFournisseur.UseVisualStyleBackColor = true;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(212, 279);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(309, 210);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(123, 253);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(77, 15);
            this.labelQuantite.TabIndex = 1;
            this.labelQuantite.Text = "Quantité :";
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(239, 250);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(211, 23);
            this.textBoxQuantite.TabIndex = 0;
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 543);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAjouterFournisseur);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dateTimePickerExpiration);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.btnAjouterProduit);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Produit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.TextBox textBoxPrix;
        public System.Windows.Forms.Label labelPrix;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Button btnAjouterProduit;
        public System.Windows.Forms.Label labelImage;
        public System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.DateTimePicker dateTimePickerExpiration;
        public System.Windows.Forms.Label labelFournisseur;
        public System.Windows.Forms.ComboBox comboBoxFournisseur;
        public System.Windows.Forms.Button btnAjouterFournisseur;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Label labelQuantite;
        public System.Windows.Forms.TextBox textBoxQuantite;
    }
}