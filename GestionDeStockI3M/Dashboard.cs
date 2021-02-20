using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.VenteService;
using GestionDeStockI3M.ProduitService;
using GestionDeStockI3M.CommandeService;
using GestionDeStockI3M.DashboardService;
using System.Linq;



namespace GestionDeStockI3M
{
    public partial class Dashboard : Form
    {

        DashboardServiceWCFClient da = new DashboardServiceWCFClient();
        public Dashboard()
        {
            InitializeComponent();
        }

        Stat_jour jr = new Stat_jour();
        Stat_mois mois = new Stat_mois();
        Stat_annee annee = new Stat_annee();
        Stat_semaine semaine= new Stat_semaine();

        private void ShowChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    

         private void btnSemaine_Click(object sender, EventArgs e)
         {
            ShowChildForm(semaine);
        }

        private void btnJour_Click(object sender, EventArgs e)
        {
            ShowChildForm(jr);

        }

        private void btnMois_Click(object sender, EventArgs e)
        {
            ShowChildForm(mois);
        }

        private void btnAnnee_Click(object sender, EventArgs e)
        {
            ShowChildForm(annee);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        /* private void Dashboard_Load(object sender, EventArgs e)
         {

             chart_nb_vente.Visible = false;
             nb.Visible = false;
             gain.Visible = false;
             perte.Visible = false;
             label1.Visible = false;
             label2.Visible = false;
             label3.Visible = false;
             label5.Visible = false;
             des.Visible = false;
             comboBox1.Visible = false;
             button1.Visible = false;
             label4.Visible = false;
             dateTimePicker1.Visible = false;

             btnSearch.Visible = false;
             btnSearch3.Visible = false;
             comboBoxYear.Visible = false;

         }

         private void btnJour_Click(object sender, EventArgs e)
         {
             button1.Visible = false;
             comboBox1.Visible = false;
             label4.Visible = true;
             dateTimePicker1.Visible = true;
             btnSearch.Visible = true;
             chart_nb_vente.Visible = true;

         }

         private void chart1_Click(object sender, EventArgs e)
         {

         }

         private void btnMois_Click(object sender, EventArgs e)
         {
             label4.Visible = false;
             dateTimePicker1.Visible = false;
             btnSearch.Visible = false;
             comboBox1.Visible = true;
             button1.Visible = true;

             DashboardServiceWCFClient d = new DashboardServiceWCFClient();
             ProduitServiceWCFClient pr = new ProduitServiceWCFClient();
             VenteServiceWCFClient vente = new VenteServiceWCFClient();

             List<VenteService.Vente> list = new List<VenteService.Vente>();


             foreach (var item in chart_nb_vente.Series)
             {
                 item.Points.Clear();
             }
             chart_nb_vente.Series["ventes"].Points.AddXY("Janvier", d.QuantiteMonth(1));
             chart_nb_vente.Series["ventes"].Points.AddXY("Février", d.QuantiteMonth(2));
             chart_nb_vente.Series["ventes"].Points.AddXY("Mars", d.QuantiteMonth(3));
             chart_nb_vente.Series["ventes"].Points.AddXY("Avril", d.QuantiteMonth(4));
             chart_nb_vente.Series["ventes"].Points.AddXY("Mai", d.QuantiteMonth(5));
             chart_nb_vente.Series["ventes"].Points.AddXY("Juin", d.QuantiteMonth(6));
             chart_nb_vente.Series["ventes"].Points.AddXY("Juillet", d.QuantiteMonth(7));
             chart_nb_vente.Series["ventes"].Points.AddXY("Aout", d.QuantiteMonth(8));
             chart_nb_vente.Series["ventes"].Points.AddXY("Septembre", d.QuantiteMonth(9));
             chart_nb_vente.Series["ventes"].Points.AddXY("Octobre", d.QuantiteMonth(10));
             chart_nb_vente.Series["ventes"].Points.AddXY("Novembre", d.QuantiteMonth(11));
             chart_nb_vente.Series["ventes"].Points.AddXY("Décembre", d.QuantiteMonth(12));

             chart_nb_vente.Visible = true;

         }

         private void gain_Click(object sender, EventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
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
                 if ( comboBox1.Text== item.m)
                 {
                     nb.Visible = true;
                     gain.Visible = true;
                     perte.Visible = true;
                     label1.Visible = true;
                     label2.Visible = true;
                     label3.Visible = true;
                     DashboardServiceWCFClient d = new DashboardServiceWCFClient();
                     int n = d.nb_venteByMonth(item.mn);

                     int g = d.gain_month(item.mn);

                     int p = d.perte();
                     nb.Text = Convert.ToString(n);
                     gain.Text = Convert.ToString(g);
                     perte.Text = Convert.ToString(p);
                 }

             }


         }

         private void button2_Click(object sender, EventArgs e)
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

             int n = d.nb_ventes(dateTimePicker1.Value.Date);

             int g = d.gain_tout(dateTimePicker1.Value.Date);

             int p = d.perte();
             nb.Text = Convert.ToString(n);
             gain.Text = Convert.ToString(g);
             perte.Text = Convert.ToString(p);

             List<VenteService.Vente> l = new List<VenteService.Vente>(); 
             d.findnow(dateTimePicker1.Value.Date);

             foreach (var item in chart_nb_vente.Series)
             {
                 item.Points.Clear();
             }

             foreach (var item in d.findnow(dateTimePicker1.Value.Date))
             {

                 chart_nb_vente.Series["ventes"].Points.AddXY( Convert.ToInt32( item.id_produit), d.qu(Convert.ToInt32(item.id_produit),dateTimePicker1.Value.Date));
             }

         }

         private void btnAnnee_Click(object sender, EventArgs e)
         {
             nb.Visible = false;
             gain.Visible = false;
             perte.Visible = false;
             label1.Visible = false;
             label2.Visible = false;
             label3.Visible = false;
             label5.Visible = false;
             des.Visible = false;
             comboBox1.Visible = false;
             button1.Visible = false;
             label4.Visible = false;
             dateTimePicker1.Visible = false;
             btnSearch.Visible = false;


             btnSearch3.Visible = true;
             comboBoxYear.Visible = true;
             chart_nb_vente.Visible = true;

             VenteServiceWCFClient vente = new VenteServiceWCFClient();
             List<int> year = new List<int>();
             int i = 1;


             /*year.Add(2000);
              * while (i <= vente.listeVente().Length)
             {
                 year.Add(Convert.ToDateTime(vente.find(i).date_ajout).Year);
                 if (i==3)
                 {
                     if (year[i] == year[i+1])
                     {
                      year.Remove(i);
                     }
                 }
                 i++;
             }*/

        //int i = 0;
        /*while(i <= vente.listeVente().Length)
        {
            year += vente.find(i).date_ajout.Year;
            i++;
        }*/
        /* foreach (VenteService.Vente v in vente.listeVente())
         {
             if (!comboBoxYear.Items.Contains(Convert.ToDateTime(v.date_ajout).Year))
             {
                 comboBoxYear.Items.Add(Convert.ToDateTime(v.date_ajout).Year);
             }
         }

         //label6.Text = comboBoxYear.Items.Count;
         //chart_nb_vente.DataSource = vente.listeVente();

         foreach( VenteService.Vente ve in vente.listeVente())
         {
             chart_nb_vente.Series["ventes"].Points.AddXY(ve.date_ajout.Value.Year,da.QuantiteYear(ve.date_ajout.Value.Year)); 
         }

     }

     private void btnSearch3_Click(object sender, EventArgs e)
     {
         nb.Visible = true;
         gain.Visible = true;
         perte.Visible = true;
         des.Visible = true;
         label1.Visible = true;
         label2.Visible = true;
         label3.Visible = true;
         label5.Visible = true;

         if (comboBoxYear.Text =="")
         {
             MessageBox.Show("Veuillez Choisir une année !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {

             nb.Text = Convert.ToString(da.nb_venteByYear(Convert.ToInt32(comboBoxYear.SelectedItem)));
         }
     }*/

    }
}
