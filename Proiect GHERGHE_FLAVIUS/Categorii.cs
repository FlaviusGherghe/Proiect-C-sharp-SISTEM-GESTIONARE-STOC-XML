using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Categorii : Form
    {
        public Categorii()
        {
            InitializeComponent();
            CountCat();
        }




        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Categorii";
            dt.Columns.Add("Categorie");

            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in CategoriiAfisare.Rows)
            {
                DataRow row = ds.Tables["Categorii"].NewRow();
                row["Categorie"] = r.Cells[0].Value;

                ds.Tables["Categorii"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Categorii.xml");
        }

        private void CategoriiAfisare_MouseClick(object sender, MouseEventArgs e)
        {
            CategorieTb.Text = CategoriiAfisare.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            CategoriiAfisare.SelectedRows[0].Cells[0].Value = CategorieTb.Text;


            TexteGoale();
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            CategoriiAfisare.Rows.RemoveAt(CategoriiAfisare.Rows[0].Index);
        }
        private void CountCat()
        {
            
            var count = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Categorii.xml").XPathSelectElements("//Categorie").Count();
            CategorieNumar.Text = count.ToString();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Categorii Obj = new Categorii();
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

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            int n = CategoriiAfisare.Rows.Add();
            CategoriiAfisare.Rows[n].Cells[0].Value = CategorieTb.Text;


            TexteGoale();
        }

        private void TexteGoale()
        {
            CategorieTb.Text = "";

        }

        private void IncarcaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Categorii.xml");
            CategoriiAfisare.Rows.Clear();
            foreach (DataRow item in ds.Tables["Categorii"].Rows)
            {
                int n = CategoriiAfisare.Rows.Add();
                CategoriiAfisare.Rows[n].Cells[0].Value = item[0];

            }
        }
    }
}

