using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RiempiCampi();
        }
    }

    protected void RiempiCampi()
    {
        CLIENTI c = new CLIENTI();

        c.Cod_Cliente = int.Parse(Request.QueryString["Id"].ToString());
        c.Ragione_Sociale = "NULL";
        DataTable dt = c.ClientiCerca();
        RagSociale_txt.Text = dt.Rows[0]["Ragione_Sociale"].ToString();
        codfiscale_txt.Text = dt.Rows[0]["Codice_Fiscale"].ToString();
        pIVA_txt.Text = (dt.Rows[0]["P_IVA"].ToString()).Trim();
        PersonaRif_txt.Text = dt.Rows[0]["Persona_Riferimento"].ToString();
        email_txt.Text = dt.Rows[0]["Email"].ToString();
        citta_txt.Text = dt.Rows[0]["Citta"].ToString();
        CAP_txt.Text = dt.Rows[0]["CAP"].ToString();
        indirizzo_txt.Text = dt.Rows[0]["Indirizzo"].ToString();
    }


    protected void btnConferma_Click(object sender, EventArgs e)
    {
        CLIENTI c = new CLIENTI();
        c.Cod_Cliente = int.Parse(Request.QueryString["Id"].ToString());
        c.Ragione_Sociale = RagSociale_txt.Text.Trim();
        c.Codice_Fiscale = codfiscale_txt.Text.Trim();
        c.P_IVA = pIVA_txt.Text.Trim();
        c.Persona_Riferimento = PersonaRif_txt.Text.Trim();
        c.Email = email_txt.Text.Trim();
        c.Citta = citta_txt.Text.Trim();
        c.CAP = CAP_txt.Text.Trim();
        c.Indirizzo = indirizzo_txt.Text.Trim();

        c.ClientiMod();
        Response.Redirect("ClientiSelect.aspx");
    }
}