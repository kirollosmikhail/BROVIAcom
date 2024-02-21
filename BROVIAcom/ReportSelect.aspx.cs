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
            BindGridView2();
        }

        BindGridView();
    }
    private void BindGridView()
    {
        if (IsPostBack)
        {
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
            // Imposta il paging
            GridView1.AllowPaging = true;
            GridView1.PageSize = 10; // Imposta il numero di righe per pagina
            GridView1.DataBind();
        }
    }
    private void BindGridView2()
    {
        ReportApprovati();
    }

    protected void paging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindGridView(); // Rileggi i dati per la nuova pagina
    }
    protected void paging2(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindGridView2(); // Rileggi i dati per la nuova pagina
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string x = GridView1.SelectedValue.ToString();
        Response.Redirect("ReportMod.aspx?cod=" + x);
    }

    protected void SessionDipendenti()
    {
        DIPENDENTI d = new DIPENDENTI();
        d.Cod_Dipendente = int.Parse(Session["Cod_Dipendente"].ToString());
        DataTable dt = d.SessionSelectDipendenti();
        if (dt.Rows[0]["Cod_Tipo_Dipendente"].ToString() == "1" || dt.Rows[0]["Cod_Tipo_Dipendente"].ToString() == "2")
        {
            Inserisci.Visible = false;
            reportApprovati.Visible = false;
            GridView2.Visible = false;
            LAVORI l = new LAVORI();
            GridView1.DataSource = l.LavoriSelect(); 
        }
        else
        {
            REPORT r = new REPORT();
            r.Cod_Dipendente = int.Parse(Session["Cod_Dipendente"].ToString());
            GridView1.DataSource = r.ReportDipendentiSelect();   
        }
        // Imposta il paging
        GridView1.AllowPaging = true;
        GridView1.PageSize = 10; // Imposta il numero di righe per pagina
        GridView1.DataBind();
    }

    protected void ReportApprovati()
    {
        REPORT r = new REPORT();
        r.Cod_Dipendente = int.Parse(Session["Cod_Dipendente"].ToString());
        GridView2.DataSource = r.ReportApprovati();
        // Imposta il paging
        GridView1.AllowPaging = true;
        GridView1.PageSize = 10; // Imposta il numero di righe per pagina
        GridView2.DataBind();
    }


}