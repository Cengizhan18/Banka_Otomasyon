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
    public partial class Frmnetflix : Form
    {
        public Frmnetflix()
        {
            InitializeComponent();
        }
        int sayac;
        private void Frmnetflix_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 38)
            {
                timer1.Stop();
                sayac = 0;
                this.Hide();
                Frmnetflixfatura fr = new Frmnetflixfatura();
                fr.Show();
            }
        }
    }
}
