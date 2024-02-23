<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/StyleSheet.css" rel="stylesheet" />
</head>
<body style="zoom: 1.5">
    <form id="form1" runat="server">
        <div class="container">
            <div class="divdati">
                <div class="contdati">
                    <div>
                        <asp:Label runat="server" Text="Codice Fiscale"></asp:Label>
                        <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Codice Fiscale" />
                    </div>
                    <div style="float: left; width: 45%; margin-right: 2%">
                        <asp:Label runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="nome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Nome" />
                    </div>
                    <div style="width: 45%">
                        <asp:Label runat="server" Text="Cognome"></asp:Label>
                        <asp:TextBox ID="cognome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Cognome" />
                    </div>
                    <div style="float: none">
                        <asp:Label runat="server" Text="Username (@Mail)"></asp:Label>
                        <asp:TextBox ID="USR_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Username  (@Mail)" />
                    </div>
                </div>
                <div class="contdati">
                    <div>
                        <asp:Label runat="server" Text="*Data Assunzione"></asp:Label>
                        <asp:TextBox ID="dataass_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Assunzione" TextMode="Date" />
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Data Licenziamento"></asp:Label>
                        <asp:TextBox ID="datalic_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Licenziamento" TextMode="Date" />
                    </div>
                </div>
                <div class="contdati">
                    <div>
                        <asp:Label runat="server" Text="*Tipo dipendente"></asp:Label>
                        <asp:DropDownList ID="ddlTipiDipendenti" runat="server" CssClass="form-control textbox"></asp:DropDownList>
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Partita IVA"></asp:Label>
                        <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Partita IVA" />
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Salario"></asp:Label>
                        <asp:TextBox ID="salario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Salario" />
                    </div>
                </div>
                <div class="contdati">
                    <div style="float: left; width: 45%; margin-right: 2%">
                        <asp:Label runat="server" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="telefono_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Telefono" />
                    </div>
                    <div style="width: 45%">
                        <asp:Label runat="server" Text="Città"></asp:Label>
                        <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Città" />
                    </div>
                    <div style="float: left; width: 45%; margin-right: 2%">
                        <asp:Label runat="server" Text="Indirizzo"></asp:Label>
                        <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Indirizzo" />
                    </div>
                    <div style="width: 45%">
                        <asp:Label runat="server" Text="CAP"></asp:Label>
                        <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*CAP" />
                    </div>
                </div>
            </div>
            <p>*obbligatori</p>
            <asp:Button ID="btninsert" runat="server" CssClass="button" Text="Conferma" OnClick="btninsert_Click" />
        </div>
    </form>
</body>
</html>
