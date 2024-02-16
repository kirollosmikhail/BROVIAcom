<%@ Page Title="" Language="C#" MasterPageFile="~/MasterHome.master" AutoEventWireup="true" CodeFile="DipendentiMod.aspx.cs" Inherits="DipendentiMod" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Modifica Dipendente</h2>
    <br />
    <div class="divdati">
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Codice Fiscale"></asp:Label>
                <asp:TextBox ID="codfiscale_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Codice Fiscale" />
            </div>
            <div>
                <asp:Label runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="nome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Nome" />
            </div>
            <div>
                <asp:Label runat="server" Text="Cognome"></asp:Label>
                <asp:TextBox ID="cognome_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Cognome" />
            </div>
            <div>
                <asp:Label runat="server" Text="Username (@Mail)"></asp:Label>
                <asp:TextBox ID="USR_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Username  (@Mail)" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Data Assunzione"></asp:Label>
                <asp:TextBox ID="dataass_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Data Assunzione" TextMode="Date" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Data Licenziamento"></asp:Label>
                <asp:TextBox ID="datalic_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Data Licenziamento" TextMode="Date" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Tipo dipendente"></asp:Label>
                &nbsp
         <asp:DropDownList ID="ddlTipiDipendenti" runat="server" CssClass="form-control textbox"></asp:DropDownList>
            </div>
            <div>
                <asp:Label runat="server" Text="*Partita IVA"></asp:Label>
                <asp:TextBox ID="pIVA_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Partita IVA" />
            </div>
            <div>
                <asp:Label runat="server" Text="*Salario"></asp:Label>
                <asp:TextBox ID="salario_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="*Salario" />
            </div>
        </div>
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox ID="telefono_txt" runat="server" type="text" CssClass="form-control textbox" placeholder="Telefono" />
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
        <div class="contdati">
            <div>
                <asp:Label runat="server" Text="Abilitazione"></asp:Label>
                <div id="raddiv" class="divrad">
                    <div id="raddivsi">
                        <asp:RadioButton ID="rad_si" runat="server" Text="si" GroupName="Condizioni"></asp:RadioButton>
                    </div>
                    <div id="raddivno">
                        <asp:RadioButton ID="rad_no" runat="server" Text="no" GroupName="Condizioni"></asp:RadioButton>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <p>*facoltativi</p>
    <asp:Button runat="server" ID="btnConfirma" CssClass="button" Text="Conferma" OnClick="btnConfirma_Click" />
</asp:Content>

