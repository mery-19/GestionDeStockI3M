using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeStockI3M
{
    public partial class AfficherInfoDeCommande : Form
    {
        Commandes commande;
        decimal prix_total;
        public AfficherInfoDeCommande(Commandes c)
        {
            InitializeComponent();
            this.commande = c;
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            CommandeService.ProduitCommande[] selectedProduit = commande.commandeService.GetProduitsOfCommande(commande.id_SelectedCommande);
            commandeProduitTable.DataSource = selectedProduit;
            commandeProduitTable.ClearSelection();
            idCommandeLabel.Text = "La commande de numéro d'Id: " + commande.id_SelectedCommande;

            prix_total = selectedProduit.Select(x => x.Prix_grossiste).Sum();

            prixTotalLabel.Text = "Prix Total: " + prix_total + " DH";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

       

            for (int i = 1; i < commandeProduitTable.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = commandeProduitTable.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < commandeProduitTable.Rows.Count; i++)
            {
                for (int j = 0; j < commandeProduitTable.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j + 1] = commandeProduitTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            
            xcelApp.Cells[commandeProduitTable.Rows.Count + 3, 1] = "id de la commande:";
            xcelApp.Cells[commandeProduitTable.Rows.Count + 3, 2] = commande.id_SelectedCommande;

            xcelApp.Cells[commandeProduitTable.Rows.Count + 4, 1] = "La somme de la commande:";
            xcelApp.Cells[commandeProduitTable.Rows.Count + 4, 2] =  prix_total + " DH";

            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }

    }
    
}
