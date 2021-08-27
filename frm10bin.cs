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
    public partial class frm10bin : Form
    {
        public frm10bin()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap7;
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblHesap set hesap=hesap+@p1,kredi=kredi+@p2 where hesapno=@p3 and tc=@p4",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt10k.Text);
            komut.Parameters.AddWithValue("@p2", txtborc.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Krediniz Hesabınıza Tanımlanmıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frm10bin_Load(object sender, EventArgs e)
        {
            int ıstenen;
            double borc;
            ıstenen = Convert.ToInt32(txt10k.Text);
            borc=(ıstenen*1.2* 36/100)+ıstenen;
            txtborc.Text = borc.ToString();

            textBox1.Text = hesap7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
