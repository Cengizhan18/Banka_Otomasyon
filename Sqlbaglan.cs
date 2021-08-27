using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Banka_Otomasyon
{
    class Sqlbaglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=SCARFACE\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuProjesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
