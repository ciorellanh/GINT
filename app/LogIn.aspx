<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/logIn.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <div id="log">
        <table style="width:100%">
            <thead>
                <tr>
                    <td colspan="2">
                        Iniciar sesión
                    </td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        Usuario:
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" />
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
    </form>
</body>
</html>
