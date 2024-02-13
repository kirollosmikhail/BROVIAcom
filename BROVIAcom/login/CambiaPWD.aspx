<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CambiaPWD.aspx.cs" Inherits="CambiaPWD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login - Brovia.com</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <link href="../css/StyleSheet.css" rel="stylesheet" />  
    <link rel="icon" type="image/x-icon" href="../img/BROVIAico.png" />
</head>
<body style="zoom:1.4;">
    <form id="form1" runat="server">
        <div class="login-container">
            <img src="../img/BROVIAcom.png" />
            <h2>Imposta Password</h2>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control textbox" placeholder="Password" Style="text-align: center;" TextMode="Password" />
            <asp:TextBox ID="txtConfermaPassword" runat="server" CssClass="form-control textbox" placeholder="Conferma Password" Style="text-align: center; margin-top: 5px" TextMode="Password" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Conferma" CssClass="button" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</html>
