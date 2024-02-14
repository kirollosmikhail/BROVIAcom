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
        EventiSelect();
    }

    protected void EventiSelect()
    {
        EVENTI V = new EVENTI();
        GridView1.DataSource=V.EventiSelect();
        GridView1.DataBind();
    }
    protected void btnElimena_Click(object sender, EventArgs e)
    {
        EVENTI v = new EVENTI();
        v.EventiElimina();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('I Dati sono stati cancellati corretamente');", true);
        Page_Load(sender, e);

    }
}