using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RicaviSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindGridView();
    }

    private void BindGridView()
    {
        FATTURE F = new FATTURE();
        GridView1.DataSource = F.RicaviSelect();
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
}