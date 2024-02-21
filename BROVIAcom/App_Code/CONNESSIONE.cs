using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class CONNESSIONE
{
    static public string Cod_Session_Utente;
    public string Parametri;
    public SqlConnection conn = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter DA = new SqlDataAdapter();
    public DataTable dt = new DataTable();
    public string querydiselezione;
    public string querydicomando;

    public CONNESSIONE()
    {
        conn.ConnectionString = conn.ConnectionString = @"Data Source=.;Initial Catalog=BROVIACOM;Integrated Security=true;";
        cmd.Connection = conn;
    }

    public void EseguiSelect()
    {
        EVENTI ev = new EVENTI();
        if (Cod_Session_Utente == null || Cod_Session_Utente == "")
        {
            Cod_Session_Utente = "0";
        }
        try
        {
            cmd.CommandText = querydiselezione;
            cmd.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand = cmd;
            DA.Fill(dt);
        }
        catch (Exception ex)
        {
            ev.Data_Azione = DateTime.Now;
            ev.Azione = querydiselezione;
            ev.Parametri = ex.Message;
            ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
            ev.EventiIns();
        }
        finally
        {
            ev.Data_Azione = DateTime.Now;
            ev.Azione = querydiselezione;
            ev.Parametri = Parametri;
            ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
            ev.EventiIns();
        }
    }

    public void EseguiComando()
    {
        EVENTI ev = new EVENTI();
        if (Cod_Session_Utente == null || Cod_Session_Utente == "")
        {
            Cod_Session_Utente = "0";
        }
        try
        {
            cmd.CommandText = querydicomando;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {
            ev.Data_Azione = DateTime.Now;
            ev.Azione = querydicomando;
            ev.Parametri = ex.Message;
            ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
            ev.EventiIns();

        }
        finally
        {
            ev.Data_Azione = DateTime.Now;
            ev.Azione = querydicomando;
            ev.Parametri = Parametri;
            ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
            ev.EventiIns();
        }
    }
}