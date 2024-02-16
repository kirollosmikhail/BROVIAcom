<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="TipiCommesseIns.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Inserisci Tipo Commessa</h2>
    <br />
    <div class="divdati">
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Tipo Commessa"></asp:Label>
                <asp:TextBox ID="tipocommessa_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Tipo Commessa" />
            </div>
        </div>
    </div>
    <asp:Button ID="btninsert" runat="server" CssClass="button" Text="Conferma" OnClick="btninsert_Click" />
</asp:Content>

