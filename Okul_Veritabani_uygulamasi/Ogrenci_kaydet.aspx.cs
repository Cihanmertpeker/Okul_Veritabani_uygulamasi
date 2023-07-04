using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul_Veritabani_uygulamasi
{
    public partial class Ogrenci_kaydet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci yeni_ogr = new Ogrenci()
            {
              og_no=Convert.ToInt32 (og_no_txt.Text),
              ad_soyad =ad_soyad_txt.Text ,
              dog_tar =Convert.ToDateTime (dog_tar_txt.Text),
                adres =adres_txt.Text
            };
           int sayi=new Ogrenciler_dao().ogrenci_kaydet(yeni_ogr);
            if (sayi != 0) Response.Write("Kayıt başarılı");
            else Response.Write("Kayıt yapılamadı");
        }
    }
}