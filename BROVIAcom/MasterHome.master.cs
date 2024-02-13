using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterHome : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void home_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("login/login.aspx");
    }

    protected void dipendenti_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("DipendentiSelect.aspx");
    }
}
