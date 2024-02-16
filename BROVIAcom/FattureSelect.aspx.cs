using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FattureSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            rad_1.Checked = true;
        }
        FATTURE f = new FATTURE();
        if (rad_1.Checked)
        {
            if (cerca.Text.Trim() == "")
            {
                GridView1.DataSource = f.FattureSelect();
            }
            else
            {
                f.Data_Fattura = null;
                f.Ragione_Sociale = cerca.Text.Trim();
                GridView1.DataSource = f.FattureCerca();
            }
        }
        else
        {
            if (Cerca2.Text.Trim() != "")
            {
                DateTime dataMinimaSupportata = new DateTime(1753, 1, 1);
                DateTime dataMassimaSupportata = new DateTime(9999, 12, 31);

                if (DateTime.Parse(Cerca2.Text.Trim()) < dataMinimaSupportata || DateTime.Parse(Cerca2.Text.Trim()) > dataMassimaSupportata)
                {
                    GridView1.DataSource = f.FattureSelect();
                }
                else
                {
                    f.Ragione_Sociale = "";
                    f.Data_Fattura = DateTime.Parse(Cerca2.Text.Trim());
                    GridView1.DataSource = f.FattureCerca();
                }
            }
        }
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Id = GridView1.SelectedValue.ToString();
        Response.Redirect("FattureMod.aspx?id=" + Id);
    }
}