using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class LAVORI
{
    public int Cod_Lavoro;
    public string Descrizione_Lavoro;
    public decimal Ore;
    public decimal Spesa_Pasto;
    public decimal Spesa_Trasporto;
    public decimal Spesa_Pedaggi;
    public decimal Spesa_Pernottamento;
    public decimal Spesa_Extra;
    public string Descrizione_Spesa_Extra;
    public int Cod_Commessa;
    public int Cod_Report;

    public LAVORI()
    {

    }

    public decimal ConvertiOre(string t)
    {
        string[] totale = t.Split(':');
        int Ore = int.Parse(totale[0]);
        int minuti = int.Parse(totale[1]);
        decimal numeroFinale = Ore + (decimal)minuti / 60;
        return numeroFinale;
    }

    public string DecimalToOre(decimal t)
    {
        int ore = (int)t;
        decimal f = t - ore;
        int minuti = (int)(f * 60);
        string risultato = string.Format("{0:D2}:{1:D2}", ore, minuti);
        return risultato;
    }

    public DataTable LavoriSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "LavoriSelect";

        c.EseguiSelect();
        return c.dt;
    }

    public DataTable LavoriCercaSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "LavoriCercaSelect";
        c.cmd.Parameters.AddWithValue("@Cod_Lavoro", Cod_Lavoro);

        c.Parametri = "Cod_Lavoro = " + Cod_Lavoro;
        c.EseguiSelect();
        return c.dt;
    }

    public void LavoriMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "LavoriMod";
        c.cmd.Parameters.AddWithValue("@Descrizione_Lavoro", Descrizione_Lavoro);
        c.cmd.Parameters.AddWithValue("@Ore", Ore);
        c.cmd.Parameters.AddWithValue("@Spesa_Pasto", Spesa_Pasto);
        c.cmd.Parameters.AddWithValue("@Spesa_Trasporto", Spesa_Trasporto);
        c.cmd.Parameters.AddWithValue("@Spesa_Pedaggi", Spesa_Pedaggi);
        c.cmd.Parameters.AddWithValue("@Spesa_Pernottamento", Spesa_Pernottamento);
        c.cmd.Parameters.AddWithValue("@Spesa_Extra", Spesa_Extra);
        c.cmd.Parameters.AddWithValue("@Descrizione_Spesa_Extra", Descrizione_Spesa_Extra);
        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
        c.cmd.Parameters.AddWithValue("@Cod_Lavoro", Cod_Lavoro);

        c.Parametri = "Descrizione_Lavoro = " + Descrizione_Lavoro + " Ore = " + Ore + " Spesa_Pasto = " + Spesa_Pasto + " Spesa_Trasporto = " + Spesa_Trasporto + " Spesa_Pedaggi = " + Spesa_Pedaggi + " Spesa_Pernottamento = " + Spesa_Pernottamento + " Spesa_Extra = " + Spesa_Extra + " Descrizione_Spesa_Extra = " + Descrizione_Spesa_Extra + " Cod_Commessa = " + Cod_Commessa + " Cod_Lavoro = " + Cod_Lavoro;
        c.EseguiComando();
    }

    public void LavoriIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "LavoriIns";
        c.cmd.Parameters.AddWithValue("@Descrizione_Lavoro", Descrizione_Lavoro);
        c.cmd.Parameters.AddWithValue("@Ore", Ore);
        c.cmd.Parameters.AddWithValue("@Spesa_Pasto", Spesa_Pasto);
        c.cmd.Parameters.AddWithValue("@Spesa_Trasporto", Spesa_Trasporto);
        c.cmd.Parameters.AddWithValue("@Spesa_Pedaggi", Spesa_Pedaggi);
        c.cmd.Parameters.AddWithValue("@Spesa_Pernottamento", Spesa_Pernottamento);
        c.cmd.Parameters.AddWithValue("@Spesa_Extra", Spesa_Extra);
        c.cmd.Parameters.AddWithValue("@Descrizione_Spesa_Extra", Descrizione_Spesa_Extra);
        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
        c.cmd.Parameters.AddWithValue("@Cod_Report", Cod_Report);

        c.Parametri = "Descrizione_Lavoro = " + Descrizione_Lavoro + " Ore = " + Ore + " Spesa_Pasto = " + Spesa_Pasto + " Spesa_Trasporto = " + Spesa_Trasporto + " Spesa_Pedaggi = " + Spesa_Pedaggi + " Spesa_Pernottamento = " + Spesa_Pernottamento + " Spesa_Extra = " + Spesa_Extra + " Descrizione_Spesa_Extra = " + Descrizione_Spesa_Extra + " Cod_Commessa = " + Cod_Commessa + " Cod_Report = " + Cod_Report;
        c.EseguiComando();
    }

    public DataTable DipendentiEmail()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "DipendentiEmail";
        c.cmd.Parameters.AddWithValue("@Cod_Lavoro", Cod_Lavoro);

        c.EseguiSelect();
        return c.dt;
    }
}