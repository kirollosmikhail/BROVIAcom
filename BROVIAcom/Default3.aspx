<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Pagina Esempio</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Inserisci esempio :"></asp:Label>
        <asp:TextBox runat="server" type="text" CssClass="form-control textbox" placeholder="Example input placeholder"></asp:TextBox>
    </div>
    <br />
    <asp:Button runat="server" CssClass="button" Text="Esempio Pulsante" />
    <hr />
    <h4>Esempio GridView</h4>
    <asp:GridView ID="GridView1" CssClass="gridview" runat="server"></asp:GridView>
    <br />
    <br /> 
</asp:Content>
        

