using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class TIPI_DIPENDENTI
{
    public int Cod_Tipo_Dipendente;
    public string Tipo_Dipendente;
    public TIPI_DIPENDENTI()
    {
        
    }
    public DataTable TipiDipendentiSelect()
    {
        CONNESSIONE c  = new CONNESSIONE();
        c.querydiselezione = "TipiDipendentiSelect";
        c.EseguiSelect();
        return c.dt;
    }
}