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
        BindGridView();
    }

    private void BindGridView()
    {
        CLIENTI c = new CLIENTI();
        if (cerca.Text == "")
        {
            GridView2.DataSource = c.ClientiSelect();
        }
        else
        {
            c.Ragione_Sociale = cerca.Text;
            DataTable dt = c.ClientiCerca();
            if (dt.Rows.Count == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Nessun record trovato');", true);
                GridView2.DataSource = c.ClientiSelect();
            }
            else
            {
                GridView2.DataSource = dt;
            }
        }
        // Imposta il paging
        GridView2.AllowPaging = true;
        GridView2.PageSize = 10; // Imposta il numero di righe per pagina
        GridView2.DataBind();
    }
        protected void paging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        BindGridView(); // Rileggi i dati per la nuova pagina
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView2.SelectedValue.ToString();
        Response.Redirect("ClientiMod.aspx?id=" + Id);
    }
}