<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="TipiDipendentiSelect.aspx.cs" Inherits="TipiDipendentiSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Tipologie dipendenti</h2>
<br />
        <a href="TipiDipendentiIns.aspx" Class="button">Inserisci Nuovo Tipo Dipendente</a>
<br />
<div class="table-container" style="width:50%">
    <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Tipo_Dipendente" >
        <Columns>
            <asp:CommandField SelectText="Elimina" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
            <asp:BoundField DataField="Tipo_Dipendente" HeaderText="Tipo Dipendente"></asp:BoundField> 
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

