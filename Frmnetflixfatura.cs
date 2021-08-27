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
    public partial class Frmnetflixfatura : Form
    {
        public Frmnetflixfatura()
        {
            InitializeComponent();
        }
        int sayac = 0;

        Sqlbaglan bgl = new Sqlbaglan();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frmnetflixfatura_Load(object sender, EventArgs e)
        {
            timer1.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 21)
            {
                piclacasede1.Visible = false;
                picturelacasede2.Visible = false;
                picturescarface2.Visible = true;
                picscarface1.Visible = true;
            }
            if (sayac == 42)
            {
                picturescarface2.Visible = false;
                picscarface1.Visible = false;
                picbreba.Visible = true;
                picprbre.Visible = true;

            }
            if (sayac == 63)
            {
                picbreba.Visible = false;
                picprbre.Visible = false;
                sayac = 0;
                piclacasede1.Visible = true;
                picturelacasede2.Visible = true;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(comboBox1.Text);
            textBox3.Text = (tutar * 7 / 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tblhesap set hesap=hesap-@p1 where hesapno=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",decimal.Parse( textBox3.Text));
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Faturanız Başarıyla Ödendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
