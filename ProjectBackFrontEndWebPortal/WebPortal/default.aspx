<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebPortal.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WebPortal Pomiary</h1>
        </div>
        <div>
            <h3>by Kamil Wojtasiński</h3>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <asp:LinkButton id="LinkButton1" Text="Aktualne Pomiary" Font-Names="Verdana" Font-Size="12pt" OnClick="LinkButton1_Click" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton id="LinkButton2" Text="Archiwum" Font-Names="Verdana" Font-Size="12pt" OnClick="LinkButton2_Click" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp; </form>
</body>
</html>
