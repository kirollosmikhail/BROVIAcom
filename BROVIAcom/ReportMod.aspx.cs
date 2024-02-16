using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlControllo();
            ddlCommesseSelect();
            RiempiCampi();
        }
    }

    protected void ddlControllo()
    {
        CONTROLLI c = new CONTROLLI();
        ddlControlli.DataSource = c.ControlliSelect();
        ddlControlli.DataValueField = "Cod_Controllo";
        ddlControlli.DataTextField = "Tipo_Controllo";
        ddlControlli.DataBind();
    }

    protected void ddlCommesseSelect()
    {
        COMMESSE c = new COMMESSE();
        ddlCommessa.DataSource = c.CommesseSelect();
        ddlCommessa.DataValueField = "Cod_Commessa";
        ddlCommessa.DataTextField = "Descrizione_Commessa";
        ddlCommessa.DataBind();
    }

    protected void RiempiCampi()
    {
        LAVORI l = new LAVORI();
        l.Cod_Lavoro = int.Parse(Request.QueryString["cod"].ToString());
        DataTable dt = l.LavoriCercaSelect();
        ddlCommessa.SelectedValue = dt.Rows[0]["Cod_Commessa"].ToString();
        lblDataReport.Text = Convert.ToDateTime(dt.Rows[0]["Data_Report"]).ToString();
        lblCognome.Text = dt.Rows[0]["Cognome"].ToString();
        lblNome.Text = dt.Rows[0]["Nome"].ToString();
        txtDesLavoro.Text = dt.Rows[0]["Descrizione_Lavoro"].ToString();

        string oreDecimali = l.DecimalToOre(decimal.Parse(dt.Rows[0]["Ore"].ToString()));
        txtOre.Text = oreDecimali;

        txtSpesaPasto.Text = dt.Rows[0]["Spesa_Pasto"].ToString();
        txtSpesaTrasporto.Text = dt.Rows[0]["Spesa_Trasporto"].ToString();
        txtSpesaPedaggi.Text = dt.Rows[0]["Spesa_Pedaggi"].ToString();
        txtSpesaPernottamento.Text = dt.Rows[0]["Spesa_Pernottamento"].ToString();
        txtSpesaExtra.Text = dt.Rows[0]["Spesa_Extra"].ToString();
        txtDesSpesaExtra.Text = dt.Rows[0]["Descrizione_Spesa_Extra"].ToString();
    }

    protected void btnConferma_Click(object sender, EventArgs e)
    {
        LAVORI l = new LAVORI();
        l.Cod_Lavoro = int.Parse(Request.QueryString["cod"].ToString());
        l.Cod_Commessa = int.Parse(ddlCommessa.SelectedValue);
        l.Descrizione_Lavoro = txtDesLavoro.Text;
        l.Ore = l.ConvertiOre(txtOre.Text);

        if (txtSpesaPasto.Text == "")
            l.Spesa_Pasto = 0;
        else
        l.Spesa_Pasto = decimal.Parse(txtSpesaPasto.Text);

        if (txtSpesaTrasporto.Text == "")
            l.Spesa_Trasporto = 0;
        else
            l.Spesa_Trasporto = decimal.Parse(txtSpesaTrasporto.Text);

        if (txtSpesaPedaggi.Text == "")
            l.Spesa_Pedaggi = 0;
        else
            l.Spesa_Pedaggi = decimal.Parse(txtSpesaPedaggi.Text);

        if (txtSpesaPernottamento.Text == "")
            l.Spesa_Pernottamento = 0;
        else
            l.Spesa_Pernottamento = decimal.Parse(txtSpesaPernottamento.Text);

        if (txtSpesaExtra.Text == "")
            l.Spesa_Extra = 0;
        else
            l.Spesa_Extra = decimal.Parse(txtSpesaExtra.Text);

        l.Descrizione_Spesa_Extra = txtDesSpesaExtra.Text;

        l.LavoriMod();





        //r.Cod_Report = int.Parse(Request.QueryString["cod"].ToString());
        ////solo per amministrazione
        //r.Cod_Controllo = int.Parse(ddlControlli.SelectedValue);

        //r.ReportMod();
    }
}