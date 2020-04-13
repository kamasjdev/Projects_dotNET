<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Stronka._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width:50%;
            margin:0 auto
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="Label3" runat="server" Text="Azure Web Chat"></asp:Label>
            </h1>
        </div>
        <h3>by imie</h3>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logowanie</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp; 
    <asp:LinkButton ID="LinkButton2" runat="server" Visible="False" OnClick="LinkButton2_Click">Wyloguj</asp:LinkButton>

        </p>
        <div>
        
        <asp:Panel ID="panelTabela" runat="server" Height="322px" Visible="False" Width="730px">
            Co chcesz powiedzieć?
            <asp:TextBox ID="tresc" runat="server" Width="340px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Zapisz" />
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="data" HeaderText="data" SortExpression="data" />
                    <asp:BoundField DataField="login" HeaderText="login" SortExpression="login" />
                    <asp:BoundField DataField="tresc" HeaderText="tresc" SortExpression="tresc" />
                </Columns>
            </asp:GridView>
            </ContentTemplate>
            </asp:UpdatePanel>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:labdbConnectionString2 %>" DeleteCommand="DELETE FROM [Chat] WHERE [id] = @original_id AND (([data] = @original_data) OR ([data] IS NULL AND @original_data IS NULL)) AND (([login] = @original_login) OR ([login] IS NULL AND @original_login IS NULL)) AND (([tresc] = @original_tresc) OR ([tresc] IS NULL AND @original_tresc IS NULL))" InsertCommand="INSERT INTO [Chat] ([data], [login], [tresc]) VALUES (@data, @login, @tresc)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [data], [login], [tresc] FROM [Chat]" UpdateCommand="UPDATE [Chat] SET [data] = @data, [login] = @login, [tresc] = @tresc WHERE [id] = @original_id AND (([data] = @original_data) OR ([data] IS NULL AND @original_data IS NULL)) AND (([login] = @original_login) OR ([login] IS NULL AND @original_login IS NULL)) AND (([tresc] = @original_tresc) OR ([tresc] IS NULL AND @original_tresc IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_id" Type="Int32" />
                    <asp:Parameter Name="original_data" Type="DateTime" />
                    <asp:Parameter Name="original_login" Type="String" />
                    <asp:Parameter Name="original_tresc" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="data" Type="DateTime" />
                    <asp:Parameter Name="login" Type="String" />
                    <asp:Parameter Name="tresc" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="data" Type="DateTime" />
                    <asp:Parameter Name="login" Type="String" />
                    <asp:Parameter Name="tresc" Type="String" />
                    <asp:Parameter Name="original_id" Type="Int32" />
                    <asp:Parameter Name="original_data" Type="DateTime" />
                    <asp:Parameter Name="original_login" Type="String" />
                    <asp:Parameter Name="original_tresc" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </asp:Panel>

            </div>

        <br />
        <br />
        <div class="auto-style1">
            <asp:Panel ID="panelLogin" runat="server" Height="209px" Visible="False" Width="342px">
                <div class="auto-style2">
                    Konto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="169px"></asp:TextBox>
                    <br />
                    Haslo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="169px" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Zaloguj" />
                    <br />
                    <br />
                    Status:&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
