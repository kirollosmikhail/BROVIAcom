<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ClientiMod.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Modifica Cliente</h2>
    <br />
    <div class="divdati">
        <div>
            <asp:TextBox ID="RagSociale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Ragione Sociale" />

            <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Codice Fiscale" />

            <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Partita IVA" />
        </div>
  
        <div>
            <asp:TextBox ID="PersonaRif_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Persona di riferimento" />
           
            <asp:TextBox ID="email_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="E-Mail" />

            <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Città" />

            <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="CAP" />

            <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Indirizzo" />
        </div>
  
    </div>

    <asp:Button runat="server" ID="btnConferma" CssClass="button" Text="Conferma" OnClick="btnConferma_Click" />
</asp:Content>

