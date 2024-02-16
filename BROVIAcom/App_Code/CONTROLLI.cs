using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class CONTROLLI
{
    public int Cod_Controllo;
    public string Tipo_Controllo;

    public CONTROLLI()
    {
        
    }

    public DataTable ControlliSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ControlliSelect";

        c.EseguiSelect();
        return c.dt;
    }
}