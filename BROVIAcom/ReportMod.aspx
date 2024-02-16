<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ReportMod.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Modifica Report</h2>
    <br />
    <div class="divdati">
        <div>
            <asp:Label ID="lblDataReport" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblCognome" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Commessa"></asp:Label>
            <asp:DropDownList ID="ddlCommessa" runat="server"></asp:DropDownList>
            <br />
            <asp:TextBox ID="txtDesLavoro" runat="server" type="text" CssClass="form-control textbox" placeholder="Descrizione del lavoro svolto" TextMode="MultiLine" />

            <asp:TextBox ID="txtOre" runat="server" type="text" CssClass="form-control textbox" placeholder="Numero di ore" TextMode="Time" />
        </div>
        <div>

            <asp:TextBox ID="txtSpesaPasto" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pasto" />

            <asp:TextBox ID="txtSpesaTrasporto" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Trasporto" />

            <asp:TextBox ID="txtSpesaPedaggi" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pedaggi" />

            <asp:TextBox ID="txtSpesaPernottamento" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pernottamento" />

            <asp:TextBox ID="txtSpesaExtra" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Extra" />

            <asp:TextBox ID="txtDesSpesaExtra" runat="server" type="text" CssClass="form-control textbox" placeholder="*Descrizione della spesa Extra" TextMode="MultiLine" />

        </div>
        <div>
            <asp:Label runat="server" Text="Controllo"></asp:Label>
            <asp:DropDownList ID="ddlControlli" runat="server"></asp:DropDownList>

            <asp:Button ID="btnConferma" runat="server" CssClass="button" Text="Conferma Report" OnClick="btnConferma_Click" />
        </div>

        <p>*facoltativi</p>
    </div>
</asp:Content>

