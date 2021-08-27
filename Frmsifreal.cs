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
    public partial class Frmsifreal : Form
    {
        public Frmsifreal()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();

        }

        private void btnkatdol_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update TblMusteri set Sifre=@p1 where ad=@p2 and soyad=@p3 and TC=@p4 and HesapNo=@p5 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtsifre.Text);
                komut.Parameters.AddWithValue("@p2", txtad.Text);
                komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p4", msktc.Text);
                komut.Parameters.AddWithValue("@p5", txthesap.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifreniz Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İşlem","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
