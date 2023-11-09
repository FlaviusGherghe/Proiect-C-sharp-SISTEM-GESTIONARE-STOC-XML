using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string FromXML_utl = "";
        public string FromXML_prl = "";

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string utl = UserTb.Text;
            string prl = ParolaTb.Text;

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\Login.xml");
            var selected_utl = from x in doc.Descendants("utilizatori").Where
                                      (x => (string)x.Element("NumeUtilizator") == UserTb.Text)
                                      select new
                                      {
                                          XMLutl = x.Element("NumeUtilizator").Value,
                                          XMLprl = x.Element("Parola").Value
                                      };
            foreach( var x in selected_utl)
            {
                FromXML_utl = x.XMLutl;
                FromXML_prl = x.XMLprl;
            }


            if (utl == FromXML_utl && prl == FromXML_prl)

            {
                Stocuri Obj = new Stocuri();
                Obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Nume de utilizator nevalid sau parola nevalida !");
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}