<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="CommesseSelect.aspx.cs" Inherits="CommesseSelect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2>Commesse</h2>
 <br />
         <a href="CommesseIns.aspx" Class="button">Inserisci Nuova Commessa</a>
 <br />
 <a href="TipiCommesseSelect.aspx" Class="button">Tipologie Comesse</a>
 <br />
 <h4>Cerca</h4>
     <asp:TextBox ID="cerca" runat="server" type="text" CssClass="form-control textbox" Style="width: 200px" placeholder="Ragione Sociale" AutoPostBack="true" OnTextChanged="Page_Load"></asp:TextBox> <%--USARE INVIO--%>
    <asp:DropDownList ID="ddlTipiCommesse" runat="server" OnSelectedIndexChanged="Page_Load" AutoPostBack="true"></asp:DropDownList>
 <br />
 <div class="table-container">
     <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Cod_Commessa">
         <Columns>
             <asp:CommandField SelectText="Modifica" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:BoundField DataField="Descrizione_Commessa" HeaderText="Descrizione Commessa"></asp:BoundField> 
             <asp:BoundField DataField="Data_Inizio" HeaderText="Data Inizio"></asp:BoundField> 
             <asp:BoundField DataField="Data_Fine" HeaderText="Data Fine"></asp:BoundField> 
             <asp:BoundField DataField="Anticipo" HeaderText="Anticipo"></asp:BoundField> 
             <asp:BoundField DataField="Importo_ACorpo" HeaderText="Importo a Corpo"></asp:BoundField> 
             <asp:BoundField DataField="Importo_CanoneMensile" HeaderText="Importo Canone Mensile"></asp:BoundField> 
             <asp:BoundField DataField="Importo_Orario" HeaderText="Importo Orario"></asp:BoundField> 
             <asp:BoundField DataField="Nome_Commessa" HeaderText="Tipo Commessa"></asp:BoundField> 
             <asp:BoundField DataField="Ragione_Sociale" HeaderText="Ragione Sociale"></asp:BoundField> 
             <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice Fiscale"></asp:BoundField> 
             <asp:BoundField DataField="P_IVA" HeaderText="Partita IVA"></asp:BoundField> 
             <asp:BoundField DataField="Persona_Riferimento" HeaderText="Persona Riferimento"></asp:BoundField> 
             <asp:BoundField DataField="Email" HeaderText="Email"></asp:BoundField> 
             <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo"></asp:BoundField> 
             <asp:BoundField DataField="Citta" HeaderText="Città"></asp:BoundField> 
             <asp:BoundField DataField="CAP" HeaderText="CAP"></asp:BoundField> 
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>

