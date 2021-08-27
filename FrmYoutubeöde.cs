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
    public partial class FrmYoutubeöde : Form
    {
        public FrmYoutubeöde()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblHesap set hesap=hesap-@p1 where hesapno=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse(textBox3.Text));
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Faturanız Başaarıyla Ödendi");

        }
    }
}
