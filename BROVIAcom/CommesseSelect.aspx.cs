using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommesseSelect : System.Web.UI.Page
{
    static DataTable dtx = new DataTable();
    static string x = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DdlRiempiTipiCommesse();

            BindGridView();
            x = cerca.Text;
        }
        else
        {
            if (x != cerca.Text)
            {
                BindGridView();
                x = cerca.Text;
            }
            else
            {
                GridView1.DataSource = dtx;
                GridView1.AllowPaging = true;
                GridView1.PageSize = 10; // Imposta il numero di righe per pagina
                GridView1.DataBind();
            }
        }
    }

    private void BindGridView()
    {
        COMMESSE c = new COMMESSE();
        if (cerca.Text == "" && ddlTipiCommesse.SelectedValue == "-Tutte-")
        {
            GridView1.DataSource = c.CommesseSelect();
        }
        else
        {
            c.Ragione_Sociale = cerca.Text;
            if (ddlTipiCommesse.SelectedValue == "-Tutte-")
                c.Cod_Tipo_Commessa = 0;
            else
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
        dtx = GridView1.DataSource as DataTable;
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
    protected void DdlRiempiTipiCommesse()
    {
        TIPI_COMMESSE t = new TIPI_COMMESSE();
        DataTable dt = t.TipiCommesseSelect();
        ddlTipiCommesse.DataSource = dt;
        ddlTipiCommesse.DataTextField = "Nome_Commessa";
        ddlTipiCommesse.DataValueField = "Cod_Tipo_Commessa";
        ddlTipiCommesse.DataBind();
        ListItem vuoto = new ListItem();
        vuoto.Value = "-Tutte-";
        ddlTipiCommesse.Items.Insert(0, vuoto);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView1.SelectedValue.ToString();
        Response.Redirect("CommesseMod.aspx?id=" + Id);
    }
}