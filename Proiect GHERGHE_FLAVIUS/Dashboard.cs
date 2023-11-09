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
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            NumaraCategorie();
            NumaraFurnizori();
            TopComanda();

        }


        private void NumaraCategorie()
        {
            var count = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Categorii.xml").XPathSelectElements("//Categorie").Count();
            CatLbl.Text = count.ToString();
        }

        private void NumaraFurnizori()
        {
            var count = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Furnizori.xml").XPathSelectElements("//Nume").Count();
            FurLbl.Text = count.ToString();
        }

        private void TopComanda()
        {
            var max = XDocument.Load("D:\\facultate\\TTV\\Proiect XML GHERGHE_FLAVIUS\\Proiect GHERGHE_FLAVIUS\\Comenzi.xml").XPathSelectElements("//Suma").Max();

            TopComandaLbl.Text = max.ToString();

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

        private void CatLbl_Click(object sender, EventArgs e)
        {

        }
    }
}