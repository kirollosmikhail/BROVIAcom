using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DipendentiSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DIPENDENTI d = new DIPENDENTI();
        if (cerca.Text == "")
        {
        GridView1.DataSource = d.DipendentiSelect();
        }
        else
        {
            d.Cognome=cerca.Text;
            DataTable dt= d.DipendentiCerca();
            if(dt.Rows.Count == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Nessun record trovato');", true);
                GridView1.DataSource = d.DipendentiSelect();
            }
            else
            {
                GridView1.DataSource = dt;
            }
        }

        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView1.SelectedValue.ToString();
        Response.Redirect("DipendentiMod.aspx?id="+ Id);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}