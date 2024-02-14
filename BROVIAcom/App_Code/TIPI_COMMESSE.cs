using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class TIPI_COMMESSE
{
    public int Cod_Tipo_Commessa;
    public string Nome_Commessa;

    public TIPI_COMMESSE()
    {
        
    }
    public DataTable TipiCommesseSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "TipiCommesseSelect";
        c.EseguiSelect();
        return c.dt;
    }
}