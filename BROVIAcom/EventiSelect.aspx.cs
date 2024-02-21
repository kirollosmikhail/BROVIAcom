using System;
using System.Collections.Generic;
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
        EVENTI V = new EVENTI();
        GridView1.DataSource = V.EventiSelect();
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

    protected void btnElimena_Click(object sender, EventArgs e)
    {
        EVENTI v = new EVENTI();
        v.EventiElimina();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('I Dati sono stati cancellati corretamente');", true);
        Page_Load(sender, e);

    }
}