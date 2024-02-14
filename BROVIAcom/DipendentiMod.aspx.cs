using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager;

public partial class DipendentiMod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DdlRiempiTipiDipendenti();
            RiemiCampi();
        }
    }
    protected void RiemiCampi()
    {
        DIPENDENTI d = new DIPENDENTI();

        d.Cod_Dipendente = int.Parse(Request.QueryString["Id"].ToString());
        d.Cognome = "NULL";
        DataTable dt = d.DipendentiCerca();
        nome_txt.Text = dt.Rows[0]["Nome"].ToString();
        cognome_txt.Text = dt.Rows[0]["Cognome"].ToString();
        USR_txt.Text = dt.Rows[0]["USR"].ToString();
        dataass_txt.Text = dt.Rows[0]["Data_Assunzione"].ToString();
        datalic_txt.Text = dt.Rows[0]["Data_Licenziamento"].ToString();
        codfiscale_txt.Text = dt.Rows[0]["Codice_Fiscale"].ToString();
        salario_txt.Text = dt.Rows[0]["Salario"].ToString();
        telefono_txt.Text = dt.Rows[0]["Telefono"].ToString();
        citta_txt.Text = dt.Rows[0]["Citta"].ToString();
        CAP_txt.Text = dt.Rows[0]["CAP"].ToString();
        indirizzo_txt.Text = dt.Rows[0]["Indirizzo"].ToString();
        pIVA_txt.Text = (dt.Rows[0]["P_IVA"].ToString()).Trim();
        if (dt.Rows[0]["Abilitato"].ToString() == "True")
        {
            rad_si.Checked = true;
        }
        else
        {
            rad_no.Checked = true;
        }
        ddlTipiDipendenti.SelectedValue = dt.Rows[0]["Cod_Tipo_Dipendente"].ToString();
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




    protected void btnConfirma_Click(object sender, EventArgs e)
    {
        DIPENDENTI d = new DIPENDENTI();
        d.Cod_Dipendente = int.Parse(Request.QueryString["Id"].ToString());
        d.Cognome = cognome_txt.Text.Trim();
        d.Nome = nome_txt.Text.Trim();
        d.Codice_Fiscale = codfiscale_txt.Text.Trim();
        d.P_IVA = pIVA_txt.Text.Trim();
        d.Data_Assunzione = DateTime.Parse(dataass_txt.Text.Trim());
        if (datalic_txt.Text.Trim() !="" )
        d.Data_Licenziamento = DateTime.Parse(datalic_txt.Text.Trim());
        

        d.Salario = decimal.Parse( salario_txt.Text.Trim());
        d.Cod_Tipo_Dipendente =int.Parse(ddlTipiDipendenti.SelectedValue);
        d.Telefono = telefono_txt.Text.Trim();
        d.Citta = citta_txt.Text.Trim();
        d.CAP = CAP_txt.Text.Trim();
        d.Indirizzo = indirizzo_txt.Text.Trim();
        d.USR = USR_txt.Text.Trim();
        if(rad_si.Checked)
        {
            d.Abilitato = true;
        }
        else
        {
            d.Abilitato = false;
        }
        d.DipendentiMod();
        Response.Redirect("DipendentiSelect.aspx");

    }
}