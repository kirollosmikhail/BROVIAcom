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
        if (codfiscale_txt.Text != "" && RagSociale_txt.Text != "" && pIVA_txt.Text != "" && PersonaRif_txt.Text != ""
   && email_txt.Text != "" && citta_txt.Text != "" && CAP_txt.Text != "" && indirizzo_txt.Text != "")
        {
            CLIENTI c = new CLIENTI();
            c.Ragione_Sociale = RagSociale_txt.Text.Trim();
            c.Codice_Fiscale = codfiscale_txt.Text.Trim();
            c.P_IVA = pIVA_txt.Text.Trim();
            c.Persona_Riferimento = PersonaRif_txt.Text.Trim();
            c.Email = email_txt.Text.Trim();
            c.Citta = citta_txt.Text.Trim();
            c.CAP = CAP_txt.Text.Trim();
            c.Indirizzo = indirizzo_txt.Text.Trim();

            c.ClientiIns();
            Response.Redirect("ClientiSelect.aspx");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riempi tutti i campi');", true);
    }
}