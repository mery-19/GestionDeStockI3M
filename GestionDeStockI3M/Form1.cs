using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStockI3M
{
    public partial class Form1 : Form
    {
        Fournisseurs fr = new Fournisseurs();
        Dashboard db = new Dashboard();
        Produits pr = new Produits();
        Ventes vt = new Ventes();
        Commandes cm = new Commandes();
        public Form1()
        {
            InitializeComponent();

        }

        private void ShowChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChangeant.Controls.Clear();
            panelChangeant.Controls.Add(childForm);
            panelChangeant.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnDashboard.Height;
            this.panelScroll.Top = this.btnDashboard.Top;
            this.labelTitle.Text = "Tableau de bord";
            ShowChildForm(db);


        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnProducts.Height;
            this.panelScroll.Top = this.btnProducts.Top;
            this.labelTitle.Text = "Produits";
            ShowChildForm(pr);


        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnOrders.Height;
            this.panelScroll.Top = this.btnOrders.Top;
            this.labelTitle.Text = "Commandes";
            ShowChildForm(cm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnSales.Height;
            this.panelScroll.Top = this.btnSales.Top;
            this.labelTitle.Text = "Ventes";
            ShowChildForm(vt);
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnProviders.Height;
            this.panelScroll.Top = this.btnProviders.Top;
            this.labelTitle.Text = "Fournisseurs";
           ShowChildForm(fr);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            panelChangeant.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            ShowChildForm(db);
        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            this.panelScroll.Height = this.btnSeDeconnecter.Height;
            this.panelScroll.Top = this.btnSeDeconnecter.Top;
            this.Close();
        }

        private void panelScroll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChangeant_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
