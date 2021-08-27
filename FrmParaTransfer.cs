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
    public partial class FrmParaTransfer : Form
    {
        public FrmParaTransfer()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        public string hesap5;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        void listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Execute bank", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmParaTransfer_Load(object sender, EventArgs e)
        {
            label3.Text = hesap5;

            SqlCommand komut = new SqlCommand("Select * from Tblhesap where hesapno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblhesap.Text = dr[1].ToString();
                

            }
            bgl.baglanti().Close();

             SqlCommand komut1 = new SqlCommand("Select * from Tblmus where hesapno=@l1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@l1", label3.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label5.Text = dr1[0].ToString();
                

            }
            bgl.baglanti().Close();

            listele();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblHesap set hesap=hesap-@p1 where hesapno=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txttutar.Text);
            komut.Parameters.AddWithValue("@p2", label3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand k = new SqlCommand("Insert into Tblparatransfer (gonderen,alan,miktar) values (@n1,@n2,@n3) ", bgl.baglanti());
            k.Parameters.AddWithValue("@n1", label5.Text);
            k.Parameters.AddWithValue("@n2", txtparaalan.Text);
            k.Parameters.AddWithValue("@n3",decimal.Parse( txttutar.Text));
            k.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("Update Tblhesap set hesap=hesap+@m1 where hesapno=@m2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@m1", txttutar.Text);
            komut1.Parameters.AddWithValue("@m2", txthesapno.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Para Transferiniz Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            listele();
        }
    }
}
