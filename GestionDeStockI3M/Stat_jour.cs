using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStockI3M.DashboardService;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.VenteService;

namespace GestionDeStockI3M
{
    public partial class Stat_jour : Form
    {
        public Stat_jour()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnJour_Click(object sender, EventArgs e)
        {
            chart_nb_vente.Visible = true;
            nb.Visible = true;
            gain.Visible = true;
            perte.Visible = true;
            des.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            //String date = dateTimePicker1.Value.ToShortDateString();

            DashboardServiceWCFClient d = new DashboardServiceWCFClient();
            ProduitServiceWCFClient pr = new ProduitServiceWCFClient();
            VenteServiceWCFClient vente = new VenteServiceWCFClient();
            int v = vente.nbVente(dateTimePicker1.Value.Date);
            if (v != 0)
            {
                int n = d.nb_ventes(dateTimePicker1.Value.Date);

                int g = d.gain_tout(dateTimePicker1.Value.Date);

                int p = d.perte(dateTimePicker1.Value.Date);
                int a = d.nbr_achat(dateTimePicker1.Value.Date);
                nb.Text = Convert.ToString(n);
                gain.Text = Convert.ToString(g);
                perte.Text = Convert.ToString(p);
                achat.Text = Convert.ToString(a);
                List<VenteService.Vente> l = new List<VenteService.Vente>();
                d.findnow(dateTimePicker1.Value.Date);

                foreach (var item in chart_nb_vente.Series)
                {
                    item.Points.Clear();
                }

                foreach (var item in pr.findAll())
                {

                    chart_nb_vente.Series["ventes"].Points.AddXY(d.name_prod(Convert.ToInt32(item.id_produit)), d.qu(Convert.ToInt32(item.id_produit), dateTimePicker1.Value.Date));
                }
            }
            else
            {
                MessageBox.Show("Aucun vente  n'a été effectuer en cette date!!");
            }
        }

        private void perte_Click(object sender, EventArgs e)
        {

        }

        private void achat_Click(object sender, EventArgs e)
        {

        }
    }
}
