<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ClientiSelect.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Clienti</h2>
    <br />
            <a href="ClientiIns.aspx" Class="button">Inserisci Nuovo Cliente</a>
    <br />
    <h4>Cerca</h4>
        <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Ragione Sociale Cliente" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox> <%--USARE INVIO--%>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView2" CssClass="gridview" runat="server" AutoGenerateColumns="False" DataKeyNames="Cod_Cliente" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnPageIndexChanging="paging">
            <Columns>
                <asp:CommandField SelectText="Modifica" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:BoundField DataField="Ragione_Sociale" HeaderText="Ragione Sociale"></asp:BoundField> 
                <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice Fiscale"></asp:BoundField> 
                <asp:BoundField DataField="P_IVA" HeaderText="Partita IVA"></asp:BoundField> 
                <asp:BoundField DataField="Persona_Riferimento" HeaderText="Persona di riferimento"></asp:BoundField> 
                <asp:BoundField DataField="Email" HeaderText="E-Mail"></asp:BoundField> 
                <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo"></asp:BoundField> 
                <asp:BoundField DataField="Citta" HeaderText="Città"></asp:BoundField> 
                <asp:BoundField DataField="CAP" HeaderText="CAP"></asp:BoundField> 
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

