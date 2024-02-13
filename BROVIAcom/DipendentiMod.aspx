<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiMod.aspx.cs" Inherits="DipendentiMod" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Modifica Dipendente</h2>
    <br />
    <div class="divdati">
        <div>
            <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Codice Fiscale" />

            <asp:TextBox ID="nome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Nome" />

            <asp:TextBox ID="cognome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Cognome" />

            <asp:TextBox ID="USR_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Username" />
        </div>
        <div>
            <asp:TextBox ID="dataass_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Assunzione" />

            <asp:TextBox ID="datalic_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Data Licenziamento" />

            <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Partita IVA" />

            <asp:TextBox ID="salario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Salario" />

            <asp:Label runat="server" Text="Tipo dipendente"></asp:Label>
            <asp:DropDownList runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:TextBox ID="telefono_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Telefono" />

            <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Città" />

            <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="CAP" />

            <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Indirizzo" />
        </div>
        <div>
            <asp:Label runat="server" Text="Abilitazione"></asp:Label>
            &nbsp; &nbsp; &nbsp;
            <asp:RadioButton id="rad_si" runat="server" text="si" GroupName="Condizioni"></asp:RadioButton>
            &nbsp;
            <asp:RadioButton id="rad_no" runat="server" text="no" GroupName="Condizioni"></asp:RadioButton>
        </div>
    </div>
    <p>*facoltativi</p>
    <asp:Button runat="server" CssClass="button" Text="Conferma" />
</asp:Content>

