using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStockI3M.VenteService;
using GestionDeStockI3M.DashboardService;

namespace GestionDeStockI3M
{
    public partial class Stat_semaine : Form
    {
        DashboardServiceWCFClient da = new DashboardServiceWCFClient();

        public Stat_semaine()
        {
            InitializeComponent();
        }

        private void Stat_semaine_Load(object sender, EventArgs e)
        {
            VenteServiceWCFClient vente = new VenteServiceWCFClient();
            dateTimePicker1.MaxDate = DateTime.Now;

            foreach (VenteService.Vente ve in vente.listeVente())
            {
               // chart_vente.Series["ventes"].Points.AddXY(ve.date_ajout.Value.Date, da.QuantiteWeek(ve.date_ajout.Value.Date));
            }
        }

        private void chart_vente_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value.Date;
            DateTime dd = d.AddDays(7);


        }

    }
}
