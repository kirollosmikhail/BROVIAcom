<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ClientiMod.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Modifica Cliente</h2>
    <br />
   <div class="divdati">
       <div class="contdati">
           <div>
               <asp:Label runat="server" Text="Ragione Sociale"></asp:Label>
               <asp:TextBox ID="RagSociale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Ragione Sociale" />
           </div>
           <div>
               <asp:Label runat="server" Text="Codice Fiscale"></asp:Label>
               <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Codice Fiscale" />
           </div>
           <div>
               <asp:Label runat="server" Text="Partita IVA"></asp:Label>
               <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Partita IVA" />
           </div>
       </div>
       <div class="contdati">
           <div>
               <asp:Label runat="server" Text="Persona di riferimento"></asp:Label>
               <asp:TextBox ID="PersonaRif_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Persona di riferimento" />
           </div>
           <div>
               <asp:Label runat="server" Text="E-Mail"></asp:Label>
               <asp:TextBox ID="email_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="E-Mail" />
           </div>
           <div>
               <asp:Label runat="server" Text="Città"></asp:Label>
               <asp:TextBox ID="citta_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Città" />
           </div>
           <div>
               <asp:Label runat="server" Text="CAP"></asp:Label>
               <asp:TextBox ID="CAP_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="CAP" />
           </div>
           <div>
               <asp:Label runat="server" Text="Indirizzo"></asp:Label>
               <asp:TextBox ID="indirizzo_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Indirizzo" />
           </div>
       </div>
   </div>
    <p>*facoltativi</p>
    <asp:Button runat="server" ID="btnConferma" CssClass="button" Text="Conferma" OnClick="btnConferma_Click" />
</asp:Content>

