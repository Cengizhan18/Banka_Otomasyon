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
    public partial class Frmbaslangic : Form
    {
        public Frmbaslangic()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Frmbaslangic_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 25)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
        }
    }
}
