using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class REPORT
{
    public int Cod_Report;
    public DateTime Data_Report;
    public int Cod_Dipendente;
    public int Cod_Controllo;

    public REPORT()
    {

    }

    public DataTable ReportSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ReportSelect";

        c.EseguiSelect();
        return c.dt;
    }

    public void ReportMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "ReportMod";
        c.cmd.Parameters.AddWithValue("@Cod_Controllo", Cod_Controllo);
        c.cmd.Parameters.AddWithValue("@Cod_Report", Cod_Report);

        c.Parametri = "Cod_Controllo = " + Cod_Controllo + " Cod_Report = " + Cod_Report;
        c.EseguiComando();
    }

    public DataTable ReportDipendentiSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ReportDipendentiSelect";
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);

        c.EseguiSelect();
        return c.dt;
    }

    public void ReportIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "ReportIns";
        c.cmd.Parameters.AddWithValue("@Data_Report", Data_Report);
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);

        c.Parametri = "Data_Report = " + Data_Report + " Cod_Dipendente = " + Cod_Dipendente;
        c.EseguiComando();
    }

    public DataTable ReportVerifica()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ReportVerifica";
        c.cmd.Parameters.AddWithValue("@Data_Report", Data_Report);
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);

        c.Parametri = "Data_Report = " + Data_Report + " Cod_Dipendente = " + Cod_Dipendente;
        c.EseguiSelect();
        return c.dt;
    }

    public DataTable ReportApprovati()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ReportApprovati";

        c.EseguiSelect();
        return c.dt;
    }

    public DataTable ReportCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "LavoriCerca";
        c.cmd.Parameters.AddWithValue("@Data_Report", Data_Report);

        c.Parametri = "Data_Report = " + Data_Report;
        c.EseguiSelect();
        return c.dt;
    }
}