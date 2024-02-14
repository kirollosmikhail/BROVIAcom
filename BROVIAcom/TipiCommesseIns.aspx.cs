using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsert_Click(object sender, EventArgs e)
    {
        if (tipocommessa_txt.Text != "")
        {
            TIPI_COMMESSE t = new TIPI_COMMESSE();
            t.Nome_Commessa = tipocommessa_txt.Text.Trim();

            t.TipiCommesseIns();
            Response.Redirect("TipiCommesseSelect.aspx");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riempi Tutti I Campi');", true);

    }

}