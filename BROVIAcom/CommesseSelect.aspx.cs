using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommesseSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DdlRiempiTipiCommesse();
        }

        COMMESSE c = new COMMESSE();
        if (cerca.Text == ""&& int.Parse(ddlTipiCommesse.SelectedValue)==0)
        {
            GridView1.DataSource = c.CommesseSelect();
        }
        else
        {
            c.Ragione_Sociale = cerca.Text;
            c.Cod_Tipo_Commessa = int.Parse(ddlTipiCommesse.SelectedValue);
            DataTable dt = c.CommesseCerca();

            if (dt.Rows.Count == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Nessun record trovato');", true);
                GridView1.DataSource = c.CommesseSelect();
            }
            else
            {
                GridView1.DataSource = dt;
            }
        }

        GridView1.DataBind();
    }
    protected void DdlRiempiTipiCommesse()
    {
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        DataTable dt = t.TipiCommesseSelect();
        ddlTipiCommesse.DataSource = dt;
        ddlTipiCommesse.DataTextField = "Nome_Commessa";
        ddlTipiCommesse.DataValueField = "Cod_Tipo_Commessa";
        ddlTipiCommesse.DataBind();
        ListItem vuoto = new ListItem();
        vuoto.Value = "0";
        ddlTipiCommesse.Items.Insert(0, vuoto);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView1.SelectedValue.ToString();
        Response.Redirect("CommesseMod.aspx?id=" + Id);
    }
}