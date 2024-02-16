<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="ReportMod.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Modifica Report</h2>
    <br />
    <div class="divdati">
        <div class="contdati">

            <div>
                <asp:Label ID="lblCognome" runat="server" Text="ciao"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblNome" runat="server" Text="tutto"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblDataReport" runat="server" Text="oooo"></asp:Label>
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Commessa"></asp:Label>
                <asp:DropDownList ID="ddlCommessa" runat="server" CssClass="form-control textbox"></asp:DropDownList>
            </div>
            <div>
                <asp:Label runat="server" Text="Descrizione del lavoro svolto"></asp:Label>
                <asp:TextBox ID="txtDesLavoro" runat="server" type="text" CssClass="form-control textbox" placeholder="Descrizione del lavoro svolto" TextMode="MultiLine" />
            </div>
            <div>
                <asp:Label runat="server" Text="Numero di ore"></asp:Label>
                <asp:TextBox ID="txtOre" runat="server" type="text" CssClass="form-control textbox" placeholder="Numero di ore" TextMode="Time" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="*Spesa Pasto"></asp:Label>
                <asp:TextBox ID="txtSpesaPasto" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pasto" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Spesa Trasporto"></asp:Label>
                <asp:TextBox ID="txtSpesaTrasporto" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Trasporto" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Spesa Pedaggi"></asp:Label>
                <asp:TextBox ID="txtSpesaPedaggi" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pedaggi" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Spesa Pernottamento"></asp:Label>
                <asp:TextBox ID="txtSpesaPernottamento" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Pernottamento" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Spesa Extra"></asp:Label>
                <asp:TextBox ID="txtSpesaExtra" runat="server" type="text" CssClass="form-control textbox" placeholder="*Spesa Extra" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Descrizione della spesa Extra"></asp:Label>
                <asp:TextBox ID="txtDesSpesaExtra" runat="server" type="text" CssClass="form-control textbox" placeholder="*Descrizione della spesa Extra" TextMode="MultiLine" />
            </div>
        </div>
        <div id="" class="contdati" runat="server" visible="false">
            <div>
                <asp:Label runat="server" Text="Controllo"></asp:Label>
                <asp:DropDownList ID="ddlControlli" runat="server" CssClass="form-control textbox"></asp:DropDownList>
            </div>
        </div>
    </div>
    <p>*facoltativi</p>
    <asp:Button ID="btnConferma" runat="server" CssClass="button" Text="Conferma Report" OnClick="btnConferma_Click" />
</asp:Content>

