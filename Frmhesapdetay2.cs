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
    public partial class Frmhesapdetay2 : Form
    {
        public Frmhesapdetay2()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        public string hesap;

        void para()
        {
            SqlCommand komut1 = new SqlCommand("Select hesap from TblHesap where hesapno=@m1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@m1", hesap);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblhesap.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();
        }
        void liste()
        {
            SqlCommand komut = new SqlCommand("Select * from Tblhesap where hesapno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblhesapno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                label14.Text = dr[2].ToString();
                label16.Text = dr[3].ToString();
            }


        }

        private void Frmhesapdetay2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesap;


            SqlCommand komut = new SqlCommand("Select * from TblMusteri where hesapno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0].ToString();
                lblad.Text = dr[1].ToString();
                lblsoyad.Text = dr[2].ToString();
                lbltc.Text = dr[3].ToString();
                lblmail.Text = dr[6].ToString();
                lblmerhaba.Text = dr[1].ToString();

            }
            bgl.baglanti().Close();

            para();
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblMusteri where hesapno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frmbilgigümcelle fr = new Frmbilgigümcelle();
                fr.hesap2 = lblhesapno.Text;
                fr.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmnetflix fr = new Frmnetflix();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmYoutube fr = new FrmYoutube();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand k = new SqlCommand("Insert into Tblhareket (Ad,tutar,gelen) values (@w1,@w2,@w3)",bgl.baglanti());
            k.Parameters.AddWithValue("@w1", label7.Text);
            k.Parameters.AddWithValue("@w2",decimal.Parse( txtbakkiye.Text));
            k.Parameters.AddWithValue("@w3",true);
            k.ExecuteNonQuery();
            bgl.baglanti().Close();


            SqlCommand komut = new SqlCommand("Update TblHesap set hesap=hesap+@p1 where hesapno=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtbakkiye.Text));
            komut.Parameters.AddWithValue("@p2", hesap);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bakkiyeniz Başarıyla Güncellendi");
            txtbakkiye.Clear();
            para();
        }

        private void hESAPLARIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhesap fr = new Frmhesap();
            fr.hesap4 = lblhesapno.Text;
            fr.Show();
        }

        private void kARTIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmkart fr = new Frmkart();
            fr.hesap3 = lblhesapno.Text;
            fr.Show();
        }

        private void pARATRANSFERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParaTransfer fr = new FrmParaTransfer();
            fr.hesap5 = lblhesapno.Text;
            fr.Show();
        }

        private void kREDİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmkrediler fr = new Frmkrediler();
            fr.hesap6 = lblhesapno.Text;
            fr.Show();
        }

        private void dövizAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoviz fr = new FrmDoviz();
            fr.hesap9 = lblhesapno.Text;
            fr.Show();
        }

        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhesapmakine fr = new Frmhesapmakine();
            fr.Show();
        }

        private void iNTERNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmnetflix fr = new Frmnetflix();
            fr.Show();
        }

        private void nETFLİXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoutube fr = new FrmYoutube();
            fr.Show();
        }

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çIKIŞYAPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eLEKTRİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfatura fr = new Frmfatura();
            fr.Show();
        }

        private void dOĞALGAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfatura fr = new Frmfatura();
            fr.Show();
        }

        private void sUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfatura fr = new Frmfatura();
            fr.Show();
        }

        private void çIKIŞYAPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVarlıklarım fr = new FrmVarlıklarım();
            fr.hesap11 = lblhesapno.Text;
            fr.dolar = label14.Text;
            fr.euro = label16.Text;
            fr.lira = lblhesap.Text;
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand k = new SqlCommand("Insert into Tblhareket (Ad,tutar,giden) values (@w1,@w2,@w3)", bgl.baglanti());
            k.Parameters.AddWithValue("@w1", label7.Text);
            k.Parameters.AddWithValue("@w2", decimal.Parse(txtbakkiye.Text));
            k.Parameters.AddWithValue("@w3", true);
            k.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("Update TblHesap set hesap=hesap-@p1 where hesapno=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtbakkiye.Text));
            komut.Parameters.AddWithValue("@p2", hesap);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bakkiyeniz Başarıyla Güncellendi");
            txtbakkiye.Clear();
            para();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama Cengizhan Kahraman Tarafından Sosyal Bankacılık A.Ş. Adına Yapılmıştır. Uygulama Tamamen Müşteri Odaklı Olup Fazlaca İçerik ve Seçeneğe Sahiptir." +
                "\n"+"\n"+
                "Cengo Yazılım A.Ş.", "Merhaba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
