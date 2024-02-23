<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiSelect.aspx.cs" Inherits="DipendentiSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .overlay {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-color: rgba(0, 0, 0, 0.5);
            z-index:99;
        }

        .Insert {
            position: absolute;
            background-color: aliceblue;
            border: solid black 1px;
            width: 630px;
            z-index:100;
            
        }
        .hidden{
display:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--INSERT--%>
    <script>
        function Popup() {
            document.getElementById("overlay").classList.remove("hidden");
            document.getElementById("Insert").classList.remove("hidden");
        }
        function Popup_OFF() {            document.getElementById("overlay").classList.add("hidden");            document.getElementById("Insert").classList.add("hidden");        }
    </script>

<div id="overlay" class="overlay hidden" ></div>
    <div id="Insert" class="container Insert hidden" >
        
        <div class="divdati">
            <div class="contdati">
                <div>
                    <asp:Label runat="server" Text="Codice Fiscale"></asp:Label>
                    <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Codice Fiscale" />
                </div>
                <div style="float: left; width: 48.5%; margin-right: 2%">
                    <asp:Label runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="nome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Nome" />
                </div>
                <div style="width: 48.5%">
                    <asp:Label runat="server" Text="Cognome"></asp:Label>
                    <asp:TextBox ID="cognome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Cognome" />
                </div>
                <div style="float: none">
                    <asp:Label runat="server" Text="Username (@Mail)"></asp:Label>
                    <asp:TextBox ID="USR_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Username  (@Mail)" />
                </div>
            </div>
            <div class="contdati">
                <div style="float: left; width: 48.5%; margin-right: 2%">
                    <asp:Label runat="server" Text="*Data Assunzione"></asp:Label>
                    <asp:TextBox ID="dataass_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Assunzione" TextMode="Date" />
                </div>
                <div style="width: 48.5%">
                    <asp:Label runat="server" Text="Data Licenziamento"></asp:Label>
                    <asp:TextBox ID="datalic_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Licenziamento" TextMode="Date" />
                </div>
            </div>
            <div class="contdati">
                <div>
                    <asp:Label runat="server" Text="*Tipo dipendente"></asp:Label>
                    <asp:DropDownList ID="ddlTipiDipendenti" runat="server" CssClass="form-control textbox"></asp:DropDownList>
                </div>
                <div style="float: left; width: 48.5%; margin-right: 2%">
                    <asp:Label runat="server" Text="Partita IVA"></asp:Label>
                    <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Partita IVA" />
                </div>
                <div style="width: 48.5%">
                    <asp:Label runat="server" Text="Salario"></asp:Label>
                    <asp:TextBox ID="salario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Salario" />
                </div>
            </div>
            <div class="contdati">
                <div style="float: left; width: 48.5%; margin-right: 2%">
                    <asp:Label runat="server" Text="Città"></asp:Label>
                    <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Città" />
                </div>
                <div style="width: 48.5%">
                    <asp:Label runat="server" Text="CAP"></asp:Label>
                    <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*CAP" />
                </div>
                <div >
                    <asp:Label runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="telefono_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Telefono" />
                </div>
                <div >
                    <asp:Label runat="server" Text="Indirizzo"></asp:Label>
                    <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Indirizzo" />
                </div>
            </div>
        </div>
        <p>*obbligatori</p>
        <div>
        <asp:Button ID="Annulla" runat="server" CssClass="button" Text="Annulla" OnClientClick="Popup_OFF();return false;" />
        <asp:Button ID="btninsert" runat="server" CssClass="button" Text="Conferma" OnClick="btninsert_Click" />
        </div>
    </div>

    <%--FINE INSERT--%>

    <h2>Dipendenti</h2>
    <br />
    <asp:Button ID="Button1" class="button" runat="server" Text="Inserisci Nuovo Dipendente" OnClientClick="Popup();return false;" />
    <%--    <a  href="DipendentiIns.aspx" class="button">Inserisci Nuovo Dipendente</a>--%>
    <br />
    <a href="TipiDipendentiSelect.aspx" class="button">Tipologie dipendenti</a>
    <br />
    <h4>Cerca</h4>
    <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Cognome dipendente" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox>
    <%--USARE INVIO--%>
    <br />
    <div class="table-container">
        <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Dipendente" OnPageIndexChanging="paging">
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

