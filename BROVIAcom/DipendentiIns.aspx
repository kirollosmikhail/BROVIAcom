<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiIns.aspx.cs" Inherits="DipendentiIns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Inserisci Dipendente</h2>
    <br />
    <div class="divdati">
        <div>
            <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Codice Fiscale" />

            <asp:TextBox ID="nome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Nome" />

            <asp:TextBox ID="cognome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Cognome" />

            <asp:TextBox ID="USR_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Username" />
        </div>
        <div>
            <asp:Label runat="server" Text="Data Assunzione"></asp:Label>
            <asp:TextBox ID="dataass_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Assunzione" TextMode="Date" />
            <asp:Label runat="server" Text="Data Licenziamento"></asp:Label>
            <asp:TextBox ID="datalic_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Data Licenziamento" TextMode="Date" />

            <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Partita IVA" />

            <asp:TextBox ID="salario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Salario" />

            <asp:Label runat="server" Text="Tipo dipendente"></asp:Label>
            <asp:DropDownList ID="ddlTipiDipendenti" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:TextBox ID="telefono_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Telefono" />

            <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Città" />

            <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="CAP" />

            <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Indirizzo" />
        </div>
    </div>
    <p>*facoltativi</p>
    <asp:Button ID="btninsert" runat="server" CssClass="button" Text="Conferma" OnClick="btninsert_Click" />

</asp:Content>

