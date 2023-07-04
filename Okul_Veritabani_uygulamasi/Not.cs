using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_Veritabani_uygulamasi
{
    public class Not
    {
        public Not()
        {
        }

        public Not(byte yaz1, byte yaz2, byte perf, int id, Ders ders_no, Ogrenci og_no)
        {
            this.yaz1 = yaz1;
            this.yaz2 = yaz2;
            this.perf = perf;
            this.id = id;
            this.ders_no = ders_no;
            this.og_no = og_no;
        }

        public byte yaz1 { get; set; }
        public byte yaz2 { get; set; }
        public byte perf { get; set; }
        public int id { get; set; }
        public Ders ders_no { get; set; }
        public Ogrenci og_no { get; set; }

    }
}