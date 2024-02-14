using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TipiDipendentiIns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        if (tipodipendente_txt.Text != "" )
        {
            TIPI_DIPENDENTI d = new TIPI_DIPENDENTI();
            d.Tipo_Dipendente = tipodipendente_txt.Text.Trim();
            
            d.TipiDipendentiIns();
            Response.Redirect("TipiDipendentiSelect.aspx");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riemi Tutti Campi Obligatori');", true);

    }
}