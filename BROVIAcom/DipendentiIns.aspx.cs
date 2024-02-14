using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DipendentiIns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DdlRiempiTipiDipendenti();
    }
    protected void DdlRiempiTipiDipendenti()
    {
        TIPI_DIPENDENTI t = new TIPI_DIPENDENTI();
        DataTable dt = t.TipiDipendentiSelect();
        ddlTipiDipendenti.DataSource = dt;
        ddlTipiDipendenti.DataTextField = "Tipo_Dipendente";
        ddlTipiDipendenti.DataValueField = "Cod_Tipo_Dipendente";
        ddlTipiDipendenti.DataBind();
    }




    protected void btninsert_Click(object sender, EventArgs e)
    {
        if (codfiscale_txt.Text != "" && nome_txt.Text != "" && cognome_txt.Text != "" && USR_txt.Text != "" && dataass_txt.Text != ""
           && telefono_txt.Text != "" && citta_txt.Text != "" && CAP_txt.Text != "" &&
            indirizzo_txt.Text != "")
        {
            DIPENDENTI d = new DIPENDENTI();
            d.Cognome = cognome_txt.Text.Trim();
            d.Nome = nome_txt.Text.Trim();
            d.Codice_Fiscale = codfiscale_txt.Text.Trim();
            d.P_IVA = pIVA_txt.Text.Trim();
            d.Data_Assunzione = DateTime.Parse(dataass_txt.Text.Trim());
            if (datalic_txt.Text.Trim() != "")
                d.Data_Licenziamento = DateTime.Parse(datalic_txt.Text.Trim());

            bool x = decimal.TryParse(salario_txt.Text.Trim(), out d.Salario);

            d.Cod_Tipo_Dipendente = int.Parse(ddlTipiDipendenti.SelectedValue);
            d.Telefono = telefono_txt.Text.Trim();
            d.Citta = citta_txt.Text.Trim();
            d.CAP = CAP_txt.Text.Trim();
            d.Indirizzo = indirizzo_txt.Text.Trim();
            d.USR = USR_txt.Text.Trim();
            
            d.DipendentiIns();
            Response.Redirect("DipendentiSelect.aspx");
        }



        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riemi Tutti Campi Obligatori');", true);

    }
}