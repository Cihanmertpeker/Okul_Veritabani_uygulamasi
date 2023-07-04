using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul_Veritabani_uygulamasi
{
    public partial class ogrenci_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {if (Page.IsPostBack == false)///sayfa ilk kez geldiyse
            {
                int og_no = Convert.ToInt32(Request.QueryString["og_no"]);
                Ogrenci bulunan_ogr = new Ogrenciler_dao().tek_ogrenci_getir(og_no);
                og_no_txt.Text = bulunan_ogr.og_no.ToString();
                ad_soyad_txt.Text = bulunan_ogr.ad_soyad;
                dog_tar_txt.Text = bulunan_ogr.dog_tar.ToShortDateString();
                adres_txt.Text = bulunan_ogr.adres;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci yeni_ogr = new Ogrenci()
            {
                og_no = Convert.ToInt32(og_no_txt.Text),
                ad_soyad = ad_soyad_txt.Text,
                dog_tar = Convert.ToDateTime(dog_tar_txt.Text),
                adres = adres_txt.Text
            };
            int sayi = new Ogrenciler_dao().ogrenci_guncelle(yeni_ogr);
            if (sayi != 0) Response.Write("Kayıt değiştirildi");
            else Response.Write("Kayıt değiştirlemedi");
        }
    }
}