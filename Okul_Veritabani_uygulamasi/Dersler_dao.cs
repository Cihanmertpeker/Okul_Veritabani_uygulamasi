using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
namespace Okul_Veritabani_uygulamasi
{
    public class Dersler_dao
    {
        public List<Ders> tum_dersleri_getir()
        {
            List<Ders> ders_listesi= new List<Ders>();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=NTC;Initial Catalog=okul;Integrated Security=True";
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from dersler order by ders_adi";
            komut.Connection = baglanti;
            SqlDataReader oku= komut.ExecuteReader();
            while (oku.Read()==true)
            {
                Ders yeni_ders = new Ders()
                {
                     ders_no =Convert.ToByte(oku["ders_no"]),
                     ders_adi=oku["ders_adi"].ToString ()

                };
                ders_listesi.Add(yeni_ders);
            }//while
            oku.Close();
            baglanti.Close();
            return ders_listesi;
        }

    }
}