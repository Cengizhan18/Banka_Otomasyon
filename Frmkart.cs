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
    public partial class Frmkart : Form
    {
        public Frmkart()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string hesap3;
        private void Frmkart_Load(object sender, EventArgs e)
        {
            txthesapno.Text = hesap3;

            SqlCommand komut = new SqlCommand("Select * from TblMusteri where hesapno=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap3);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtadsoyad.Text=dr[1]+" "+dr[2];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            this.Hide();

        }
    }
}
