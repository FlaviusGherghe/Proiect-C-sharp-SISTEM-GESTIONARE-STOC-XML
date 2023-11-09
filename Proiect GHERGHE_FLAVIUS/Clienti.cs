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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();

        }






        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Clienti";
            dt.Columns.Add("Nume");
            dt.Columns.Add("Gen");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Adresa");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in ClientiAfisare.Rows)
            {
                DataRow row = ds.Tables["Clienti"].NewRow();
                row["Nume"] = r.Cells[0].Value;
                row["Gen"] = r.Cells[1].Value;
                row["Telefon"] = r.Cells[2].Value;
                row["Adresa"] = r.Cells[3].Value;
                ds.Tables["Clienti"].Rows.Add(row);
            }
            ds.WriteXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Clienti.xml");

        }

        private void ClientiAfisare_MouseClick(object sender, MouseEventArgs e)
        {
            NumeClientTb.Text = ClientiAfisare.SelectedRows[0].Cells[0].Value.ToString();
            GenTb.SelectedItem = ClientiAfisare.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = ClientiAfisare.SelectedRows[0].Cells[2].Value.ToString();
            AdresaTb.Text = ClientiAfisare.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void TexteGoale()
        {
            NumeClientTb.Text = "";
            GenTb.SelectedItem.ToString();
            TelefonTb.Text = "";
            AdresaTb.Text = "";
        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            ClientiAfisare.SelectedRows[0].Cells[0].Value = NumeClientTb.Text;
            ClientiAfisare.SelectedRows[0].Cells[1].Value = GenTb.SelectedItem.ToString();
            ClientiAfisare.SelectedRows[0].Cells[2].Value = TelefonTb.Text;
            ClientiAfisare.SelectedRows[0].Cells[3].Value = AdresaTb.Text;

            TexteGoale();
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            ClientiAfisare.Rows.RemoveAt(ClientiAfisare.SelectedRows[0].Index);
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

        private void Clienti_Load(object sender, EventArgs e)
        {

        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            int n = ClientiAfisare.Rows.Add();
            ClientiAfisare.Rows[n].Cells[0].Value = NumeClientTb.Text;
            ClientiAfisare.Rows[n].Cells[1].Value = GenTb.SelectedItem.ToString();
            ClientiAfisare.Rows[n].Cells[2].Value = TelefonTb.Text;
            ClientiAfisare.Rows[n].Cells[3].Value = AdresaTb.Text;

            TexteGoale();

        }

        private void IncarcaBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Clienti.xml");
            ClientiAfisare.Rows.Clear();
            foreach (DataRow item in ds.Tables["Clienti"].Rows)
            {
                int n = ClientiAfisare.Rows.Add();
                ClientiAfisare.Rows[n].Cells[0].Value = item[0];
                ClientiAfisare.Rows[n].Cells[1].Value = item[1];
                ClientiAfisare.Rows[n].Cells[2].Value = item[2];
                ClientiAfisare.Rows[n].Cells[3].Value = item[3];
            }
        }
    }
}
