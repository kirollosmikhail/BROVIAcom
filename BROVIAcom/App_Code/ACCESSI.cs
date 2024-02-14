using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Web;
using System.Data;


public class ACCESSI
{
    public int Cod_Accesso;
    public string IP;
    public string USR;
    public string PWD;
    public DateTime Data_Accesso;
    public bool Accesso_Riuscito;

    public ACCESSI()
    {
        
    }
    public void AccessiIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        
        c.querydicomando = "AccessiIns";
        c.cmd.Parameters.AddWithValue("@IP",IP);
        c.cmd.Parameters.AddWithValue("@USR",USR);
        c.cmd.Parameters.AddWithValue("@PWD",PWD);
        c.cmd.Parameters.AddWithValue("@Data_Accesso",Data_Accesso);
        c.cmd.Parameters.AddWithValue("@Accesso_Riuscito",Accesso_Riuscito);
        c.EseguiComando();
        
    }
    public DataTable AccessiSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "AccessiSelect";
        c.EseguiSelect();

        return c.dt;

    }
    public void AccessiElimina()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "AccessiElimina";
        c.EseguiComando();
    }
    




}