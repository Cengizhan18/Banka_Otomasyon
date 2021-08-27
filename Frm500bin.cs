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
    public partial class Frm500bin : Form
    {
        public Frm500bin()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap9;

        private void Frm500bin_Load(object sender, EventArgs e)
        {
            textBox1.Text = hesap9;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int alınan;
            alınan = Convert.ToInt32(comboBox1.Text);

            double borc = (alınan * 1.2 * 36 / 100) + alınan;
            txtborc.Text = borc.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand k = new SqlCommand("Update Tblhesap set hesap=+@p1,kredi=kredi+@p2 where hesapno=@p3 and tc=@p4",bgl.baglanti());
            k.Parameters.AddWithValue("@p1", comboBox1.Text);
            k.Parameters.AddWithValue("@p2", txtborc.Text);
            k.Parameters.AddWithValue("@p3", textBox1.Text);
            k.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            k.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Krediniz Hesabınıza Tanımlanmıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
