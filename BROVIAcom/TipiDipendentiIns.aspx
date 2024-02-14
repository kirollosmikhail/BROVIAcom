<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="TipiDipendentiIns.aspx.cs" Inherits="TipiDipendentiIns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Inserisci Tipo Dipendente</h2>
<br />
<div class="divdati">
    <div>
        <asp:TextBox ID="tipodipendente_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Tipo Dipendente" />
    </div>
</div>
<asp:Button ID="btninsert" runat="server" CssClass="button" Text="Conferma" OnClick="btninsert_Click" />
</asp:Content>

