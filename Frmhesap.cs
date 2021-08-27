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
    public partial class Frmhesap : Form
    {
        public Frmhesap()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap4;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Frmhesap_Load(object sender, EventArgs e)
        {
            lblhesp.Text = hesap4;

            SqlCommand komut = new SqlCommand("Select * from TblHesap Where hesapno=@p1  ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap4);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblbakye.Text = dr[1].ToString();

            }
            bgl.baglanti().Close();


            SqlDataAdapter da = new SqlDataAdapter("Execute test7", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
