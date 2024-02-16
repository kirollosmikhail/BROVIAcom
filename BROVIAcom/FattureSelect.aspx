<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="FattureSelect.aspx.cs" Inherits="FattureSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Fatture</h2>
    <br />
    <a href="FattureIns.aspx" class="button">Inserisci Nuova Fattura</a>
    <br />
    <h4>Cerca</h4>
    <div style="display: flex; align-items: center;">
        <asp:RadioButton ID="rad_1" runat="server" GroupName="Condizioni" AutoPostBack="true"></asp:RadioButton>
        &nbsp
        <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Ragione Sociale" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox>
        <%--USARE INVIO--%>
    </div>
    <div style="display: flex; align-items: center;">
        <asp:RadioButton ID="rad_2" runat="server" GroupName="Condizioni" AutoPostBack="true"></asp:RadioButton>
        &nbsp
        <asp:TextBox ID="Cerca2" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Ragione Sociale" AutoPostBack="true" OnTextChanged="Page_Load" TextMode="Date"></asp:TextBox>
    </div>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Commessa">
            <Columns>
                <asp:CommandField SelectText="Modifica" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:BoundField DataField="Numero_Fattura" HeaderText="Numero Fattura"></asp:BoundField>
                <asp:BoundField DataField="Data_Fattura" HeaderText="Data Fattura"></asp:BoundField>
                <asp:BoundField DataField="Descrizione" HeaderText="Descrizione"></asp:BoundField>
                <asp:BoundField DataField="Imponibile" HeaderText="Imponibile"></asp:BoundField>
                <asp:BoundField DataField="IVA" HeaderText="IVA"></asp:BoundField>
                <asp:BoundField DataField="Totale" HeaderText="Totale"></asp:BoundField>
                <asp:BoundField DataField="Descrizione_Commessa" HeaderText="Descrizione Commessa"></asp:BoundField>
                <asp:BoundField DataField="Data_Inizio" HeaderText="Data Inizio"></asp:BoundField>
                <asp:BoundField DataField="Data_Fine" HeaderText="Data Fine"></asp:BoundField>
                <asp:BoundField DataField="Anticipo" HeaderText="Anticipo"></asp:BoundField>
                <asp:BoundField DataField="Importo_ACorpo" HeaderText="Importo ACorpo"></asp:BoundField>
                <asp:BoundField DataField="Importo_CanoneMensile" HeaderText="Importo_CanoneMensile"></asp:BoundField>
                <asp:BoundField DataField="Importo_Orario" HeaderText="Importo Orario"></asp:BoundField>
                <asp:BoundField DataField="Ragione_Sociale" HeaderText="Ragione Sociale"></asp:BoundField>
                <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice Fiscale"></asp:BoundField>
                <asp:BoundField DataField="P_IVA" HeaderText="Partita IVA"></asp:BoundField>
                <asp:BoundField DataField="Persona_Riferimento" HeaderText="Persona Riferimento"></asp:BoundField>
                <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo"></asp:BoundField>
                <asp:BoundField DataField="Citta" HeaderText="Città"></asp:BoundField>
                <asp:BoundField DataField="CAP" HeaderText="CAP"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

