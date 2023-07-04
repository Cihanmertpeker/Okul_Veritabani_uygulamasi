<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogrenci_duzenle.aspx.cs" Inherits="Okul_Veritabani_uygulamasi.ogrenci_duzenle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;" class="table table-hover">
                <tr>
                    <td>Öğrenci No:</td>
                    <td>
                        <asp:TextBox ID="og_no_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ad Soyad:</td>
                    <td>
                        <asp:TextBox ID="ad_soyad_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Doğum tarihi:</td>
                    <td>
                        <asp:TextBox ID="dog_tar_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Adres:</td>
                    <td>
                        <asp:TextBox ID="adres_txt" runat="server" Height="122px" TextMode="MultiLine" Width="229px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" Text="Değiştir" CssClass="btn btn-success" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>

        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ogrencileri_listele.aspx">Tüm Öğrenciler</asp:HyperLink>
    </form>
</body>
</html>
