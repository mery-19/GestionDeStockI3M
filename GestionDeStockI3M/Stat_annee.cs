using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using GestionDeStockI3M.VenteService;
using GestionDeStockI3M.DashboardService;
using GestionDeStockI3M.CommandeService;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.LigneCommandeService;

namespace GestionDeStockI3M
{
    public partial class Stat_annee : Form
    {
        DashboardServiceWCFClient da = new DashboardServiceWCFClient();
        public Stat_annee()
        {
            InitializeComponent();
        }

        private void Stat_annee_Load(object sender, EventArgs e)
        {
            panel1.Visible = false ;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            annee.Visible = false;
            chart_vente.Visible = false;
            comboBoxYear.Visible = false;
            search.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            //label5.Visible = false;
            nb.Visible = false;
            gain.Visible = false;
            perte.Visible = false;
            //achat.Visible = false;
            des.Visible = false;

            VenteServiceWCFClient vente = new VenteServiceWCFClient();
            foreach (VenteService.Vente v in vente.listeVente())
            {
                if (!comboBoxYear.Items.Contains(Convert.ToDateTime(v.date_ajout).Year))
                {
                    comboBoxYear.Items.Add(Convert.ToDateTime(v.date_ajout).Year);
                    comboBoxYear2.Items.Add(Convert.ToDateTime(v.date_ajout).Year);
                }
            }


            foreach (VenteService.Vente ve in vente.listeVente())
            {
                chart_vente.Series["ventes"].Points.AddXY(ve.date_ajout.Value.Year, da.QuantiteYear(ve.date_ajout.Value.Year));
            }

            CommandeServiceWCFClient com = new CommandeServiceWCFClient();
            chart_commande.Series["commandes"].Points.AddXY("Confirmés", com.commandeConfirme().Count());
            chart_commande.Series["commandes"].Points.AddXY("En Retard", com.commandeEnRetard().Count());
            chart_commande.Series["commandes"].Points.AddXY("En Cours", com.commandeEnCours().Count());

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(comboBoxYear.SelectedItem);
            if (comboBoxYear.Text == "")
            { MessageBox.Show("Veuillez Choisir une année !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
            else
            { nb.Text = Convert.ToString(da.nb_venteByYear(year)); }

            des.Text = Convert.ToString(da.nb_produit_des(DateTime.Now));

            gain.Text = Convert.ToString(da.gain_year(year).ToString("0.00"));

            perte.Text = Convert.ToString(da.perte_year(year).ToString("0.00"));

            //achat.Text = Convert.ToString(achat);
        }
        
        private void commande_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;

            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            /*LigneCommandeServiceWCFClient lcommande = new LigneCommandeServiceWCFClient();
            chart_commande.DataSource = lcommande.findLigne();
            chart_commande.Series["commandes"].XValueMember= "id_commande";
            chart_commande.Series["commandes"].YValueMembers = "prix_grossiste";
            chart_commande.DataBind();*/
            

        }
        
        private void vente_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            label1.Visible = true;
            annee.Visible = true;
            chart_vente.Visible = true;
            comboBoxYear.Visible = true;
            search.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            //label5.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            nb.Visible = true;
            gain.Visible = true;
            perte.Visible = true;
            des.Visible = true;
            //achat.Visible = true;

        }

        private void search2_Click(object sender, EventArgs e)
        {
            CommandeServiceWCFClient commande = new CommandeServiceWCFClient();
            //List<CommandeService.Commande>
            var com=commande.commandeConfirme().Concat(commande.commandeEnCours()).ToList();
            
            com = com.Concat(commande.commandeEnRetard()).ToList();
            var nb = 0;
            int s = 0;
            decimal p = 0;
            
            if(comboBoxYear2.Text != "") { 
                foreach ( var c in com)
                {
                    if (Convert.ToDateTime(c.date_commande).Year == Convert.ToInt32(comboBoxYear2.Text))
                    {//var pr = new List<ProduitService.Produit>();
                        s+= commande.GetProduitsOfCommande(c.id_commande).Count();
                        p+= commande.prixCommande(c.id_commande);
                        nb++;
                    }
                }
            }
            else
            {
              MessageBox.Show("Veuillez Choisir une année !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            decimal m = 0;
            if (nb!=0)
            {
               m = p / nb;
            }

            nb_com.Text = Convert.ToString(nb);
            nb_commande.Text = Convert.ToString(s);
            prix.Text = Convert.ToString(m.ToString("0.00"));
            prix_total.Text = Convert.ToString(p);

        }
    }
}
