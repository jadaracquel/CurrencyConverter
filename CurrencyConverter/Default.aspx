<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyConverter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Currency Converter</h1>
            <br />
            Convert
            <asp:TextBox ID="txbxAmount" runat="server"></asp:TextBox>
&nbsp;US dollars into
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="120px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="EUR">Euros</asp:ListItem>
                <asp:ListItem Value="JPY">Japanese Yen</asp:ListItem>
                <asp:ListItem Value="GBP">British Pound</asp:ListItem>
                <asp:ListItem Value="CAD">Canadian Dollar</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnConvert" runat="server" Text="OK" OnClick="btnConvert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnShowGraph" runat="server" Text="Show Graph" OnClick="btnShowGraph_Click" />
            <br />
            <br />
            <asp:Image ID="imgGraph" runat="server" Height="175px" Width="317px" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
