<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiSelect.aspx.cs" Inherits="DipendentiSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">


        function showpopup() {
            $(function () {
                
                var findialog = $('<div  ID="iframe1" > <iframe src="DipendentiIns.aspx" frameborder="0" class="ui-dialog-content ui-widget-content" style="width: 100%;min-height: 0px;height: 100%;"></iframe></div>').appendTo('body');
                findialog.dialog({
                    modal: true,
                    title: 'Inserisci Nuovo Dipendente',
                    resizable: true,
                    width: 1000,
                    height: 1000,
                    draggable: true,
                    
                    buttons: {
                        Aggiorna: function () {
                            $(this).dialog('close');
                            $("[id *= Button2]").click();

                        }
                    }
                    
                });
                
            });

        }
        
    </script>

    <h2>Dipendenti</h2>
    <br />
    <asp:Button ID="Button1"  class="button" runat="server" Text="Inserisci Nuovo Dipendente" OnClientClick="showpopup();return false;"  />
    <asp:Button ID="Button2"   runat="server" style="display:none;" Text="Confirm" OnClick="Button2_Click" />
<%--    <a  href="DipendentiIns.aspx" class="button">Inserisci Nuovo Dipendente</a>--%>
    <br />
    <a href="TipiDipendentiSelect.aspx" class="button">Tipologie dipendenti</a>
    <br />
    <h4>Cerca</h4>
    <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Cognome dipendente" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox>
    <%--USARE INVIO--%>
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

