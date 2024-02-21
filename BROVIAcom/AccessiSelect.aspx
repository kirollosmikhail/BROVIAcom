<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="AccessiSelect.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <h2>Accessi</h2>
    <asp:Button ID="btnElimena" runat="server" CssClass="button" Text="Elimina Tutti Record" OnClick="btnElimena_Click" />
    
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10" >
            <Columns>
                <asp:BoundField DataField="IP" HeaderText="IP"></asp:BoundField>
                <asp:BoundField DataField="USR" HeaderText="USER NAME"></asp:BoundField>
                <asp:BoundField DataField="PWD" HeaderText="PassWord"></asp:BoundField>
                <asp:BoundField DataField="Data_Accesso" HeaderText="Data Accesso"></asp:BoundField>
                <asp:BoundField DataField="Accesso_Riuscito" HeaderText="Accesso Riuscito"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

