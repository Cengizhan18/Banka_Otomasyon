using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon
{
    public partial class Frmhesapmakine : Form
    {
        char _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;
        public Frmhesapmakine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) 
            { 
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }

            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                lblekran.Text = "";

                _ekrantemizlenecekmi = false;
            }
            if (lblekran.Text == "0") lblekran.Text = " ";
            lblekran.Text += "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblekran.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi=true;
            _ilksayi = Convert.ToInt32(lblekran.Text);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
            {
                int ikincisayi = Convert.ToInt32(lblekran.Text);
                int sonuc;

                switch (_islem)
                {

                    case '+':
                        sonuc = _ilksayi + ikincisayi;
                        break;
                    case '-':
                        sonuc = _ilksayi - ikincisayi;
                        break;
                    case '*':
                        sonuc = _ilksayi * ikincisayi;
                        break;
                    case '/':
                        sonuc = _ilksayi / ikincisayi;
                        break;
                    default:
                        sonuc = 0;
                        break;

                }

                lblekran.Text = Convert.ToString(sonuc);
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
        }

        private void btncık_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblekran.Text);
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblekran.Text);
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblekran.Text);
        }
    }
}
