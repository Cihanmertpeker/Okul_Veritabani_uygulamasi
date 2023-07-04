using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_Veritabani_uygulamasi
{
    public class Ogrenci
    {
        public int og_no { get; set; }
        public string ad_soyad { get; set; }
        public DateTime dog_tar { get; set; }
        public string adres { get; set; }

        public Ogrenci(int og_no, string ad_soyad, DateTime dog_tar, string adres)
        {
            this.og_no = og_no;
            this.ad_soyad = ad_soyad;
            this.dog_tar = dog_tar;
            this.adres = adres;
        }

        public Ogrenci()
        {
        }
    }
}