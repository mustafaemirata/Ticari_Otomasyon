using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
     class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=EMIR\SQLEXPRESS;Initial Catalog=DbTicariOtomasyon;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            return baglanti;    
        }





    }
}
