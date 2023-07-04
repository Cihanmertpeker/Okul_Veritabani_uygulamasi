<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrencileri_listele.aspx.cs" Inherits="Okul_Veritabani_uygulamasi.Ogrencileri_listele" %>
<%@ Import Namespace="Okul_Veritabani_uygulamasi" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <script src="js/bootstrap.bundle.js"></script>
    <form id="form1" runat="server">
        <div>
           
      <% List<Ogrenci> ogrenci_listem = new Ogrenciler_dao().tum_ogrenciler();

                %>
            <table class="table table-striped">
                <tr><td>Öğrenci no</td><td>Ad soyad</td>
                    <td>Doğum Tarihi</td>
                   <td>adres</td><td>Sil</td><td>Düzenle</td>
                    </tr>
                <%foreach (Ogrenci gelen_ogr in ogrenci_listem)
                    {
                %>
                <tr>
                    <td><%Response.Write(gelen_ogr.og_no);%></td>
                    <td><%Response.Write(gelen_ogr.ad_soyad);%></td>
                    <td><%=gelen_ogr.dog_tar.ToShortDateString()%></td>
                   <td><%=gelen_ogr.adres%></td>
                    <td><a href="ogrenci_sil.aspx?og_no=<%=gelen_ogr.og_no %>" class="btn btn-danger">Sil</a></td>
                   <td><a href="ogrenci_duzenle.aspx?og_no=<%=gelen_ogr.og_no %>" class="btn btn-success">Duzenle</a></td>
                    </tr>
                <%} %>
            </table>
        </div>
    </form>
</body>
</html>
