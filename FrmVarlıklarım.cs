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
using System.Data.SqlClient;

namespace Banka_Otomasyon
{
    public partial class FrmVarlıklarım : Form
    {
        public FrmVarlıklarım()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        public string hesap11,dolar,euro,lira;

       
       
        private void FrmVarlıklarım_Load(object sender, EventArgs e)
        {

            label7.Text = hesap11;

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);


            string dolaral = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaral.Text = dolaral;

            string euroal = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroal.Text = euroal;

            textBox1.Text = lbldolaral.Text;
            textBox2.Text = lbleuroal.Text;


            txtdolarmiktar.Text = dolar;
            txteuromiktar.Text = euro;
            label6.Text = lira;

            double kur = Convert.ToDouble(lbldolaral.Text);
            int dlr = Convert.ToInt32(txtdolarmiktar.Text);
            int toplam = Convert.ToInt32(dlr * kur/10000);
            lbldolartl.Text = toplam.ToString();
            
            double kur2 = Convert.ToDouble(lbleuroal.Text);
            int dlr2 = Convert.ToInt32(txteuromiktar.Text);
            int toplam2 = Convert.ToInt32(dlr2 * kur2/10000);
            lbleurotl.Text = toplam2.ToString();

            double tl = Convert.ToDouble(label6.Text);
            
           

            chart1.Series["Varlıklar"].Points.AddXY("Dolar", toplam.ToString());
              chart1.Series["Varlıklar"].Points.AddXY("Euro", toplam2.ToString());
           chart1.Series["Varlıklar"].Points.AddXY("TL", tl.ToString());

            chart2.Series["Varlıklar"].Points.AddXY("Dolar", toplam.ToString());
             chart2.Series["Varlıklar"].Points.AddXY("Euro", toplam2.ToString());




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbldolaral_Click(object sender, EventArgs e)
        {

        }

        private void lbleurotl_Click(object sender, EventArgs e)
        {

        }

        private void lbleurotl_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbldolartl_TextChanged(object sender, EventArgs e)
        {
            lbldolartl.Text = lbldolartl.Text.Replace(".", ",");
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(".", ",");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Replace(".", ",");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtdolarmiktar_TextChanged(object sender, EventArgs e)
        {
           
         
        }

        private void txteuromiktar_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
