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
    public void TipiDipendentiIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "TipiDipendentiIns";
        c.cmd.Parameters.AddWithValue("@Tipo_Dipendente", Tipo_Dipendente);
        c.EseguiComando();
    }
    public void TipiDipendentiElimina()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "TipiDipendentiElimina";
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Dipendente", Cod_Tipo_Dipendente);
        c.EseguiComando();
    }
}