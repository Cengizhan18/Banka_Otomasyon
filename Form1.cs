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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmkayıtol fr = new Frmkayıtol();
            fr.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmsifreal fr = new Frmsifreal();
            fr.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblMusteri Where hesapno=@p1 and sifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtmustreino.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frmhesapdetay2 fr = new Frmhesapdetay2();
                fr.hesap = txtmustreino.Text;
                fr.Show();
                this.Hide();
            }



        }
    }
}
