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
    public partial class FrmDoviz : Form
    {
        public FrmDoviz()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap9;

        void doviz()
        {
            SqlCommand komut = new SqlCommand("Select * from TblHesap where hesapno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label21.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label17.Text = dr[2].ToString();
                label19.Text = dr[3].ToString();
            }
        }
        private void FrmDoviz_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dövizOfisiDataSet6.TblDoviz' table. You can move, or remove it, as needed.
            //this.tblDovizTableAdapter6.Fill(this.dövizOfisiDataSet6.TblDoviz);
            label21.Text = hesap9;
            doviz();
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);


            string dolaral = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaral.Text = dolaral;


            string dolarsat = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsat.Text = dolarsat;

            string euroal = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroal.Text = euroal;

            string eurosat = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosat.Text = eurosat;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaral.Text;
            txtkur2.Text = lbldolaral.Text;
            label20.Text = "Dolar Al";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsat.Text;
            txtkur2.Text = lbldolarsat.Text;
            label20.Text = "Dolar Sat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroal.Text;
            txtkur2.Text = lbleuroal.Text;
            label20.Text = "Euro Al";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosat.Text;
            txtkur2.Text = lbleurosat.Text;
            label20.Text = "Euro Sat";

        }
       

        private void txtmiktar2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(txtkur2.Text);
                int miktar = Convert.ToInt32(txtmiktar2.Text);
                int toplam = Convert.ToInt32(miktar / kur);
                double kalan = miktar % kur;
                txtkalan2.Text = kalan.ToString();

                label22.Text = (miktar - kalan).ToString();


                txttoplam2.Text = toplam.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show(" ");
            }


        }

        private void txttoplam2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                


                if (label20.Text=="Dolar Al")
                {
                    SqlCommand komut = new SqlCommand("Update Tblhesap set dolar=dolar+@p1,hesap=hesap-@p2 where hesapno=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", decimal.Parse(txttoplam2.Text));
                    komut.Parameters.AddWithValue("@p2", decimal.Parse(label22.Text));
                    komut.Parameters.AddWithValue("@p3", label21.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Almış Olduğunuz Dolar Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur2.Text = "0";
                    txttoplam2.Text="0";
                    txtmiktar2.Text="0";
                   
                }
                if(label20.Text=="Euro Al")
                {
                    SqlCommand komut1 = new SqlCommand("Update Tblhesap set euro=euro+@p1,hesap=hesap-@p2 where hesapno=@p3", bgl.baglanti());
                    komut1.Parameters.AddWithValue("@p1", decimal.Parse(txttoplam2.Text));
                    komut1.Parameters.AddWithValue("@p2", decimal.Parse(label22.Text));
                    komut1.Parameters.AddWithValue("@p3", label21.Text);
                    komut1.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Almış Olduğunuz Euro Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur2.Text = "0";
                    txttoplam2.Text = "0";
                    txtmiktar2.Text = "0";                   
                }
                 if(label20.Text=="Dolar Sat")
                {
                    SqlCommand komut1 = new SqlCommand("Update Tblhesap set dolar=dolar-@p1,hesap=hesap+@p2 where hesapno=@p3", bgl.baglanti());
                    komut1.Parameters.AddWithValue("@p1", decimal.Parse(txttoplam2.Text));
                    komut1.Parameters.AddWithValue("@p2", decimal.Parse(label22.Text));
                    komut1.Parameters.AddWithValue("@p3", label21.Text);
                    komut1.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Satmış Olduğunuz Dolar Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur2.Text = "0";
                    txttoplam2.Text = "0";
                    txtmiktar2.Text = "0";                   
                }
                  if(label20.Text=="Euro Sat")
                {
                    SqlCommand komut1 = new SqlCommand("Update Tblhesap set euro=euro-@p1,hesap=hesap+@p2 where hesapno=@p3", bgl.baglanti());
                    komut1.Parameters.AddWithValue("@p1", decimal.Parse(txttoplam2.Text));
                    komut1.Parameters.AddWithValue("@p2", decimal.Parse(label22.Text));
                    komut1.Parameters.AddWithValue("@p3", label21.Text);
                    komut1.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Satmış Olduğunuz Euro Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur2.Text = "0";
                    txttoplam2.Text = "0";
                    txtmiktar2.Text = "0";                   
                }
                doviz();


            }
            catch (Exception)
            {

                MessageBox.Show(" ");
            }
        }

        private void txtkur2_TextChanged(object sender, EventArgs e)
        {
            txtkur2.Text = txtkur2.Text.Replace(".", ",");
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if(label20.Text=="Dolar Al")
                {
                    SqlCommand komut = new SqlCommand("Update TblHEsap set dolar=dolar+@p1,hesap=hesap-@p2 where hesapno=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1",decimal.Parse(  txtmiktar.Text));
                    komut.Parameters.AddWithValue("@p2",decimal.Parse( txttoplam.Text));
                    komut.Parameters.AddWithValue("@p3", label21.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Almış Olduğunuz Dolar Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur.Text = "0";
                    txttoplam.Text = "0";
                    txtmiktar.Text = "0";
                }
                if(label20.Text=="Euro Al")
                {
                    SqlCommand komut = new SqlCommand("Update TblHEsap set euro=euro+@p1,hesap=hesap-@p2 where hesapno=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1",decimal.Parse(  txtmiktar.Text));
                    komut.Parameters.AddWithValue("@p2",decimal.Parse( txttoplam.Text));
                    komut.Parameters.AddWithValue("@p3", label21.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Almış Olduğunuz Euro Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur.Text = "0";
                    txttoplam.Text = "0";
                    txtmiktar.Text = "0";
                }
                if(label20.Text=="Dolar Sat")
                { 
                    SqlCommand komut = new SqlCommand("Update TblHEsap set dolar=dolar-@p1,hesap=hesap+@p2 where hesapno=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1",decimal.Parse(  txtmiktar.Text));
                    komut.Parameters.AddWithValue("@p2",decimal.Parse( txttoplam.Text));
                    komut.Parameters.AddWithValue("@p3", label21.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Satmış Olduğunuz Dolar Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur.Text = "0";
                    txttoplam.Text = "0";
                    txtmiktar.Text = "0";
                }
                 if(label20.Text=="Euro Sat")
                { 
                    SqlCommand komut = new SqlCommand("Update TblHEsap set euro=euro-@p1,hesap=hesap+@p2 where hesapno=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1",decimal.Parse(  txtmiktar.Text));
                    komut.Parameters.AddWithValue("@p2",decimal.Parse( txttoplam.Text));
                    komut.Parameters.AddWithValue("@p3", label21.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Satmış Olduğunuz Euro Miktarı Hesabınıza Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkur.Text = "0";
                    txttoplam.Text = "0";
                    txtmiktar.Text = "0";
                }

                doviz();
            }
            catch (Exception)
            {

                MessageBox.Show(" ");

            }
        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(txtkur.Text);
                int miktar = Convert.ToInt32(txtmiktar.Text);
                double toplam = kur * miktar;
                txttoplam.Text = toplam.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show(" ");
            }
        }
    }
}
