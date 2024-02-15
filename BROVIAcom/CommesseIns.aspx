<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="CommesseIns.aspx.cs" Inherits="CommesseIns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h2>Inserisci Commessa</h2>
<br />
<div class="divdati">
    <div>
        <asp:TextBox ID="desccom_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Descrizione" TextMode="MultiLine" />
    </div>
    <div>
        <asp:Label runat="server" Text="Data Inizio"></asp:Label>
        <asp:TextBox ID="datainiz_txt" runat="server" type="text" CssClass="form-control textbox"  TextMode="Date" />

        <asp:Label runat="server" Text="*Data Fine"></asp:Label>
        <asp:TextBox ID="datafin_txt" runat="server" type="text" CssClass="form-control textbox"  TextMode="Date" />
    </div> 
    <div>
        <asp:Label runat="server" Text="Tipo Commessa"></asp:Label>
        <asp:DropDownList ID="ddlTipiCommesse" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Label runat="server" Text="Cliente"></asp:Label>
        <asp:DropDownList ID="ddlRagioneSociale" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:TextBox ID="anticipo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Anticipo" />

        <asp:TextBox ID="impacorpo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Importo a Corpo" />

        <asp:TextBox ID="impmensile_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Importo mensile" />

        <asp:TextBox ID="imporario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Importo Orario" />
    </div>
</div>
<p>*facoltativi</p>
<asp:Button runat="server" ID="btnInsert" CssClass="button" Text="Conferma" OnClick="btnInsert_Click" />
</asp:Content>

