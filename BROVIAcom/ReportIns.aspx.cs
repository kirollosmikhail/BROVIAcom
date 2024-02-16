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
            SessionDipendenti();
            ddlCommesseSelect();
        }
    }

    protected void SessionDipendenti()
    {
        DIPENDENTI d = new DIPENDENTI();
        d.Cod_Dipendente = 6;//int.Parse(Session["Cod_Dipendente"].ToString());
        DataTable dt = d.SessionSelectDipendenti();
        lblCognome.Text = dt.Rows[0]["Cognome"].ToString();
        lblNome.Text = dt.Rows[0]["Nome"].ToString();
    }

    protected void ddlCommesseSelect()
    {
        COMMESSE c = new COMMESSE();
        ddlCommessa.DataSource = c.CommesseSelect();
        ddlCommessa.DataValueField = "Cod_Commessa";
        ddlCommessa.DataTextField = "Descrizione_Commessa";
        ddlCommessa.DataBind();
    }

    protected int ReportVerifica()
    {
        REPORT r = new REPORT();
        r.Data_Report = DateTime.Parse(txtDataReport.Text);
        r.Cod_Dipendente = 6;//int.Parse(Session["Cod_Dipendente"].ToString());

        DataTable dt = r.ReportVerifica();
        if (dt.Rows.Count == 0)
        {
            r.ReportIns();
            dt = r.ReportVerifica();
            return int.Parse(dt.Rows[0]["Cod_Report"].ToString());
        }
        return int.Parse(dt.Rows[0]["Cod_Report"].ToString());
    }

    protected void btnConferma_Click(object sender, EventArgs e)
    {

        LAVORI l = new LAVORI();
        l.Cod_Report = ReportVerifica();
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
        l.LavoriIns();
    }
}