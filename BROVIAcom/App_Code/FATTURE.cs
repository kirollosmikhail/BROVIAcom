using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class FATTURE
{
    public int Cod_Fattura;
    public string Numero_Fattura;
    public DateTime? Data_Fattura;
    public string Descrizione;
    public decimal Imponibile;
    public decimal IVA;
    public decimal Totale;
    public int Cod_Commessa;
    public string Ragione_Sociale;
    public FATTURE()
    {
        
    }
    public DataTable FattureSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "FattureSelect";

        c.EseguiSelect();
        return c.dt;
    }
    public DataTable FattureCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "FattureCerca";
        if (Data_Fattura != null)
            c.cmd.Parameters.AddWithValue("@Data_Fattura", Data_Fattura);
        else
            c.cmd.Parameters.AddWithValue("@Data_Fattura", DBNull.Value);

        if (Ragione_Sociale == "")
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", DBNull.Value);
        else
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);


        c.EseguiSelect();
        return c.dt;
    }

    //public DataTable CommesseRiempiMod()
    //{
    //    CONNESSIONE c = new CONNESSIONE();
    //    c.querydiselezione = "CommesseRiempiMod";
    //    c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);

    //    c.EseguiSelect();
    //    return c.dt;
    //}
    //public void CommesseMod()
    //{
    //    CONNESSIONE c = new CONNESSIONE();
    //    c.querydicomando = "CommesseMod";
    //    c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
    //    c.cmd.Parameters.AddWithValue("@Descrizione_Commessa", Descrizione_Commessa);
    //    c.cmd.Parameters.AddWithValue("@Data_Inizio", Data_Inizio);
    //    if (Data_Fine != null)
    //    {
    //        c.cmd.Parameters.AddWithValue("@Data_Fine", Data_Fine);
    //    }
    //    else
    //    {
    //        c.cmd.Parameters.AddWithValue("@Data_Fine", DBNull.Value);
    //    }

    //    if (Anticipo != 0)
    //    {
    //        c.cmd.Parameters.AddWithValue("@Anticipo", Anticipo);
    //    }
    //    else
    //    {
    //        c.cmd.Parameters.AddWithValue("@Anticipo", DBNull.Value);
    //    }

    //    if (Importo_ACorpo != 0)
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_ACorpo", Importo_ACorpo);
    //    }
    //    else
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_ACorpo", DBNull.Value);
    //    }

    //    if (Importo_CanoneMensile != 0)
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", Importo_CanoneMensile);
    //    }
    //    else
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_CanoneMensile", DBNull.Value);
    //    }

    //    if (Importo_Orario != 0)
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_Orario", Importo_Orario);
    //    }
    //    else
    //    {
    //        c.cmd.Parameters.AddWithValue("@Importo_Orario", DBNull.Value);
    //    }

    //    c.cmd.Parameters.AddWithValue("@Cod_Tipo_Commessa", Cod_Tipo_Commessa);
    //    c.cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);

    //    c.EseguiComando();
    //}

    public void FattureIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "FattureIns";

        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
        c.cmd.Parameters.AddWithValue("@Data_Fattura", Data_Fattura);
        c.cmd.Parameters.AddWithValue("@Imponibile", Imponibile);
        c.cmd.Parameters.AddWithValue("@IVA", IVA);
        c.cmd.Parameters.AddWithValue("@Descrizione", Descrizione);

        c.EseguiComando();
    }
}