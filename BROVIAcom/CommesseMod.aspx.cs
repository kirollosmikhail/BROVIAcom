using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommesseMod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DdlRiempiRagioneSociale();
            DdlRiempiTipiCommesse();
            RiemiCampi();
        }
    }
    protected void RiemiCampi()
    {
        COMMESSE d = new COMMESSE();

        d.Cod_Commessa = int.Parse(Request.QueryString["Id"].ToString());

        DataTable dt = d.CommesseRiempiMod();

        desccom_txt.Text = dt.Rows[0]["Descrizione_Commessa"].ToString();
        datainiz_txt.Text = Convert.ToDateTime(dt.Rows[0]["Data_Inizio"]).ToString("yyyy-MM-dd");
        if(dt.Rows[0]["Data_Fine"]!= DBNull.Value)
            datafin_txt.Text = Convert.ToDateTime(dt.Rows[0]["Data_Fine"]).ToString("yyyy-MM-dd");
        anticipo_txt.Text = dt.Rows[0]["Anticipo"].ToString();
        impacorpo_txt.Text= dt.Rows[0]["Importo_ACorpo"].ToString();
        impmensile_txt.Text= dt.Rows[0]["Importo_CanoneMensile"].ToString();
        imporario_txt.Text= dt.Rows[0]["Importo_Orario"].ToString();

        ddlTipiCommesse.SelectedValue = dt.Rows[0]["Cod_Tipo_Commessa"].ToString();
        ddlRagioneSociale.SelectedValue = dt.Rows[0]["Cod_Cliente"].ToString();
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




    protected void btnConfirma_Click(object sender, EventArgs e)
    {
        COMMESSE d = new COMMESSE();
        d.Cod_Commessa= int.Parse(Request.QueryString["Id"].ToString());
        d.Data_Inizio = DateTime.Parse(datainiz_txt.Text.Trim());
        if (datafin_txt.Text.Trim() != "")
            d.Data_Fine = DateTime.Parse(datafin_txt.Text.Trim());
        d.Descrizione_Commessa=desccom_txt.Text.Trim();
        if(anticipo_txt.Text.Trim() !="")
            d.Anticipo= decimal.Parse(anticipo_txt.Text.Trim());
        if (impacorpo_txt.Text.Trim() != "")
            d.Importo_ACorpo= decimal.Parse(impacorpo_txt.Text.Trim());
        if (impmensile_txt.Text.Trim() != "")
            d.Importo_CanoneMensile= decimal.Parse(impmensile_txt.Text.Trim());
        if (imporario_txt.Text.Trim() != "")
            d.Importo_Orario= decimal.Parse(imporario_txt.Text.Trim());

        d.Cod_Tipo_Commessa = int.Parse(ddlTipiCommesse.SelectedValue);
        d.Cod_Cliente = int.Parse(ddlRagioneSociale.SelectedValue);

        d.CommesseMod();
        Response.Redirect("CommesseSelect.aspx");

    }
}