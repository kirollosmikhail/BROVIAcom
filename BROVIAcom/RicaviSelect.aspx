<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="RicaviSelect.aspx.cs" Inherits="RicaviSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h2>Ricavi</h2>

    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10">
            <columns>
                <asp:BoundField DataField="Descrizione_Commessa" HeaderText="Descrizione_Commessa"></asp:BoundField>
                <asp:BoundField DataField="Costi" HeaderText="Costi"></asp:BoundField>
                <asp:BoundField DataField="Ricavi" HeaderText="Ricavi"></asp:BoundField>
                <asp:BoundField DataField="Bilancio" HeaderText="Bilancio"></asp:BoundField>
            </columns>
        </asp:GridView>
    </div>

</asp:Content>

