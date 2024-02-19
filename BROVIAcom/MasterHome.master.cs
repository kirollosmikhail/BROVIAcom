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
        if (!IsPostBack)
        {
            if (Session["Cod_Dipendente"] == null)
            {
                Response.Redirect("login/login.aspx");
            }

            if(Session["Cod_Tipo_Dipendente"].ToString() != "1" && Session["Cod_Tipo_Dipendente"].ToString() != "2")
            {
                accessi_btn.Visible = false;
                clienti_btn.Visible = false;
                commesse_btn.Visible = false;
                dipendenti_btn.Visible = false;
                eventi_btn.Visible = false; 
                fatture_btn.Visible = false;
            }
            else if(Session["Cod_Tipo_Dipendente"].ToString() == "2")
            {
          
            }
        }
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

    protected void clienti_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClientiSelect.aspx");
    }

    protected void accessi_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccessiSelect.aspx");
    }

    protected void commesse_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("CommesseSelect.aspx");
    }

    protected void eventi_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("EventiSelect.aspx");
    }

    protected void report_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReportSelect.aspx");
    }

    protected void fatture_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("FattureSelect.aspx");
    }
}

