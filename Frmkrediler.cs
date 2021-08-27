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
    public partial class Frmkrediler : Form
    {
        public Frmkrediler()
        {
            InitializeComponent();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap6;

        void kredim()
        {
            SqlCommand komut = new SqlCommand("Select * from Tblhesap where hesapno=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label6.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[4].ToString();

            }
            bgl.baglanti().Close();


        }
        private void Frmkrediler_Load(object sender, EventArgs e)
        {
            label6.Text = hesap6;

            kredim();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm10bin fr = new frm10bin();
            fr.hesap7 = label6.Text;
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm100bin fr = new Frm100bin();
            fr.hesap8 = label6.Text;
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm500bin fr = new Frm500bin();
            fr.hesap9 = label6.Text;
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update TblHesap set kredi=kredi-@m1 where hesapno=@m2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@m1", textBox1.Text);
            komut1.Parameters.AddWithValue("@m2", label6.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kredi Borcunuz Ödendi");

            kredim();
        }
    }
}
