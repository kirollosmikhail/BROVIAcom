using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class CONNESSIONE
{
    static public string Cod_Session_Utente;
    public string Parametri = "";
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
        if (querydiselezione != null)
        {
            EVENTI ev = new EVENTI();
            try
            {
                cmd.CommandText = querydiselezione;
                cmd.CommandType = CommandType.StoredProcedure;
                DA.SelectCommand = cmd;
                DA.Fill(dt);
            }
            catch (Exception ex)
            {
                if (querydiselezione != "Login")
                {
                    ev.Data_Azione = DateTime.Now;
                    ev.Azione = querydiselezione;
                    ev.Parametri = ex.Message;
                    ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
                    ev.EventiIns();
                }
            }
            finally
            {
                if (querydiselezione != "Login")
                {
                    ev.Data_Azione = DateTime.Now;
                    ev.Azione = querydiselezione;
                    ev.Parametri = Parametri;
                    ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
                    ev.EventiIns();
                }
            }
            querydiselezione = null;
        }
    }

    public void EseguiComando()
    {
        if(querydicomando != null)
        {
            EVENTI ev = new EVENTI();
            if (querydicomando != "EventiIns")
            {

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
                    if (!(querydicomando == "AccessiIns" || querydicomando == "CambiaPassword"))
                    {
                        ev.Data_Azione = DateTime.Now;
                        ev.Azione = querydicomando;
                        ev.Parametri = ex.Message;
                        ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
                        ev.EventiIns();
                    }
                }
                finally
                {
                    if (!(querydicomando == "AccessiIns" || querydicomando == "CambiaPassword"))
                    {
                        ev.Data_Azione = DateTime.Now;
                        ev.Azione = querydicomando;
                        ev.Parametri = Parametri;
                        ev.Cod_Dipendente = int.Parse(Cod_Session_Utente);
                        ev.EventiIns();
                    }
                }
            }
            else
            {
                cmd.CommandText = querydicomando;
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            querydicomando = null;
        }
    }
}