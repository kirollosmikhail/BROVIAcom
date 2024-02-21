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
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        GridView3.DataSource = t.TipiCommesseSelect();
        // Imposta il paging
        GridView3.AllowPaging = true;
        GridView3.PageSize = 10; // Imposta il numero di righe per pagina
        GridView3.DataBind();
    }

    protected void paging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        BindGridView(); // Rileggi i dati per la nuova pagina
    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        t.Cod_Tipo_Commessa = int.Parse(GridView3.SelectedValue.ToString());
        t.TipiCommesseElimina();
        Page_Load(sender, e);
    }
}