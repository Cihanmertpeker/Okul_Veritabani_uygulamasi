using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Okul_Veritabani_uygulamasi
{
    public class Veritabani_yardimcisi
    {
        public SqlConnection baglantiya_gec()
        {
            SqlConnection bag = new SqlConnection("Data Source=NTC;Initial Catalog=okul;Integrated Security=True");
            return bag;
        }

    }
}