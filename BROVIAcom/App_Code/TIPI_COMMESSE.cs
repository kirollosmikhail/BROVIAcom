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
    public void TipiCommesseIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "TipiCommesseIns";
        c.cmd.Parameters.AddWithValue("@Nome_Commessa", Nome_Commessa);

        c.Parametri = "Nome_Commessa = " + Nome_Commessa;
        c.EseguiComando();
    }
    public void TipiCommesseElimina()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "TipiCommesseElimina";
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);

        c.Parametri = "Cod_Tipo_Commessa = " + Cod_Tipo_Commessa;
        c.EseguiComando();
    }

}