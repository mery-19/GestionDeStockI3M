using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.FournisseurService;

namespace GestionDeStockI3M
{
    public partial class AjouterFournisseur : Form
    {
        FournisseurServiceWCFClient f = new FournisseurServiceWCFClient();
        Fournisseurs frr = new Fournisseurs();
        Fournisseur fou = new Fournisseur();
        public AjouterFournisseur(int id)
        {
            fou.id_fournisseur = id;
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            fou.nom = textBoxNom.Text;
            fou.email = textBoxEmail.Text;
            fou.adresse = richTextBoxAdresse.Text;
            fou.phone = textBoxTel.Text;

            if (btnAjouter.Text == "Ajouter" && fou.id_fournisseur == 0)
            {
                if (textBoxEmail.Text == "" || textBoxNom.Text == "" || textBoxTel.Text == "" || richTextBoxAdresse.Text == "")
                {
                    MessageBox.Show("Vous devez  remplir tous les champs !!");
                }
                else
                {

                    if (fou.id_fournisseur > 0)
                    {
                        Fournisseurs frr = new Fournisseurs();
                        fou.id_fournisseur = frr.id_four;
                        f.add(fou);
                        MessageBox.Show("Fournisseur est ajouté !!");
                        frr.dataGridView1.DataSource = f.findAll();
                    }
                }


            }
            else
            {
                f.modifier(fou);
                MessageBox.Show("Fournisseur est modifié ");
                frr.dataGridView1.DataSource = f.findAll();
            }
        }
    }
    }

