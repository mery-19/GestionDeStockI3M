using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.ProduitService;
using System.IO;

namespace GestionDeStockI3M
{
    public partial class AjouterProduit : Form
    {
        string imageLocation;
        Produit p = new Produit();
        Produits principalForm = new Produits();
        OpenFileDialog dialog = new OpenFileDialog();
        public AjouterProduit(int id, Produits principalForm)
        {
            p.id_produit = id;
            this.principalForm = principalForm;
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxNom.Text = "";
            pictureBox.ImageLocation = "";
            textBoxPrix.Text = "";
            dateTimePickerExpiration.Value = DateTime.Now;
            comboBoxFournisseur.SelectedIndex = -1;
        }
        public void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == "" || imageLocation == "" || textBoxPrix.Text == "" ||
                comboBoxFournisseur.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tout les champ", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ProduitServiceWCFClient service = new ProduitServiceWCFClient();
                if (imageLocation != null)
                {
                    FileInfo fi = new FileInfo(imageLocation);
                    //While executing the application, the current directory will be the bin folder
                    string path = "../../images/" + textBoxNom.Text.Trim() + fi.Extension;
                    p.image = path;
                    if (File.Exists(p.image))
                    {
                        File.Delete(path);
                        File.Copy(imageLocation, path);
                    }
                    else
                    {
                        File.Copy(imageLocation, path);
                    }

                }
                else
                {
                    p.image = service.find(p.id_produit).image;
                }

                p.nom = textBoxNom.Text.Trim();
                p.id_fournisseur = service.findFournisseurByName
                    (comboBoxFournisseur.SelectedItem.ToString()).id_fournisseur;
                p.prix_vente = decimal.Parse(textBoxPrix.Text);
                p.date_ajout = DateTime.Now;
                p.date_expiration = dateTimePickerExpiration.Value;
                if (p.id_produit == 0)
                {
                    p.quantite = 0;
                    service.add(p);
                    MessageBox.Show("Le produit est ajouté à la base de donnée",
                        "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Close();
                }
                else
                {
                    p.quantite = int.Parse(textBoxQuantite.Text);
                    service.edit(p);
                    MessageBox.Show("Le produit est modifié",
                        "Confirmation de modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                this.principalForm.ShowProducts();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                dialog.Filter = "jpg files(*.jpg)|*.JPG| PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insersion de l'image", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            AjouterFournisseur af = new AjouterFournisseur(0);
            af.Show();
            comboBoxFournisseur.Items.Add(af.textBoxNom.Text);
        }

    }
}
