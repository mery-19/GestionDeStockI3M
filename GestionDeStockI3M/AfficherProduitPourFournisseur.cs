using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.LigneCommandeService;

namespace GestionDeStockI3M
{
    public partial class AfficherProduitPourFournisseur : Form
    {
        Commandes commande;
        public AfficherProduitPourFournisseur(Commandes c)
        {
            InitializeComponent();
            this.commande = c;
        }

        private void btnChoisirProduit_Click(object sender, EventArgs e)
        {
            try
            {
                LigneCommandeService.LigneCommande ligneCommande = new LigneCommandeService.LigneCommande();
                ligneCommande.id_produit = Convert.ToInt32(produitsTable.CurrentRow.Cells["id_produit"].Value);
                ligneCommande.quantite = Convert.ToInt32(textBoxQuantite.Text);
                ligneCommande.prix_grossiste = Convert.ToDecimal(textBoxPrixGrossite.Text);

                int k = produitsTable.CurrentRow.Index;
                produitsTable.CurrentCell = null;
                produitsTable.Rows[k].Visible = false;

                Clear();

                commande.LigneCommandes.Add(ligneCommande);
            }catch (Exception)
            {
                MessageBox.Show("les champs invalid.", "Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Clear()
        {
            produitsTable.ClearSelection();
            this.textBoxPrixGrossite.Text = "";
            this.textBoxQuantite.Text = "";
            this.textBoxPrixGrossite.Enabled = false;
            this.textBoxQuantite.Enabled = false;
        }

        private void AfficherProduitPourFournisseur_Load(object sender, EventArgs e)
        {
            produitsTable.DataSource = commande.produitService.findByFournisseur(commande.Id_fournisseur);
            this.Clear();

            produitsTable.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));

        }

        private void produitsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produitsTable.CurrentRow.Index != -1)
            {
                textBoxQuantite.Enabled = true;
                textBoxPrixGrossite.Enabled = true;
            }
        }

        private void AfficherProduitPourFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(commande.LigneCommandes.Count != 0)
            {
                commande.comboBoxFourn.Enabled = false;
                commande.comboBoxProduits.Enabled = true;
                commande.dateTimePickerArriveSouhaite.Enabled = true;
                commande.btnChercherProduitPourFournisseur.Visible = false;
                commande.btnCommander.Enabled = true;
                commande.produits();
            }
            
        }
    }
}
