using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "" || txtPassword.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Riempi tutti i campi');", true);
            return;
        }

        DIPENDENTI d = new DIPENDENTI();
        d.USR = txtUsername.Text.Trim();
        d.PWD = txtPassword.Text;
        DataTable dt = d.Login();

        if (dt.Rows.Count > 0) //trova lo USR nel DataBase
        {

            Session["Cod_Dipendente"] = dt.Rows[0]["Cod_Dipendente"].ToString();
            if (dt.Rows[0]["PWD"].ToString() == "benvenuto") //se dipendente effettua il primo accesso
            {
                Response.Redirect("CambiaPWD.aspx");
                return;
            }
            Response.Redirect("../Home.aspx");
            return;
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Utente inesistente o bloccato');", true);
        return;
    }
}