using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class COMMESSE
{
    public int Cod_Commessa;
    public string Descrizione_Commessa;
    public DateTime Data_Inizio;
    public DateTime Data_Fine;
    public decimal Anticipo;
    public decimal Importo_ACorpo;
    public decimal Importo_CanoneMensile;
    public decimal Importo_Orario;
    public int Cod_Tipo_Commessa;
    public int Cod_Cliente;
    public string Ragione_Sociale;
    public COMMESSE()
    {
        
    }
    
    public DataTable CommesseSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CommesseSelect";

        c.EseguiSelect();
        return c.dt;
    }
    public DataTable CommesseCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CommesseCerca";
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);
        if(Ragione_Sociale=="")
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", DBNull.Value);
        else
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);


        c.EseguiSelect();
        return c.dt;
    }
}