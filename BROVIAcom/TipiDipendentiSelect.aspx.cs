using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TipiDipendentiSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindGridView();
    }

    private void BindGridView()
    {
        TIPI_DIPENDENTI d = new TIPI_DIPENDENTI();
        GridView1.DataSource = d.TipiDipendentiSelect();
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
        TIPI_DIPENDENTI d = new TIPI_DIPENDENTI();
        d.Cod_Tipo_Dipendente = int.Parse(GridView1.SelectedValue.ToString());
        d.TipiDipendentiElimina();
        Page_Load(sender, e);
    }
}