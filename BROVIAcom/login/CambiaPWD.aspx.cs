using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CambiaPWD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["Cod_Dipendente"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtPassword.Text == "" || txtConfermaPassword.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riempi tutti i campi');", true);
            return;
        }

        if(txtPassword.Text != txtConfermaPassword.Text)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Le password non coincidono');", true);
            return;
        }

        DIPENDENTI d = new DIPENDENTI();
        d.PWD = txtPassword.Text;
        d.Cod_Dipendente = int.Parse(Session["Cod_Dipendente"].ToString());
        d.CambiaPWD();
        Response.Redirect("login.aspx");
    }
}