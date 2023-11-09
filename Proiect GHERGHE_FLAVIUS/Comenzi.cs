using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
            Client();
            Produs();


        }


        private void Client()
        {
            var xmlDocument = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Clienti.xml", LoadOptions.None);
            var mainCategorii = from client in xmlDocument.Descendants("Nume") select client.Value.Trim();
            ClientTb.DataSource = mainCategorii.ToList();
        }

        private void Produs()
        {
            var xmlDocument = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Produse.xml", LoadOptions.None);
            var mainCategorii = from client in xmlDocument.Descendants("Nume") select client.Value.Trim();
            ProduseTb.DataSource = mainCategorii.ToList();
        }

        private void ProdusNume()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Produse.xml");
            DataRow row = dataSet.Tables[0].AsEnumerable().Where(x => x.Field<string>("Nume") == ProduseTb.Text).FirstOrDefault();
            NumeProdusTb.Text = row["Nume"].ToString();
            PretTb.Text = row["PretVanzare"].ToString();

        }


        private void ProduseTb_SelectionChangeComitted(object sender, EventArgs e)
        {
            ProdusNume();
        }
       
        int LBLTotal = 0;
        private void AddFacturaBtn_Click(object sender, EventArgs e)
        {
            if (NumeProdusTb.Text == "" || CantitateTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatiile necesare");
            }
            else
            {
                int total = Convert.ToInt32(CantitateTb.Text) * Convert.ToInt32(PretTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ComenziAfisare);
               
                newRow.Cells[0].Value = NumeProdusTb.Text;
                newRow.Cells[1].Value = PretTb.Text;
                newRow.Cells[2].Value = CantitateTb.Text;
                newRow.Cells[3].Value = total;
                ComenziAfisare.Rows.Add(newRow);
                LBLTotal = LBLTotal + total;
                TotalLbl.Text = "Rezultat:" + LBLTotal;
                SumaTb.Text = "" + LBLTotal;
               
                ActualizeazaStoc();
                MessageBox.Show("Produs adaugat");

            }
        }

        private void ArataComenzi()
        {


        }


        private void ActualizeazaStoc()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Produse.xml");
            DataRow row = dataSet.Tables[0].AsEnumerable().Where(x => x.Field<string>("Nume") == ProduseTb.Text).FirstOrDefault();
            CantitateTb.Text = row["Cantitate"].ToString();
            ProduseTb.Text = row["Nume"].ToString();


        }
        private void ComandaBtn_Click(object sender, EventArgs e)
        {
            int n = ComenziAfisare2.Rows.Add();
            ComenziAfisare2.Rows[n].Cells[0].Value = ClientTb.Text;
            ComenziAfisare2.Rows[n].Cells[1].Value = UserTb.SelectedItem.ToString();
            ComenziAfisare2.Rows[n].Cells[2].Value = DataComandaTb.Value.Date;
            ComenziAfisare2.Rows[n].Cells[3].Value = SumaTb.Text;

            TexteGoale();


        }

        private void TexteGoale()
        {
            ClientTb.Text = "";
            UserTb.SelectedItem.ToString();
            DataComandaTb.Value.Date.ToString();
            SumaTb.Text = "";
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

        private void AnuleazaBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "ComenziFactura";
            dt.Columns.Add("Produse");
            dt.Columns.Add("NumeProdus");
            dt.Columns.Add("Pret");
            dt.Columns.Add("Cantitate");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in ComenziAfisare.Rows)
            {
                DataRow row = ds.Tables["ComenziFactura"].NewRow();
                row["Produse"] = r.Cells[0].Value;
                row["NumeProdus"] = r.Cells[1].Value;
                row["Pret"] = r.Cells[2].Value;
                row["Cantitate"] = r.Cells[3].Value;
                ds.Tables["ComenziFactura"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\ComenziFactura.xml");
        }

        private void IncarcaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Comenzi.xml");
            ComenziAfisare2.Rows.Clear();
            foreach (DataRow item in ds.Tables["Comenzi"].Rows)
            {
                int n = ComenziAfisare2.Rows.Add();
                ComenziAfisare2.Rows[n].Cells[0].Value = item[0];
                ComenziAfisare2.Rows[n].Cells[1].Value = item[1];
                ComenziAfisare2.Rows[n].Cells[2].Value = item[2];
                ComenziAfisare2.Rows[n].Cells[3].Value = item[3];

            }
        }

        private void IncarcaFacturaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\ComenziFactura.xml");
            ComenziAfisare.Rows.Clear();
            foreach (DataRow item in ds.Tables["ComenziFactura"].Rows)
            {
                int n = ComenziAfisare.Rows.Add();
                ComenziAfisare.Rows[n].Cells[0].Value = item[0];
                ComenziAfisare.Rows[n].Cells[1].Value = item[1];
                ComenziAfisare.Rows[n].Cells[2].Value = item[2];
                ComenziAfisare.Rows[n].Cells[3].Value = item[3];

            }
        }

        private void SalveazaComandaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Comenzi";
            dt.Columns.Add("Client");
            dt.Columns.Add("User");
            dt.Columns.Add("Data");
            dt.Columns.Add("Suma");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in ComenziAfisare2.Rows)
            {
                DataRow row = ds.Tables["Comenzi"].NewRow();
                row["Client"] = r.Cells[0].Value;
                row["User"] = r.Cells[1].Value;
                row["Data"] = r.Cells[2].Value;
                row["Suma"] = r.Cells[3].Value;
                ds.Tables["Comenzi"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Comenzi.xml");
        }
    }
}
