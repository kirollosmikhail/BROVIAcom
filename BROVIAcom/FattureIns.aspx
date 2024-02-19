<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="FattureIns.aspx.cs" Inherits="FattureIns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Inserisci Fattura</h2>
    <br />
    <div class="divdati">
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Data Fattura"></asp:Label>
                <asp:TextBox ID="datafat_txt" runat="server" type="text" CssClass="form-control textbox" TextMode="Date" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Descrizione"></asp:Label>
                <asp:TextBox ID="descfat_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Descrizione" TextMode="MultiLine" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="IVA"></asp:Label>
                <asp:TextBox ID="IVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="IVA" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Commessa"></asp:Label>
                <asp:DropDownList ID="ddlCommessa" runat="server" CssClass="form-control textbox"></asp:DropDownList>
            </div>
        </div>
    </div>

    <asp:Button runat="server" ID="btnInsert" CssClass="button" Text="Conferma" OnClick="btnInsert_Click" />
</asp:Content>

