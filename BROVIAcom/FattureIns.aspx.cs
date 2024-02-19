using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FattureIns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DdlRiempiCommesse();
    }

    protected void DdlRiempiCommesse()
    {
        COMMESSE t = new COMMESSE();
        DataTable dt = t.CommesseDDL();
        ddlCommessa.DataSource = dt;
        ddlCommessa.DataTextField = "Descrizione_Commessa";
        ddlCommessa.DataValueField = "Cod_Commessa";
        ddlCommessa.DataBind();
    }





    protected void btnInsert_Click(object sender, EventArgs e)
    {
        if (datafat_txt.Text.Trim() != "" && descfat_txt.Text.Trim() != "" && IVA_txt.Text.Trim() != "")
        {
            if (decimal.Parse(IVA_txt.Text.Trim()) < 0 || decimal.Parse(IVA_txt.Text.Trim()) > 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('IVA non compresa tra 0 e 1');", true);
                return;
            }
            FATTURE f=new FATTURE();
            f.Data_Fattura = DateTime.Parse(datafat_txt.Text.Trim());
            f.Descrizione = descfat_txt.Text.Trim();
            f.IVA = decimal.Parse(IVA_txt.Text.Trim());
            f.Cod_Commessa = int.Parse(ddlCommessa.SelectedValue);

            f.FattureIns();
            Response.Redirect("FattureSelect.aspx");
        }

        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riemi Tutti Campi Obligatori');", true);
    }
}