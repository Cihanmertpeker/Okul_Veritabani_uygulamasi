using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_Veritabani_uygulamasi
{
    public class Ders
    {
        public Ders()
        {
        }

        public Ders(byte ders_no, string ders_adi)
        {
            this.ders_no = ders_no;
            this.ders_adi = ders_adi;
        }

        public byte ders_no { get; set; }
        public string ders_adi { get; set; }

    }
}