<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiSelect.aspx.cs" Inherits="DipendentiSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Dipendenti</h2>
    <br />
            <a href="DipendentiIns.aspx" Class="button">Inserisci</a>
    <br />
    <h4>Cerca</h4>
        <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Cognome dipendente" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox> <%--USARE INVIO--%>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Dipendente">
            <Columns>
                <asp:CommandField SelectText="Modifica" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:BoundField DataField="Cognome" HeaderText="Cognome"></asp:BoundField> 
                <asp:BoundField DataField="Nome" HeaderText="Nome"></asp:BoundField> 
                <asp:BoundField DataField="Abilitato" HeaderText="Abilitato"></asp:BoundField> 
                <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice Fiscale"></asp:BoundField> 
                <asp:BoundField DataField="P_IVA" HeaderText="Partita IVA"></asp:BoundField> 
                <asp:BoundField DataField="Data_Assunzione" HeaderText="Assunzione"></asp:BoundField> 
                <asp:BoundField DataField="Data_Licenziamento" HeaderText="Licenziamento"></asp:BoundField> 
                <asp:BoundField DataField="Salario" HeaderText="Salario"></asp:BoundField> 
                <asp:BoundField DataField="Telefono" HeaderText="Telefono"></asp:BoundField> 
                <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo"></asp:BoundField> 
                <asp:BoundField DataField="Citta" HeaderText="Città"></asp:BoundField> 
                <asp:BoundField DataField="CAP" HeaderText="CAP"></asp:BoundField> 
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

