using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Okul_Veritabani_uygulamasi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ders> ders_listesi = new Dersler_dao().tum_dersleri_getir();  
            foreach(Ders gelen    in ders_listesi)
            {
                DropDownList1.Items.Add(gelen.ders_adi);
            }
        }
    }
}