using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReportApprovati();
            SessionDipendenti();
        }


        REPORT r = new REPORT();
        if (Cerca2.Text.Trim() != "")
        {
            DateTime dataMinimaSupportata = new DateTime(1753, 1, 1);
            DateTime dataMassimaSupportata = new DateTime(9999, 12, 31);

            if (DateTime.Parse(Cerca2.Text.Trim()) < dataMinimaSupportata || DateTime.Parse(Cerca2.Text.Trim()) > dataMassimaSupportata)
            {
                GridView1.DataSource = r.ReportSelect();
            }
            else
            {
                r.Data_Report = DateTime.Parse(Cerca2.Text.Trim());
                GridView1.DataSource = r.ReportCerca();
            }
        }
        GridView1.DataBind();
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

    protected void ReportApprovati()
    {
        REPORT r = new REPORT();
        r.Cod_Dipendente = 6;
        GridView2.DataSource = r.ReportApprovati();
        GridView2.DataBind();
    }


}