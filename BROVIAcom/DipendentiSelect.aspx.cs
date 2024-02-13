using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DipendentiSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DIPENDENTI d = new DIPENDENTI();
        GridView1.DataSource = d.DipendentiSelect();
        GridView1.DataBind();
    }

}