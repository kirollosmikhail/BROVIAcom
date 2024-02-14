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
        TIPI_DIPENDENTI d = new TIPI_DIPENDENTI();
        GridView1.DataSource = d.TipiDipendentiSelect();
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TIPI_DIPENDENTI d=new TIPI_DIPENDENTI();
        d.Cod_Tipo_Dipendente = int.Parse(GridView1.SelectedValue.ToString());
        d.TipiDipendentiElimina();
        Page_Load(sender, e);
    }
}