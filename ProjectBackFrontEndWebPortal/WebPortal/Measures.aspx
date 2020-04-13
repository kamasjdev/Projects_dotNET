<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Measures.aspx.cs" Inherits="WebPortal.Measures" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            STATUS Połączenia z bazą: &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" HorizontalAlign="Left" style="margin-left: 0px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="Wartosc" HeaderText="Wartosc" SortExpression="Wartosc" />
                <asp:BoundField DataField="Jednostka" HeaderText="Jednostka" SortExpression="Jednostka" />
                <asp:BoundField DataField="Data_odczytu" HeaderText="Data_odczytu" SortExpression="Data_odczytu" />
                <asp:BoundField DataField="polaczenia" HeaderText="polaczenia" SortExpression="polaczenia"/>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        </ContentTemplate>
        </asp:UpdatePanel>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BoxJenkinsConnectionString %>" SelectCommand="SELECT [Wartosc], [Jednostka], [Data odczytu] AS Data_odczytu, [polaczenia] FROM [Pomiary]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton id="LinkButton3" Text="Strona Główna" Font-Names="Verdana" Font-Size="12pt" OnClick="LinkButton3_Click" runat="server"/>

    </form>
</body>
</html>
