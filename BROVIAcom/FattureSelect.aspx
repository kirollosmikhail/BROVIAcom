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
        <asp:TextBox ID="Cerca2" runat="server" CssClass="form-control textbox" Style="width: 200px" placeholder="MM/YYYY" AutoPostBack="true" OnTextChanged="Page_Load" onkeypress="return allowOnlyMonthYear(event)"></asp:TextBox>
    </div>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Commessa" OnPageIndexChanging="paging">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:BoundField DataField="Numero_Fattura" HeaderText="Numero Fattura"></asp:BoundField>
                <asp:BoundField DataField="Data_Fattura" HeaderText="Data Fattura"></asp:BoundField>
                <asp:BoundField DataField="Descrizione" HeaderText="Descrizione"></asp:BoundField>
                <asp:BoundField DataField="Ragione_Sociale" HeaderText="Ragione Sociale"></asp:BoundField>
                <asp:BoundField DataField="Imponibile" HeaderText="Imponibile"></asp:BoundField>
                <asp:BoundField DataField="IVA" HeaderText="IVA"></asp:BoundField>
                <asp:BoundField DataField="Totale" HeaderText="Totale"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
    <script>
    function allowOnlyMonthYear(e) {
        var charCode = (e.which) ? e.which : e.keyCode;
        var cercabox = document.getElementById('<%=Cerca2.ClientID%>');
        var inputValue = cercabox.value;
        
        // Allow only numbers, backspace, delete, tab, and /
        if ((charCode >= 48 && charCode <= 57) || charCode == 8 || charCode == 9 || charCode == 46 || charCode == 47) {
            // Check for MM/YYYY format
            if (inputValue.length == 2 && charCode != 8) {
                cercabox.value = inputValue + '/';
            }
            return true;
        }
        return false;
    }
    </script>
</asp:Content>

