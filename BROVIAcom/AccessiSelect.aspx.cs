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

        ACCESSI a = new ACCESSI();
        GridView1.DataSource = a.AccessiSelect();
        GridView1.DataBind();


    }

    protected void btnElimena_Click(object sender, EventArgs e)
    {
        ACCESSI a = new ACCESSI();
        a.AccessiElimina();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('I Dati sono stati cancellati corretamente');", true);
        Page_Load(sender, e);
    }
}