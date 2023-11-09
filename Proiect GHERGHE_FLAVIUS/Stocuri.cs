using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Stocuri : Form
    {
        public Stocuri()
        {
            InitializeComponent();

            Categorie();
            Furnizori();
        }

        private void ArataProduse()
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Stocuri_Load(object sender, EventArgs e)
        {
        }


        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");
        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Produse";
            dt.Columns.Add("Nume");
            dt.Columns.Add("Categorie");
            dt.Columns.Add("Cantitate");
            dt.Columns.Add("PretCumparare");
            dt.Columns.Add("PretVanzare");
            dt.Columns.Add("Data");
            dt.Columns.Add("Furnizori");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in ProduseAfisare.Rows)
            {
                DataRow row = ds.Tables["Produse"].NewRow();
                row["Nume"] = r.Cells[0].Value;
                row["Categorie"] = r.Cells[1].Value;
                row["Cantitate"] = r.Cells[2].Value;
                row["PretCumparare"] = r.Cells[3].Value;
                row["PretVanzare"] = r.Cells[4].Value;
                row["Data"] = r.Cells[5].Value;
                row["Furnizori"] = r.Cells[6].Value;
                ds.Tables["Produse"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Produse.xml");
        }

        private void ProduseAfisare_MouseClick(object sender, MouseEventArgs e)
        {
            NumeProdusTb.Text = ProduseAfisare.SelectedRows[0].Cells[0].Value.ToString();
            CategorieTb.SelectedItem = ProduseAfisare.SelectedRows[0].Cells[1].Value.ToString();
            CantitateTb.Text = ProduseAfisare.SelectedRows[0].Cells[2].Value.ToString();
            PretCumparareTb.Text = ProduseAfisare.SelectedRows[0].Cells[3].Value.ToString();
            PretVanzareTb.Text = ProduseAfisare.SelectedRows[0].Cells[4].Value.ToString();
            DataTb.Text = ProduseAfisare.SelectedRows[0].Cells[5].Value.ToString();
            FurnizoriTb.SelectedItem = ProduseAfisare.SelectedRows[0].Cells[6].Value.ToString();
        }
        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            ProduseAfisare.SelectedRows[0].Cells[0].Value = NumeProdusTb.Text;
            ProduseAfisare.SelectedRows[0].Cells[1].Value = CategorieTb.SelectedItem.ToString();
            ProduseAfisare.SelectedRows[0].Cells[2].Value = CantitateTb.Text;
            ProduseAfisare.SelectedRows[0].Cells[3].Value = PretCumparareTb.Text;
            ProduseAfisare.SelectedRows[0].Cells[4].Value = PretVanzareTb.Text;
            ProduseAfisare.SelectedRows[0].Cells[5].Value = DataTb.Value.Date;
            ProduseAfisare.SelectedRows[0].Cells[6].Value = FurnizoriTb.SelectedValue.ToString();

            TexteGoale();
        }
        private void StergeBtn_Click(object sender, EventArgs e)
        {
            ProduseAfisare.Rows.RemoveAt(ProduseAfisare.SelectedRows[0].Index);
        }
        private void Categorie()
        {

            var xmlDocument = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Categorii.xml", LoadOptions.None);
            var mainCategorii = from categorie in xmlDocument.Descendants("Categorie") select categorie.Value.Trim();
            CategorieTb.DataSource = mainCategorii.ToList();

        }

        private void Furnizori()
        {
            var xmlDocument = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Furnizori.xml", LoadOptions.None);
            var mainFurnizori = from furnizori in xmlDocument.Descendants("Nume") select furnizori.Value.Trim();
            FurnizoriTb.DataSource = mainFurnizori.ToList();
        }
        private void CategorieTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Clienti Obj = new Clienti();
            Obj.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Furnizori Obj = new Furnizori();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Stocuri Obj = new Stocuri();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Categorii Obj = new Categorii();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Comenzi Obj = new Comenzi();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Stocuri Obj = new Stocuri();
            Obj.Show();
            this.Hide();
        }
        private void CautareFiltruTextBox()
        {
            string searchValue = CautareTb.Text;
            ProduseAfisare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in ProduseAfisare.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            ProduseAfisare.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Nu am putut gasi" + CautareTb.Text, "Negasit");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void CautareBtn_Click(object sender, EventArgs e)
        {
            CautareFiltruTextBox();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ArataProduse();
            CautareTb.Text = "";
        }

        private void ProfitFiltruTextBox()
        {
            if (CautareCb.SelectedIndex == 1)
            {
                DataView pp = (ProduseAfisare.DataSource as DataTable).DefaultView;
                pp.RowFilter = string.Format("Produs = '{0}'", "Salam");
            }
        }

        private void CautareCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfitFiltruTextBox();
        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            int n = ProduseAfisare.Rows.Add();
            ProduseAfisare.Rows[n].Cells[0].Value = NumeProdusTb.Text;
            ProduseAfisare.Rows[n].Cells[1].Value = CategorieTb.SelectedItem.ToString();
            ProduseAfisare.Rows[n].Cells[2].Value = CantitateTb.Text;
            ProduseAfisare.Rows[n].Cells[3].Value = PretCumparareTb.Text;
            ProduseAfisare.Rows[n].Cells[4].Value = PretVanzareTb.Text;
            ProduseAfisare.Rows[n].Cells[5].Value = DataTb.Value.Date;
            ProduseAfisare.Rows[n].Cells[6].Value = FurnizoriTb.SelectedValue.ToString();

            TexteGoale();
        }

        private void TexteGoale()
        {
            NumeProdusTb.Text = "";
            CategorieTb.SelectedItem.ToString();
            CantitateTb.Text = "";
            PretCumparareTb.Text = "";
            PretVanzareTb.Text = "";
            DataTb.Value.Date.ToString();
            FurnizoriTb.SelectedValue.ToString();
        }

        private void IncarcaBtn_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Produse.xml");
            ProduseAfisare.Rows.Clear();
            foreach (DataRow item in ds.Tables["Produse"].Rows)
            {
                int n = ProduseAfisare.Rows.Add();
                ProduseAfisare.Rows[n].Cells[0].Value = item[0];
                ProduseAfisare.Rows[n].Cells[1].Value = item[1];
                ProduseAfisare.Rows[n].Cells[2].Value = item[2];
                ProduseAfisare.Rows[n].Cells[3].Value = item[3];
                ProduseAfisare.Rows[n].Cells[4].Value = item[4];
                ProduseAfisare.Rows[n].Cells[5].Value = item[5];
                ProduseAfisare.Rows[n].Cells[6].Value = item[6];
            }
        }

    }
}
