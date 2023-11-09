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

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Furnizori : Form
    {
        public Furnizori()
        {
            InitializeComponent();

        }



        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Furnizori";
            dt.Columns.Add("Nume");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Adresa");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in FurnizoriAfisare.Rows)
            {
                DataRow row = ds.Tables["Furnizori"].NewRow();
                row["Nume"] = r.Cells[0].Value;
                row["Telefon"] = r.Cells[1].Value;
                row["Adresa"] = r.Cells[2].Value;
                ds.Tables["Furnizori"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Furnizori.xml");
        }

        private void FurnizoriAfisare_MouseClick(object sender, MouseEventArgs e)
        {
            NumeFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[0].Value.ToString();
            TelefonFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[1].Value.ToString();
            AdresaFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            FurnizoriAfisare.SelectedRows[0].Cells[0].Value = NumeFurnizorTb.Text;
            FurnizoriAfisare.SelectedRows[0].Cells[1].Value = TelefonFurnizorTb.Text;
            FurnizoriAfisare.SelectedRows[0].Cells[2].Value = AdresaFurnizorTb.Text;

            TexteGoale();

        }
        private void StergeBtn_Click(object sender, EventArgs e)
        {
            FurnizoriAfisare.Rows.RemoveAt(FurnizoriAfisare.SelectedRows[0].Index);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Furnizori Obj = new Furnizori();
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
            int n = FurnizoriAfisare.Rows.Add();
            FurnizoriAfisare.Rows[n].Cells[0].Value = NumeFurnizorTb.Text;
            FurnizoriAfisare.Rows[n].Cells[1].Value = TelefonFurnizorTb.Text;
            FurnizoriAfisare.Rows[n].Cells[2].Value = AdresaFurnizorTb.Text;

            TexteGoale();
        }

        private void TexteGoale()
        {
            NumeFurnizorTb.Text = "";
            TelefonFurnizorTb.Text = "";
            AdresaFurnizorTb.Text = "";
        }

        private void IncarcaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Furnizori.xml");
            FurnizoriAfisare.Rows.Clear();
            foreach (DataRow item in ds.Tables["Furnizori"].Rows)
            {
                int n = FurnizoriAfisare.Rows.Add();
                FurnizoriAfisare.Rows[n].Cells[0].Value = item[0];
                FurnizoriAfisare.Rows[n].Cells[1].Value = item[1];
                FurnizoriAfisare.Rows[n].Cells[2].Value = item[2];

            }
        }
    }
}