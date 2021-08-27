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
    public partial class Frmbilgigümcelle : Form
    {
        public Frmbilgigümcelle()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap2;
        private void Frmbilgigümcelle_Load(object sender, EventArgs e)
        {
            txtad.Text = hesap2;

            SqlCommand komut = new SqlCommand("Select * from TblMusteri where hesapno=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap2);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                msktel.Text = dr[4].ToString();
                txtmail.Text = dr[6].ToString();
                txtsifre.Text = dr[7].ToString();


            }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblMusteri set telefon=@p1,mail=@p2,sifre=@p3 where hesapno=@p4 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktel.Text);
            komut.Parameters.AddWithValue("@p2", txtmail.Text);
            komut.Parameters.AddWithValue("@p3", txtsifre.Text);
            komut.Parameters.AddWithValue("@p4", txtad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
