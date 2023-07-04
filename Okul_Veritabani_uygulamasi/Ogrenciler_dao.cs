using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
namespace Okul_Veritabani_uygulamasi
{
    public class Ogrenciler_dao
    {

        public List<Ogrenci> tum_ogrenciler()
        {
            List<Ogrenci> ogrenci_listem = new List<Ogrenci>();
            SqlConnection bag = new Veritabani_yardimcisi().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from ogrenciler order by ad_soyad", bag);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                Ogrenci yeni_ogr = new Ogrenci()
                {
                    og_no = Convert.ToInt32(oku["og_no"]),
                    ad_soyad = oku["ad_soyad"].ToString(),
                    adres = oku["adres"].ToString(),
                    dog_tar = Convert.ToDateTime(oku["dog_tar"])
                };
                ogrenci_listem.Add(yeni_ogr);
            }

            oku.Close();

            bag.Close();
            return ogrenci_listem;
        }

        public  int  ogrenci_sil(int og_no)
        {
            int sayi = 0;
            SqlConnection bag = new Veritabani_yardimcisi().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "delete from ogrenciler where og_no=" + og_no;
            sayi=komut.ExecuteNonQuery();


            bag.Close();
            return sayi;
        }

        public int ogrenci_kaydet(Ogrenci yeni_ogr)
        {
            int sayi = 0;
            SqlConnection bag = new Veritabani_yardimcisi().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "insert into ogrenciler (og_no,dog_tar,ad_soyad,adres) " +
                "values (@og_no,@dog_tar,@ad_soyad,@adres)";
            komut.Parameters.AddWithValue("og_no", yeni_ogr.og_no);
            komut.Parameters.AddWithValue("ad_soyad", yeni_ogr.ad_soyad);
            komut.Parameters.AddWithValue("dog_tar", yeni_ogr.dog_tar);
            komut.Parameters.AddWithValue("adres", yeni_ogr.adres);
            sayi=komut.ExecuteNonQuery();


            bag.Close();
            return sayi;
        }

        public Ogrenci tek_ogrenci_getir(int og_no)
        {
            SqlConnection bag = new Veritabani_yardimcisi().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "select * from ogrenciler where og_no=@og_no";
            komut.Parameters.AddWithValue("og_no", og_no);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            Ogrenci bulunan_ogrenci = new Ogrenci()
            {
                og_no = Convert.ToInt32(oku["og_no"]),
                ad_soyad = oku["ad_soyad"].ToString(),
                adres = oku["adres"].ToString(),
                dog_tar = Convert.ToDateTime(oku["dog_tar"])
            };
            oku.Close();
            bag.Close();
            return bulunan_ogrenci;
        }

        public int  ogrenci_guncelle(Ogrenci yeni_ogr)
        {
            int sayi = 0;
            SqlConnection bag = new Veritabani_yardimcisi().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "update ogrenciler set ad_soyad=@ad_soyad,dog_tar=@dog_tar,adres=@adres " +
                "where og_no=@og_no";
            komut.Parameters.AddWithValue("og_no", yeni_ogr.og_no);
            komut.Parameters.AddWithValue("ad_soyad", yeni_ogr.ad_soyad);
            komut.Parameters.AddWithValue("dog_tar", yeni_ogr.dog_tar);
            komut.Parameters.AddWithValue("adres", yeni_ogr.adres);
            sayi = komut.ExecuteNonQuery();
            bag.Close();
            return sayi;
        }
    }
}