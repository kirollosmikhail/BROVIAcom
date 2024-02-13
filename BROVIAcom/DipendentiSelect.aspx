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
        <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Cerca dipendente" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox> <%--USARE INVIO--%>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server"></asp:GridView>
    </div>

</asp:Content>

