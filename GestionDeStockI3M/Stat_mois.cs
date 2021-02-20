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
using GestionDeStockI3M.CommandeService;
namespace GestionDeStockI3M
{
    public partial class Stat_mois : Form
    {
        public Stat_mois()
        {
            InitializeComponent();
        }

        private void perte_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cherch_Click(object sender, EventArgs e)
        {
            DashboardServiceWCFClient d = new DashboardServiceWCFClient();
            ProduitServiceWCFClient pr = new ProduitServiceWCFClient();
            var l = new[]
                {
                   new {mn=1,m="Janvier"},
                   new {mn=2,m="Février"},
                   new {mn=3,m="Mars"},
                   new {mn=4,m="Avril"},
                   new {mn=5,m="Mai"},
                   new {mn=6,m="Juin"},
                   new {mn=7,m="Juillet"},
                   new {mn=8,m="Aout"},
                   new {mn=9,m="Septembre"},
                   new {mn=10,m="Octobre"},
                   new {mn=11,m="Novembre"},
                   new {mn=12,m="Décembre"},

               }.ToList();
            foreach (var item in l)
            {
                
                if (comboBox1.Text == item.m )
                {
                    int n = d.nb_venteByMonth(item.mn, Convert.ToInt32(comboBoxYears.Text));
                    if (n != 0)
                    {
                        foreach (var c in chart_nb_vente.Series)
                        {
                            c.Points.Clear();
                        }

                        foreach (var v in pr.findAll())
                        {

                            chart_nb_vente.Series["ventes"].Points.AddXY(d.name_prod(Convert.ToInt32(v.id_produit)), d.q_v_m(Convert.ToInt32(v.id_produit), item.mn, Convert.ToInt32(comboBoxYears.Text)));
                        }


                        int g = d.gain_month(item.mn, Convert.ToInt32(comboBoxYears.Text));

                        int p = d.perte_mois(item.mn, Convert.ToInt32(comboBoxYears.Text));
                        nb.Text = Convert.ToString(n);
                        gain.Text = Convert.ToString(g);
                        perte.Text = Convert.ToString(p);
                    }
                    else
                    {
                        MessageBox.Show("Aucun vente  n'a été effectuer en ce mois!!");
                    }
                }
               

                }

            }


        

        private void Stat_mois_Load(object sender, EventArgs e)
        {
            DashboardServiceWCFClient d = new DashboardServiceWCFClient();
            chart_nb_vente.Visible = true;
        }
    }
}