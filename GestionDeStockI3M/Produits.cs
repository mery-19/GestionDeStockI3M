using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.ProduitService;
using Excel = Microsoft.Office.Interop.Excel;


namespace GestionDeStockI3M
{
    public partial class Produits : Form
    {
        private Button btnAjouter;
        private Button btnAfficher;
        private Button btnSupprimer;
        private TextBox textBoxRecherche;
        private Button btnRechercher;
        public DataGridView dataGridProduits;
        private Button btnExcel;
        private Button btnFiltrer;
        private ComboBox comboBoxFiltrage;
        private DataGridViewTextBoxColumn id_produit;
        private DataGridViewTextBoxColumn id_fournisseur;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn prix_vente;
        private DataGridViewTextBoxColumn quantite;
        private DataGridViewTextBoxColumn image;
        private DataGridViewTextBoxColumn date_expiration;
        private DataGridViewTextBoxColumn date_ajout;
        private Button btnModifier;
        DataGridViewRow selectedRow = new DataGridViewRow();
        public Produits()
        {
            InitializeComponent();
        }


        private void loadComboboxFournisseurs(AjouterProduit p)
        {
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            List<Fournisseur> Fournisseurs = new List<Fournisseur>(service.findAllFournisseur());
            foreach (Fournisseur f in Fournisseurs)
            {
                p.comboBoxFournisseur.Items.Add(f.nom);
            }
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProduit ap = new AjouterProduit(0, this);
            loadComboboxFournisseurs(ap);
            ap.Controls.Remove(ap.labelQuantite);
            ap.labelQuantite.Dispose();
            ap.Controls.Remove(ap.textBoxQuantite);
            ap.textBoxQuantite.Dispose();
            ap.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            AjouterProduit ap = new AjouterProduit(int.Parse(selectedRow.Cells["id_produit"].Value.ToString()), this);
            ap.Text = "Modifier produit";
            ap.btnAjouterProduit.Text = "Modifier";
            loadComboboxFournisseurs(ap);
            ap.Show();
            ap.textBoxNom.Text = selectedRow.Cells["nom"].Value.ToString();
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            ap.comboBoxFournisseur.SelectedItem = service.findProductsById(int.Parse(selectedRow.Cells["id_fournisseur"].Value.ToString())).nom.ToString();
            ap.textBoxPrix.Text = selectedRow.Cells["prix_vente"].Value.ToString();
            if (selectedRow.Cells["quantite"].Value == null)
                ap.textBoxQuantite.Text = "0";
            else
                ap.textBoxQuantite.Text = selectedRow.Cells["quantite"].Value.ToString();
            ap.dateTimePickerExpiration.Value = DateTime.Parse(selectedRow.Cells["date_expiration"].Value.ToString());
            ap.pictureBox.ImageLocation = selectedRow.Cells["image"].Value.ToString();
        }
        void Clear()
        {
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
            btnAfficher.Enabled = false;
        }

        private void Produits_Load(object sender, EventArgs e)
        {
            this.dataGridProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduits.MultiSelect = false;
            dataGridProduits.AutoGenerateColumns = false;
            ShowProducts();
        }

        public void ShowProducts()
        {
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            dataGridProduits.DataSource = service.findAll();
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            AjouterProduit ap = new AjouterProduit(0, this);
            ap.Text = "Afficher produit";
            ap.Controls.Remove(ap.btnUpload);
            ap.Controls.Remove(ap.btnAjouterFournisseur);
            ap.Controls.Remove(ap.btnAjouterProduit);
            ap.btnUpload.Dispose();
            ap.btnAjouterFournisseur.Dispose();
            ap.btnAjouterProduit.Dispose();

            ap.textBoxNom.Text = selectedRow.Cells["nom"].Value.ToString();
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            ap.comboBoxFournisseur.Items.Add(service.findProductsById(int.Parse(selectedRow.Cells["id_fournisseur"].Value.ToString())).nom.ToString());
            ap.comboBoxFournisseur.SelectedIndex = 0;
            ap.textBoxNom.Enabled = false;
            ap.textBoxPrix.Enabled = false;
            ap.dateTimePickerExpiration.Enabled = false;
            ap.textBoxQuantite.Enabled = false;
            ap.comboBoxFournisseur.Enabled = false;

            ap.textBoxPrix.Text = selectedRow.Cells["prix_vente"].Value.ToString();
            if (selectedRow.Cells["quantite"].Value == null)
                ap.textBoxQuantite.Text = "0";
            else
                ap.textBoxQuantite.Text = selectedRow.Cells["quantite"].Value.ToString();
            ap.dateTimePickerExpiration.Value = DateTime.Parse(selectedRow.Cells["date_expiration"].Value.ToString());
            ap.pictureBox.ImageLocation = selectedRow.Cells["image"].Value.ToString();
            ap.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridProduits.Rows.Count > 0)
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                worksheet = workbook.Sheets["Feuil1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exportation des produits";

                for (int i = 1; i < dataGridProduits.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridProduits.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridProduits.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridProduits.Columns.Count; j++)
                    {
                        if (dataGridProduits.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dataGridProduits.Rows[i].Cells[j].Value.ToString();
                        else
                            worksheet.Cells[i + 2, j + 1] = "NULL";
                    }
                }
                app.Columns.AutoFit();
                app.Visible = true;

            }
            else
            {
                MessageBox.Show("Y'a pas de données à exporter", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous etes sûr de vouloir supprimer ce produit ?",
                "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProduitServiceWCFClient service = new ProduitServiceWCFClient();
                service.delete(int.Parse(selectedRow.Cells[0].Value.ToString()));
                if (File.Exists(selectedRow.Cells[5].Value.ToString()))
                {
                    File.Delete(selectedRow.Cells[5].Value.ToString());
                }
                MessageBox.Show("Le produit est supprimé");
                ShowProducts();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            dataGridProduits.DataSource = service.findProductsByName(textBoxRecherche.Text);
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            ProduitServiceWCFClient service = new ProduitServiceWCFClient();
            if (comboBoxFiltrage.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez séléctionner le type de filtrage",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxFiltrage.SelectedIndex == 3)
            {
                dataGridProduits.DataSource = service.findDestockedProduts();
            }
            else if (comboBoxFiltrage.SelectedIndex == 2)
            {
                dataGridProduits.DataSource = service.findProductsNotAvaible();
            }
            else if (comboBoxFiltrage.SelectedIndex == 1)
            {
                dataGridProduits.DataSource = service.findAvaibleProducts();
            }
            else
                ShowProducts();
        }

        private void dataGridProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProduits.SelectedRows.Count <= 0)
            {
                Clear();
            }
            else
            {
                btnAfficher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                selectedRow = dataGridProduits.Rows[e.RowIndex];
            }
        }

        private void dataGridProduits_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridProduits.ClearSelection();
            if (dataGridProduits.SelectedRows.Count <= 0)
            {
                Clear();
            }
            else
            {
                btnAfficher.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }




    }
}
