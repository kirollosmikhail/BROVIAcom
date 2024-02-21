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
        FATTURE F = new FATTURE();
        GridView1.DataSource = F.RicaviSelect();
        GridView1.DataBind();
    }

}