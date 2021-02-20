using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.VenteService;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionDeStockI3M
{
    public partial class Ventes : Form
    {
        public VenteServiceWCFClient VenteService = new VenteServiceWCFClient();
        public ProduitServiceWCFClient produitService = new ProduitServiceWCFClient();
        List<ProduitService.Produit> Produits = new List<ProduitService.Produit>();

        public Ventes()
        {
            InitializeComponent();
            this.textBoxQtRestante.ReadOnly = true;
            this.textBoxPrixVente.ReadOnly = true;
            this.textBoxQtVendu.Enabled = false;

        }

        private void Ventes_Load(object sender, EventArgs e)
        {
            dataGridViewVente.AutoGenerateColumns = false;

            VenteServiceWCFClient vente = new VenteServiceWCFClient();

            dataGridViewVente.DataSource = vente.listeVente();


            ProduitServiceWCFClient serviceproduit = new ProduitServiceWCFClient();
            List<ProduitService.Produit> produits = new List<ProduitService.Produit>(serviceproduit.findAvaibleProducts());
            foreach (ProduitService.Produit p in produits)
            {
                comboBox_prod.Items.Add(p);
            }
            comboBox_prod.DisplayMember = "nom";
            comboBox_prod.ValueMember = "id_produit";


        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (comboBox_prod.Text != "")
            { 
                textBoxQtVendu.Enabled = true; 
             ProduitServiceWCFClient serviceproduit = new ProduitServiceWCFClient();
             ProduitService.Produit produit = (ProduitService.Produit)comboBox_prod.SelectedItem;

            textBoxQtRestante.Text = Convert.ToString(produit.quantite);
            textBoxPrixVente.Text = Convert.ToString(produit.prix_vente);
            }
            else
            { MessageBox.Show("Veuillez Choisir un Produit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int x = 1;
            try
            { int nb = Convert.ToInt32(textBoxQtVendu.Text); }
            catch (Exception exp0)
            {
                MessageBox.Show("Veuillez saisir une quantité valide ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                x = 0;
            }
            if (x == 1)
            {
                if (Convert.ToInt32(textBoxQtRestante.Text) < Convert.ToInt32(textBoxQtVendu.Text))

                {
                    MessageBox.Show("La quantité que vous avez saisi est supérieure à celle du stock \n " +
                      "veuillez entrer une quantité valide", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }

                else
                {
                    VenteService.Vente vente = new VenteService.Vente();
                    vente.date_ajout = DateTime.Now;
                    vente.quantite_vendu = Convert.ToInt32(textBoxQtVendu.Text);
                    ProduitService.Produit produit = (ProduitService.Produit)comboBox_prod.SelectedItem;
                    vente.id_produit = produit.id_produit;
                    VenteService.add(vente);

                    int Qt = Convert.ToInt32(textBoxQtRestante.Text) - Convert.ToInt32(textBoxQtVendu.Text);
                    VenteService.updateQuantity(Qt, produit.id_produit);

                    MessageBox.Show("Le Produit " + produit.nom + " a été Vendu .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel.PerformClick();
                    VenteServiceWCFClient ven = new VenteServiceWCFClient();
                    dataGridViewVente.DataSource = ven.listeVente();

                    comboBox_prod.Items.Clear();
                    ProduitServiceWCFClient serviceproduit = new ProduitServiceWCFClient();
                    List<ProduitService.Produit> produits = new List<ProduitService.Produit>(serviceproduit.findAvaibleProducts());
                    foreach (ProduitService.Produit p in produits)
                    {
                        comboBox_prod.Items.Add(p);
                    }
                    comboBox_prod.DisplayMember = "nom";
                    comboBox_prod.ValueMember = "id_produit";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBox_prod.SelectedIndex = -1;
            comboBox_prod.Text = "";
            textBoxQtRestante.Text = "";
            textBoxPrixVente.Text = "";
            textBoxQtVendu.Text = "";
        }

        private void textBoxQtRestante_TextChanged(object sender, EventArgs e)
        {
            // VenteService.Vente vente = new VenteService.Vente();
        }

        private void comboBox_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxQtVendu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewVente.Rows.Count > 0)
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridViewVente.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridViewVente.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridViewVente.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewVente.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridViewVente.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.Columns.AutoFit();
                ExcelApp.Visible = true;

            }
            else
            {
                MessageBox.Show("la liste est vide ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
