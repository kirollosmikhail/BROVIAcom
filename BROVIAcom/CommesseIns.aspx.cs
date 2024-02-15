using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommesseIns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DdlRiempiTipiCommesse();
        DdlRiempiRagioneSociale();
    }

    protected void DdlRiempiTipiCommesse()
    {
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        DataTable dt = t.TipiCommesseSelect();
        ddlTipiCommesse.DataSource = dt;
        ddlTipiCommesse.DataTextField = "Nome_Commessa";
        ddlTipiCommesse.DataValueField = "Cod_Tipo_Commessa";
        ddlTipiCommesse.DataBind();
    }
    protected void DdlRiempiRagioneSociale()
    {
        CLIENTI t = new CLIENTI();
        DataTable dt = t.ClientiSelect();
        ddlRagioneSociale.DataSource = dt;
        ddlRagioneSociale.DataTextField = "Ragione_Sociale";
        ddlRagioneSociale.DataValueField = "Cod_Cliente";
        ddlRagioneSociale.DataBind();
    }




    protected void btnInsert_Click(object sender, EventArgs e)
    {
        if (desccom_txt.Text != "" && datainiz_txt.Text != "")
        {
            COMMESSE d = new COMMESSE();

            d.Data_Inizio = DateTime.Parse(datainiz_txt.Text.Trim());
            if (datafin_txt.Text.Trim() != "")
                d.Data_Fine = DateTime.Parse(datafin_txt.Text.Trim());
            d.Descrizione_Commessa = desccom_txt.Text.Trim();
            if (anticipo_txt.Text.Trim() != "")
                d.Anticipo = decimal.Parse(anticipo_txt.Text.Trim());
            if (impacorpo_txt.Text.Trim() != "")
                d.Importo_ACorpo = decimal.Parse(impacorpo_txt.Text.Trim());
            if (impmensile_txt.Text.Trim() != "")
                d.Importo_CanoneMensile = decimal.Parse(impmensile_txt.Text.Trim());
            if (imporario_txt.Text.Trim() != "")
                d.Importo_Orario = decimal.Parse(imporario_txt.Text.Trim());

            d.Cod_Tipo_Commessa = int.Parse(ddlTipiCommesse.SelectedValue);
            d.Cod_Cliente = int.Parse(ddlRagioneSociale.SelectedValue);

            d.CommesseIns();
            Response.Redirect("CommesseSelect.aspx");
        }



        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riemi Tutti Campi Obligatori');", true);

    }
}