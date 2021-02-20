namespace GestionDeStockI3M
{
    partial class Dashboard
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
            this.btnMois = new System.Windows.Forms.Button();
            this.btnAnnee = new System.Windows.Forms.Button();
            this.btnJour = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMois
            // 
            this.btnMois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnMois.FlatAppearance.BorderSize = 0;
            this.btnMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMois.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnMois.ForeColor = System.Drawing.Color.White;
            this.btnMois.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMois.Location = new System.Drawing.Point(571, 12);
            this.btnMois.Name = "btnMois";
            this.btnMois.Size = new System.Drawing.Size(94, 39);
            this.btnMois.TabIndex = 4;
            this.btnMois.Text = "Mois";
            this.btnMois.UseVisualStyleBackColor = false;
            this.btnMois.Click += new System.EventHandler(this.btnMois_Click);
            // 
            // btnAnnee
            // 
            this.btnAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAnnee.FlatAppearance.BorderSize = 0;
            this.btnAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnee.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnAnnee.ForeColor = System.Drawing.Color.White;
            this.btnAnnee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnee.Location = new System.Drawing.Point(683, 12);
            this.btnAnnee.Name = "btnAnnee";
            this.btnAnnee.Size = new System.Drawing.Size(94, 39);
            this.btnAnnee.TabIndex = 4;
            this.btnAnnee.Text = "Année";
            this.btnAnnee.UseVisualStyleBackColor = false;
            this.btnAnnee.Click += new System.EventHandler(this.btnAnnee_Click);
            // 
            // btnJour
            // 
            this.btnJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnJour.FlatAppearance.BorderSize = 0;
            this.btnJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJour.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnJour.ForeColor = System.Drawing.Color.White;
            this.btnJour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJour.Location = new System.Drawing.Point(455, 12);
            this.btnJour.Name = "btnJour";
            this.btnJour.Size = new System.Drawing.Size(97, 39);
            this.btnJour.TabIndex = 4;
            this.btnJour.Text = "Jour";
            this.btnJour.UseVisualStyleBackColor = false;
            this.btnJour.Click += new System.EventHandler(this.btnJour_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(22, 71);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(815, 452);
            this.panel.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 547);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnJour);
            this.Controls.Add(this.btnAnnee);
            this.Controls.Add(this.btnMois);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMois;
        private System.Windows.Forms.Button btnAnnee;
        private System.Windows.Forms.Button btnJour;
        private System.Windows.Forms.Panel panel;
    }
}