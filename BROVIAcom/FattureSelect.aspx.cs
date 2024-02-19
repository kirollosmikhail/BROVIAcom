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
            if (!string.IsNullOrEmpty(Cerca2.Text.Trim()))
            {
                string[] parts = Cerca2.Text.Trim().Split('/');
                if (parts.Length == 2 && int.TryParse(parts[0], out int month) && int.TryParse(parts[1], out int year))
                {
                    if (month >= 1 && month <= 12 && year >= 1753 && year <= 9999)
                    {
                        f.Ragione_Sociale = "";
                        f.MeseFattura = int.Parse(parts[0]);
                        f.AnnoFattura = int.Parse(parts[1]);
                        GridView1.DataSource = f.FattureCerca();
                    }
                    else
                    {
                        GridView1.DataSource = f.FattureSelect();
                    }
                }
                else
                {
                    GridView1.DataSource = f.FattureSelect();
                }
            }
            else
            {
                GridView1.DataSource = f.FattureSelect();
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