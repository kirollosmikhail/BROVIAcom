<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiSelect.aspx.cs" Inherits="DipendentiSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Dipendenti</h2>
    <p>&nbsp;</p>
    <div class="linker">
        <a href="DipendentiIns.aspx">.Inserisci</a>
        <a href="DipendentiMod.aspx">.Mododifica</a>
    </div>
    <br />
    <br />
    <div>
        <asp:TextBox runat="server" type="text" CssClass="form-control textbox" Style="width: 200px; float: left; margin: 4px 10px 4px 2px;" placeholder="Cerca dipendente"></asp:TextBox>
        <asp:Button runat="server" CssClass="button" Text="Cerca" />
    </div>

    <asp:GridView ID="GridView1" CssClass="gridview" runat="server"></asp:GridView>
</asp:Content>

