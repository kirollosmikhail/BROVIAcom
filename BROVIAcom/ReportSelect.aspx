<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ReportSelect.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Report</h2>
    <br />
    <asp:HyperLink ID="Inserisci" href="ReportIns.aspx" Class="button" visible="true" runat="server">Inserisci Nuovo Report</asp:HyperLink>
    <br />
    <h4>Cerca</h4>
        <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Cerca Report" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox> <%--USARE INVIO--%>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" DataKeyNames="Cod_Lavoro" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField SelectText="Modifica" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:BoundField DataField="Data_Report" HeaderText="Data Report"></asp:BoundField> 
                <asp:BoundField DataField="Cognome" HeaderText="Cognome"></asp:BoundField> 
                <asp:BoundField DataField="Nome" HeaderText="Nome"></asp:BoundField> 
                <asp:BoundField DataField="Descrizione_Commessa" HeaderText="Descrizione Commessa"></asp:BoundField> 
                <asp:BoundField DataField="Descrizione_Lavoro" HeaderText="Descrizione Lavoro"></asp:BoundField> 
                <asp:BoundField DataField="Ore" HeaderText="Numero ore"></asp:BoundField> 
                <asp:BoundField DataField="Spesa_Pasto" HeaderText="Spesa Pasto"></asp:BoundField> 
                <asp:BoundField DataField="Spesa_Trasporto" HeaderText="Spesa Trasporto"></asp:BoundField> 
                <asp:BoundField DataField="Spesa_Pedaggi" HeaderText="Spesa Pedaggi"></asp:BoundField> 
                <asp:BoundField DataField="Spesa_Pernottamento" HeaderText="Spesa Pernottamento"></asp:BoundField> 
                <asp:BoundField DataField="Spesa_Extra" HeaderText="Spesa Extra"></asp:BoundField> 
                <asp:BoundField DataField="Descrizione_Spesa_Extra" HeaderText="Descrizione Spesa Extra"></asp:BoundField> 
                <asp:BoundField DataField="Tipo_Controllo" HeaderText="Controllo"></asp:BoundField> 
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

