using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class COMMESSE
{
    public int Cod_Commessa;
    public string Descrizione_Commessa;
    public DateTime? Data_Inizio;
    public DateTime? Data_Fine;
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
    public DataTable CommesseDDL()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CommesseDDL";

        c.EseguiSelect();
        return c.dt;
    }
    public DataTable CommesseCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CommesseCerca";
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);
        if (Ragione_Sociale == "")
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", DBNull.Value);
        else
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);


        c.EseguiSelect();
        return c.dt;
    }

    public DataTable CommesseRiempiMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CommesseRiempiMod";
        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);

        c.EseguiSelect();
        return c.dt;
    }
    public void CommesseMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "CommesseMod";
        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
        c.cmd.Parameters.AddWithValue("@Descrizione_Commessa", Descrizione_Commessa);
        c.cmd.Parameters.AddWithValue("@Data_Inizio", Data_Inizio);
        if (Data_Fine != null)
        {
            c.cmd.Parameters.AddWithValue("@Data_Fine", Data_Fine);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Data_Fine", DBNull.Value);
        }

        if (Anticipo != 0)
        {
            c.cmd.Parameters.AddWithValue("@Anticipo", Anticipo);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Anticipo", DBNull.Value);
        } 

        if (Importo_ACorpo != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_ACorpo", Importo_ACorpo);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_ACorpo", DBNull.Value);
        }   
        
        if (Importo_CanoneMensile != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", Importo_CanoneMensile);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", DBNull.Value);
        } 
        
        if (Importo_Orario != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_Orario", Importo_Orario);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_Orario", DBNull.Value);
        }

        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);
        c.cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);

        c.EseguiComando();
    }

    public void CommesseIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "CommesseIns";
        
        c.cmd.Parameters.AddWithValue("@Descrizione_Commessa", Descrizione_Commessa);
        c.cmd.Parameters.AddWithValue("@Data_Inizio", Data_Inizio);
        if (Data_Fine != null)
        {
            c.cmd.Parameters.AddWithValue("@Data_Fine", Data_Fine);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Data_Fine", DBNull.Value);
        }

        if (Anticipo != 0)
        {
            c.cmd.Parameters.AddWithValue("@Anticipo", Anticipo);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Anticipo", DBNull.Value);
        }

        if (Importo_ACorpo != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_ACorpo", Importo_ACorpo);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_ACorpo", DBNull.Value);
        }

        if (Importo_CanoneMensile != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", Importo_CanoneMensile);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", DBNull.Value);
        }

        if (Importo_Orario != 0)
        {
            c.cmd.Parameters.AddWithValue("@Importo_Orario", Importo_Orario);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Importo_Orario", DBNull.Value);
        }

        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);
        c.cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);

        c.EseguiComando();
    }
}