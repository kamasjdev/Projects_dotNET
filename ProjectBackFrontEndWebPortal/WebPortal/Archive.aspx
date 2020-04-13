<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Archive.aspx.cs" Inherits="WebPortal.Archive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Filtracja danych archiwalnych. Proszę podać datę od&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; do&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Akceptuj" />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BoxJenkinsConnectionString %>" SelectCommand="SELECT [Wartosc], [Jednostka], [Data odczytu] AS Data_odczytu, [polaczenia], [id] FROM [Archiwum] WHERE (([Data odczytu] &gt;= @Data_odczytu) AND ([Data odczytu] &lt;= @Data_odczytu2))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="Data_odczytu" PropertyName="Text" Type="DateTime" />
                    <asp:ControlParameter ControlID="TextBox2" Name="Data_odczytu2" PropertyName="Text" Type="DateTime" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="Wartosc" HeaderText="Wartosc" SortExpression="Wartosc" />
                    <asp:BoundField DataField="Jednostka" HeaderText="Jednostka" SortExpression="Jednostka" />
                    <asp:BoundField DataField="Data_odczytu" HeaderText="Data odczytu" SortExpression="Data_odczytu" />
                    <asp:BoundField DataField="polaczenia" HeaderText="Połączenie" SortExpression="polaczenia" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>

            <br />
            <br />

            <asp:LinkButton id="LinkButton3" Text="Strona Główna" Font-Names="Verdana" Font-Size="12pt" OnClick="LinkButton3_Click" runat="server"/>
            <br />
        </div>
    </form>
</body>
</html>
