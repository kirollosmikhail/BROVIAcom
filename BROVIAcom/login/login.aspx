<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login - Brovia.com</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <link href="../css/StyleSheet.css" rel="stylesheet" />  
    <link rel="icon" type="image/x-icon" href="../img/BROVIAico.png" />
</head>
<body >
    <form id="form1" runat="server">
        <div class="login-container">
            <img src="../img/BROVIAcom.png" />
            <h2>Login</h2>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control textbox" placeholder="Username" Style="text-align: center;" />
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control textbox" TextMode="Password" placeholder="Password" Style="text-align: center; margin-top: 5px" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Accedi" CssClass="button" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
<script src="../JS/AdattaTabella.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</html>
