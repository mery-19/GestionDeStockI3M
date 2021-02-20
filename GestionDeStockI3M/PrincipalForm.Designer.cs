namespace GestionDeStockI3M
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPasseword = new System.Windows.Forms.Label();
            this.labelNomUtilisateur = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.textBoxPasseword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.erreur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.erreur);
            this.panel1.Controls.Add(this.labelPasseword);
            this.panel1.Controls.Add(this.labelNomUtilisateur);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Controls.Add(this.textBoxPasseword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Location = new System.Drawing.Point(177, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 345);
            this.panel1.TabIndex = 0;
            // 
            // labelPasseword
            // 
            this.labelPasseword.AutoSize = true;
            this.labelPasseword.BackColor = System.Drawing.Color.Transparent;
            this.labelPasseword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelPasseword.Location = new System.Drawing.Point(50, 166);
            this.labelPasseword.Name = "labelPasseword";
            this.labelPasseword.Size = new System.Drawing.Size(135, 19);
            this.labelPasseword.TabIndex = 3;
            this.labelPasseword.Text = "Mot de passe :";
            // 
            // labelNomUtilisateur
            // 
            this.labelNomUtilisateur.AutoSize = true;
            this.labelNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.labelNomUtilisateur.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelNomUtilisateur.Location = new System.Drawing.Point(21, 112);
            this.labelNomUtilisateur.Name = "labelNomUtilisateur";
            this.labelNomUtilisateur.Size = new System.Drawing.Size(180, 19);
            this.labelNomUtilisateur.TabIndex = 3;
            this.labelNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(274, 269);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(147, 29);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnConnexion.FlatAppearance.BorderSize = 0;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(38, 269);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(147, 29);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // textBoxPasseword
            // 
            this.textBoxPasseword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPasseword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasseword.Location = new System.Drawing.Point(217, 156);
            this.textBoxPasseword.Name = "textBoxPasseword";
            this.textBoxPasseword.PasswordChar = '*';
            this.textBoxPasseword.Size = new System.Drawing.Size(204, 29);
            this.textBoxPasseword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(217, 107);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(204, 29);
            this.textBoxUsername.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(448, 54);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(100, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(255, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "AUTHENTIFICATION";
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.BackColor = System.Drawing.Color.White;
            this.erreur.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(22, 214);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(0, 15);
            this.erreur.TabIndex = 4;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox textBoxPasseword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNomUtilisateur;
        private System.Windows.Forms.Label labelPasseword;
        private System.Windows.Forms.Label erreur;
    }
}