namespace GestionDeStockI3M
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProviders = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelChangeant = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panelMenu.Controls.Add(this.btnSeDeconnecter);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelScroll);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnProviders);
            this.panelMenu.Controls.Add(this.btnSales);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 641);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnSeDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnSeDeconnecter.Image")));
            this.btnSeDeconnecter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeDeconnecter.Location = new System.Drawing.Point(0, 520);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(200, 71);
            this.btnSeDeconnecter.TabIndex = 5;
            this.btnSeDeconnecter.Text = "Se Déconnecter";
            this.btnSeDeconnecter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeDeconnecter.UseVisualStyleBackColor = true;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashboard.Location = new System.Drawing.Point(0, 116);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 69);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Tableau de bord";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.Black;
            this.panelScroll.Location = new System.Drawing.Point(203, 116);
            this.panelScroll.Margin = new System.Windows.Forms.Padding(0);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(8, 69);
            this.panelScroll.TabIndex = 5;
            this.panelScroll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelScroll_Paint);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrders.Location = new System.Drawing.Point(0, 267);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 75);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Commandes";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProviders
            // 
            this.btnProviders.FlatAppearance.BorderSize = 0;
            this.btnProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProviders.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnProviders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnProviders.Image = ((System.Drawing.Image)(resources.GetObject("btnProviders.Image")));
            this.btnProviders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProviders.Location = new System.Drawing.Point(4, 431);
            this.btnProviders.Name = "btnProviders";
            this.btnProviders.Size = new System.Drawing.Size(200, 83);
            this.btnProviders.TabIndex = 3;
            this.btnProviders.Text = "Fournisseurs";
            this.btnProviders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProviders.UseVisualStyleBackColor = true;
            this.btnProviders.Click += new System.EventHandler(this.btnProviders_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.Location = new System.Drawing.Point(0, 348);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 77);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Ventes";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.Location = new System.Drawing.Point(0, 188);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 73);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Produits";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(207, 84);
            this.panelTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Handwriting", 48F);
            this.title.Location = new System.Drawing.Point(12, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(259, 124);
            this.title.TabIndex = 0;
            this.title.Text = "I3M";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(237, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(287, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Tableau de bord";
            // 
            // panelChangeant
            // 
            this.panelChangeant.Location = new System.Drawing.Point(210, 47);
            this.panelChangeant.Name = "panelChangeant";
            this.panelChangeant.Size = new System.Drawing.Size(837, 582);
            this.panelChangeant.TabIndex = 6;
            this.panelChangeant.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChangeant_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 641);
            this.Controls.Add(this.panelChangeant);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProviders;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelChangeant;
        private System.Windows.Forms.Button btnSeDeconnecter;
    }
}

