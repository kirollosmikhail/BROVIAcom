<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="EventiSelect.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Eventi</h2>
    <asp:Button ID="btnElimena" runat="server" CssClass="button" Text="Elimina Tutti Record" OnClick="btnElimena_Click" />

    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10">
            <columns>
                <asp:BoundField DataField="Data_Azione" HeaderText="Data"></asp:BoundField>
                <asp:BoundField DataField="Azione" HeaderText="Azione"></asp:BoundField>
                <asp:BoundField DataField="Parametri" HeaderText="Parametri"></asp:BoundField>
                <asp:BoundField DataField="USR" HeaderText="USERNAME"></asp:BoundField>
                <asp:BoundField DataField="Cognome" HeaderText="Cognome"></asp:BoundField>
                <asp:BoundField DataField="Nome" HeaderText="Nome"></asp:BoundField>
            </columns>
        </asp:GridView>
    </div>

</asp:Content>

