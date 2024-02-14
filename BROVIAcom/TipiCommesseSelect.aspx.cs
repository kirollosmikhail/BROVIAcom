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
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        GridView3.DataSource = t.TipiCommesseSelect();
        GridView3.DataBind();
    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        t.Cod_Tipo_Commessa = int.Parse(GridView3.SelectedValue.ToString());
        t.TipiCommesseElimina();
        Page_Load(sender, e);
    }
}