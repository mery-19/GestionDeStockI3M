namespace GestionDeStockI3M
{
    partial class AjouterFournisseur
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.richTextBoxAdresse = new System.Windows.Forms.RichTextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(387, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 222);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 15);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(126, 262);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(162, 35);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(42, 181);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(68, 15);
            this.labelTelephone.TabIndex = 1;
            this.labelTelephone.Text = "Téléphone :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(53, 90);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(57, 15);
            this.labelAdresse.TabIndex = 1;
            this.labelAdresse.Text = "Adresse  :";
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Location = new System.Drawing.Point(25, 42);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(119, 15);
            this.labelNomFournisseur.TabIndex = 1;
            this.labelNomFournisseur.Text = "Nom du fournisseur :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(170, 39);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(211, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // richTextBoxAdresse
            // 
            this.richTextBoxAdresse.Location = new System.Drawing.Point(170, 71);
            this.richTextBoxAdresse.Name = "richTextBoxAdresse";
            this.richTextBoxAdresse.Size = new System.Drawing.Size(211, 87);
            this.richTextBoxAdresse.TabIndex = 8;
            this.richTextBoxAdresse.Text = "";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(170, 178);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(211, 23);
            this.textBoxTel.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(170, 219);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(211, 23);
            this.textBoxEmail.TabIndex = 9;
            // 
            // AjouterFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 318);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.richTextBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNomFournisseur);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.button1);
            this.Name = "AjouterFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Label labelTelephone;
        public System.Windows.Forms.Label labelAdresse;
        public System.Windows.Forms.Label labelNomFournisseur;
        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.RichTextBox richTextBoxAdresse;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.TextBox textBoxEmail;
    }
}