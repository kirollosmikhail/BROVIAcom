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
           
            SessionDipendenti();
        }

    }

    protected void ReportSelect()
    {
        LAVORI l = new LAVORI();
        GridView1.DataSource = l.LavoriSelect();
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string x = GridView1.SelectedValue.ToString();
        Response.Redirect("ReportMod.aspx?cod=" + x);
    }

    protected void SessionDipendenti()
    {
        DIPENDENTI d = new DIPENDENTI();
        d.Cod_Dipendente = 6;//int.Parse(Session["Cod_Dipendente"].ToString());
        DataTable dt = d.SessionSelectDipendenti();
        if (dt.Rows[0]["Cod_Tipo_Dipendente"].ToString() == "1" || dt.Rows[0]["Cod_Tipo_Dipendente"].ToString() == "2")
        {
            Inserisci.Visible = false;
            ReportSelect();
        }
        else
        {
            ReportDipendentiSelect();
        }
    }

    protected void ReportDipendentiSelect()
    {
        REPORT r = new REPORT();
        r.Cod_Dipendente = 6;
        GridView1.DataSource = r.ReportDipendentiSelect();
        GridView1.DataBind();
    }
}