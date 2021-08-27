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
    public partial class FrmYoutube : Form
    {
        public FrmYoutube()
        {
            InitializeComponent();
        }

        private void FrmYoutube_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            say++;
            if (say == 20)
            {
                FrmYoutubeöde fr = new FrmYoutubeöde();
                fr.Show();
                this.Hide();
            }
        }
    }
}
