<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="TipiCommesseSelect.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Tipologie commesse</h2>
<br />
        <a href="TipiCommesseIns.aspx" Class="button">Inserisci Nuovo Tipo Commessa</a>
<br />
<div class="table-container" style="width:50%">
    <asp:GridView ID="GridView3" CssClass="gridview" runat="server" AutoGenerateColumns="False" DataKeyNames="Cod_Tipo_Commessa" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" AllowPaging="True" PageSize="10">
        <Columns>
            <asp:CommandField SelectText="Elimina" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
            <asp:BoundField DataField="Nome_Commessa" HeaderText="Nome Commessa"></asp:BoundField> 
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

