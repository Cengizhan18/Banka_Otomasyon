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
namespace Banka_Otomasyon
{
    public partial class Frmkayıtol : Form
    {
        public Frmkayıtol()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = mskhesapno.Text;
            
            
            Random ran = new Random();

            int sayi = ran.Next(100000, 1000000);
            mskhesapno.Text = sayi.ToString();

            SqlCommand komut = new SqlCommand("Select hesapno from TblMusteri", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (s1 == dr[0].ToString())
                {
                    MessageBox.Show("Hesap No Mevcut Tekrar deneyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            bgl.baglanti().Close();
            


        }

        private void btnkatdol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tblmusteri (Ad,soyad,TC,Telefon,HesapNo,Mail,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
             komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
             komut.Parameters.AddWithValue("@p3", msktc.Text);
             komut.Parameters.AddWithValue("@p4", msktel.Text);
             komut.Parameters.AddWithValue("@p5", mskhesapno.Text);
             komut.Parameters.AddWithValue("@p6", txtmail.Text);
             komut.Parameters.AddWithValue("@p7", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("Insert into TblHesap (hesapno,tc) values (@m1,@m2)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@m1", mskhesapno.Text);
            komut1.Parameters.AddWithValue("@m2", msktc.Text);

            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Insert into Tblmus (ad,hesapno) values (@n1,@n2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@n1", txtad.Text);
            komut2.Parameters.AddWithValue("@n2", mskhesapno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("Siz de Artık Sosyal Bankacılık Ailesinden Birisiniz. Tebrikler!", "TEBRİKLER!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
