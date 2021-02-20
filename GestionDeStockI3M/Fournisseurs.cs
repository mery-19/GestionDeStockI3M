using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionDeStockI3M.FournisseurService;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionDeStockI3M
{
    public partial class Fournisseurs : Form
    {
        private Button btnAjouter;
        private Button btnAfficher;
        private Button btnSupprimer;
        private TextBox textBoxRecherche;
        private Button btnRechercher;
        private Button btnExcel;
        private Button btnModifier;
        public int id_four = 0;
        public Fournisseurs()
        {
            InitializeComponent();
        }

      
        void Clear()
        {
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterFournisseur af = new AjouterFournisseur(0);
            af.Show();
        }

        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = false;
            FournisseurServiceWCFClient f = new FournisseurServiceWCFClient();
            dataGridView1.DataSource = f.findAll();
            Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            id_four = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            AjouterFournisseur af = new AjouterFournisseur(0);
            af.Text = "Modifier Fournisseur";
            af.btnAjouter.Text = "Modifier";
            af.textBoxNom.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            af.textBoxEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            af.textBoxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            af.richTextBoxAdresse.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            af.Show();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            AjouterFournisseur af = new AjouterFournisseur(0);
            af.Text = "Afficher Fournisseur";
            af.Controls.Remove(af.btnAjouter);
            af.btnAjouter.Dispose();
            af.textBoxNom.Enabled = false;
            af.textBoxEmail.Enabled = false;
            af.textBoxTel.Enabled = false;
            af.richTextBoxAdresse.Enabled = false;
            id_four = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            af.textBoxNom.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            af.textBoxEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            af.textBoxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            af.richTextBoxAdresse.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            af.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            /*  saveFileDialog1.InitialDirectory = "C:";
              saveFileDialog1.Title = "Save as Excel File";
              saveFileDialog1.FileName = "";
             */
            Excel._Application app = new Excel.Application();
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Feuil1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "FournisseurDetail";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            /* var saveFileDialoge1 = new SaveFileDialog();
             saveFileDialog1.FileName = "output";
             saveFileDialog1.DefaultExt = ".xlsx";
             if(saveFileDialog1.ShowDialog()==DialogResult.OK)
             {
                 workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
             }*/
            app.Columns.AutoFit();
            app.Visible = true;
            // app.Quit();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Fournisseur f = new Fournisseur();
            FournisseurServiceWCFClient client = new FournisseurServiceWCFClient();
            f.id_fournisseur = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (f.id_fournisseur > 0)
            {
                DialogResult answer = MessageBox.Show("Voulez vous vraiment supprimer le fournisseur ?",
                       "Supprimer fournisseur", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (answer)
                {
                    case DialogResult.Yes:
                        f.nom = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        f.phone = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        f.email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        f.adresse = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        client.delete(f.id_fournisseur);
                        MessageBox.Show("Fournisseur est supprimé");
                        dataGridView1.DataSource = client.findAll();
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            FournisseurServiceWCFClient client = new FournisseurServiceWCFClient();
            string nom = textBoxRecherche.Text;
            dataGridView1.DataSource = client.findNom(nom);
            if (textBoxRecherche.Text == " ")
            {
                dataGridView1.DataSource = client.findAll();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {

                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                AjouterFournisseur aj = new AjouterFournisseur(0);
            }
        }
    }
}
