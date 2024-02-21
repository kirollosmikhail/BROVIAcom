using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DipendentiSelect : System.Web.UI.Page
{
    static DataTable dtx = new DataTable();
    static string x = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridView();
            x = cerca.Text;
        }
        else
        {
            if (x != cerca.Text)
            {
                BindGridView();
                x = cerca.Text;
            }
            else
            {
                GridView1.DataSource = dtx;
                GridView1.AllowPaging = true;
                GridView1.PageSize = 10; // Imposta il numero di righe per pagina
                GridView1.DataBind();
            }
        }
    }

    private void BindGridView()
    {
        DIPENDENTI d = new DIPENDENTI();
        if (cerca.Text == "")
        {
            GridView1.DataSource = d.DipendentiSelect();
        }
        else
        {
            d.Cognome = cerca.Text;
            DataTable dt = d.DipendentiCerca();
            if (dt.Rows.Count == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Nessun record trovato');", true);
                GridView1.DataSource = d.DipendentiSelect();
            }
            else
            {
                GridView1.DataSource = dt;
            }
        }
        dtx = GridView1.DataSource as DataTable;
        // Imposta il paging
        GridView1.AllowPaging = true;
        GridView1.PageSize = 10; // Imposta il numero di righe per pagina

        GridView1.DataBind();
    }

    protected void paging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindGridView(); // Rileggi i dati per la nuova pagina
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView1.SelectedValue.ToString();
        Response.Redirect("DipendentiMod.aspx?id=" + Id);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
    }
}