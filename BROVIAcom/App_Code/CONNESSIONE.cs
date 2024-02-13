using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class CONNESSIONE
{
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
        cmd.CommandText = querydiselezione;
        cmd.CommandType = CommandType.StoredProcedure;
        DA.SelectCommand = cmd;
        DA.Fill(dt);
    }

    public void EseguiComando()
    {
        cmd.CommandText = querydicomando;
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
     
    }
    //salveeeeee
    //salve 2
    //salve3
}