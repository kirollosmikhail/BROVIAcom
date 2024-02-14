using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class EVENTI
{
    public int Cod_Log;
    public DateTime Data_Azione;
    public string Azione;
    public string Parametri;
    public int Cod_Dipendente;

    public EVENTI()
    {
        
    }
    public void AccessiIns()
    {
        CONNESSIONE c = new CONNESSIONE();

        c.querydicomando = "AccessiIns";
        c.cmd.Parameters.AddWithValue("@Data_Azione", Data_Azione);
        c.cmd.Parameters.AddWithValue("@Azione", Azione);
        c.cmd.Parameters.AddWithValue("@Parametri", Parametri);
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);
        c.EseguiComando();

    }


    public DataTable EventiSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "EventiSelect";
        c.EseguiSelect();

        return c.dt;

    }
    public void EventiElimina()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "EventiElimina";
        c.EseguiComando();
    }

}