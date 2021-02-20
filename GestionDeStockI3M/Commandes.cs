using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.FournisseurService;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.CommandeService;
using GestionDeStockI3M.LigneCommandeService;

namespace GestionDeStockI3M
{
    public partial class Commandes : Form
    {
        public FournisseurServiceWCFClient fournisseurService = new FournisseurServiceWCFClient();
        public ProduitServiceWCFClient produitService = new ProduitServiceWCFClient();
        public CommandeServiceWCFClient commandeService = new CommandeServiceWCFClient();
        public LigneCommandeServiceWCFClient ligneCommandeService = new LigneCommandeServiceWCFClient();
        private List<LigneCommandeService.LigneCommande> ligneCommandes = new List<LigneCommandeService.LigneCommande>();
        List<ProduitService.Produit> myProduits = new List<ProduitService.Produit>();
        public int id_SelectedCommande = 0;

        public List<LigneCommandeService.LigneCommande> LigneCommandes { get => ligneCommandes; set => ligneCommandes = value; }

        public Commandes()
        {
            InitializeComponent();
        }
        
        private void btnChercherProduitPourFournisseur_Click(object sender, EventArgs e)
        {
            if(id_fournisseur >= 1)
            {
                AfficherProduitPourFournisseur liste = new AfficherProduitPourFournisseur(this);
                liste.Show();
            }else
            {
                MessageBox.Show("Selection invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Commandes_Load(object sender, EventArgs e)
        {
            //rename comboBox1
            // add text to comboBoxFourn (Choisir ...)

            comboBoxFourn.DataSource = fournisseurService.findAll();
            comboBoxFourn.DisplayMember = "nom";
            comboBoxFourn.ValueMember = "id_fournisseur";
            comboBoxFourn.SelectedIndex = -1;

            this.comboBoxProduits.Enabled = false;
            this.btnCommander.Enabled = false;
            this.dateTimePickerArriveSouhaite.Enabled = false;

            comboBoxCommandes.SelectedIndex = 0;
            btnFiltrer.PerformClick(); 

            commandesTable.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138))))); 
        }

        private void comboBoxFourn_DropDownClosed(object sender, EventArgs e)
        {
            id_fournisseur = Convert.ToInt32(comboBoxFourn.SelectedValue);
        }

        public void produits()
        {
            foreach(var l in ligneCommandes)
            {
                ProduitService.Produit p = new ProduitService.Produit();
                p = produitService.find(Convert.ToInt32(l.id_produit));
                myProduits.Add(p);
            }
            comboBoxProduits.DataSource = myProduits;
            comboBoxProduits.DisplayMember = "nom";
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            CommandeService.Commande commande = new CommandeService.Commande();
            commande.date_commande = DateTime.Now;
            commande.date_souhaite = Convert.ToDateTime(dateTimePickerArriveSouhaite.Value);

            int idCommande = commandeService.add(commande);
            foreach(LigneCommandeService.LigneCommande l in ligneCommandes)
            {
                l.id_commande = idCommande;
                ligneCommandeService.add(l);
            }

            MessageBox.Show("La commande a été ajouté avec succées.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cancel.PerformClick();
            btnFiltrer.PerformClick();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            comboBoxFourn.SelectedIndex = -1;
            comboBoxFourn.Enabled = true;
            btnChercherProduitPourFournisseur.Visible = true;
            comboBoxProduits.Text = "";
            comboBoxProduits.Enabled = false;
            dateTimePickerArriveSouhaite.Value = DateTime.Now;
            dateTimePickerArriveSouhaite.Enabled = false;
            btnCommander.Enabled = false;
            ligneCommandes.Clear();
            myProduits.Clear();
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            if (comboBoxCommandes.Text == "Commandes en cours")
            {
                commandesTable.DataSource = commandeService.commandeEnCours();
                commandesTable.Columns["action"].Visible = true;
                commandesTable.Columns["date_arrive"].Visible = false;


            }
            else if (comboBoxCommandes.Text == "Commandes en retard")
            {
                commandesTable.DataSource = commandeService.commandeEnRetard();
                commandesTable.Columns["action"].Visible = true;
                commandesTable.Columns["date_arrive"].Visible = false;

            }
            else if (comboBoxCommandes.Text == "Commandes arrivés")
            {
                commandesTable.DataSource = commandeService.commandeConfirme();
                commandesTable.Columns["action"].Visible = false;
                commandesTable.Columns["date_souhaite"].Visible = false;
                commandesTable.Columns["date_arrive"].Visible = true;

            }
            else
            {
                MessageBox.Show("Choix invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            commandesTable.ClearSelection();

        }

        public void addPrixToTable()
        {
            foreach (DataGridViewRow row in commandesTable.Rows)
            {
                row.Cells["prix_total"].Value = commandeService.prixCommande((int)row.Cells["id_commande"].Value);
            }
            commandesTable.ClearSelection();
        }

        private void commandesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Pour la confirmation d'un commande
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == senderGrid.Columns["action"].Index && e.RowIndex >= 0)
            {
                string idCommande = commandesTable.Rows[e.RowIndex].Cells["id_commande"].Value.ToString();

                DialogResult answer = MessageBox.Show("Voulez vous Confirmé la commande de numéro d'id: "+ idCommande + " ?",
                    "Confirmation d'un commande", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (answer)
                {
                    case DialogResult.Yes:
                        int i = commandeService.confirmeCommande(Convert.ToInt32(idCommande));
                        if (i == 1) {
                            btnFiltrer.PerformClick();
                            //mise a jour la table produit

                            int res = produitService.updateQuantite(Convert.ToInt32(idCommande));
                            if (res == 1)
                            {
                                MessageBox.Show("La table de produits à été mise à jour.", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else
                            {
                                MessageBox.Show("Server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else
                        {
                        MessageBox.Show("Server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            } else


            //Pour l'affichage d'un commande (si user click on commande id)
            if (e.ColumnIndex == senderGrid.Columns["id_commande"].Index && e.RowIndex >= 0)
            {
                id_SelectedCommande = Convert.ToInt32(commandesTable.Rows[e.RowIndex].Cells["id_commande"].Value.ToString());
            } else
            {
                id_SelectedCommande = 0;
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (id_SelectedCommande > 0)
            {
                AfficherInfoDeCommande afficherInfoDeCommande = new AfficherInfoDeCommande(this);
                afficherInfoDeCommande.Show();
            }
            else
            {
                MessageBox.Show("Veuillez cliquer sur id d'un produit .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (id_SelectedCommande > 0)
            {

                DialogResult answer = MessageBox.Show("Voulez vous supprimer la commande ?",
                    "Supprimer commande", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (answer)
                {
                    case DialogResult.Yes:
                        int res = commandeService.delete(id_SelectedCommande);
                        if (res == 1)
                        {
                            btnFiltrer.PerformClick();
                            MessageBox.Show("La commande a été supprimer avec succées.", "Suuccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            MessageBox.Show("Service Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                        
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Veuillez cliquer sur id d'un produit .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
