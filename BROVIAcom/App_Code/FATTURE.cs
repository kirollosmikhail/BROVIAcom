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
    public int MeseFattura;
    public int AnnoFattura;
    public FATTURE()
    {

    }

    public DataTable RicaviSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "RicaviSelect";

        c.EseguiSelect();
        return c.dt;
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
        if (MeseFattura != 0 && AnnoFattura != 0)
        {
            c.cmd.Parameters.AddWithValue("@Mese", MeseFattura);
            c.cmd.Parameters.AddWithValue("@Anno", AnnoFattura);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Mese", DBNull.Value);
            c.cmd.Parameters.AddWithValue("@Anno", DBNull.Value);
        }

        if (Ragione_Sociale == "")
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", DBNull.Value);
        else
            c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);

        c.Parametri = "Mese = " + MeseFattura + " Anno = " + AnnoFattura + " Ragione_Sociale = " + Ragione_Sociale;
        c.EseguiSelect();
        return c.dt;
    }

    public void FattureIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        COMMESSE co = new COMMESSE();
        co.Cod_Commessa = Cod_Commessa;
        c.querydicomando = "FattureIns";

        c.cmd.Parameters.AddWithValue("@Cod_Commessa", Cod_Commessa);
        c.cmd.Parameters.AddWithValue("@Data_Fattura", Data_Fattura);
        c.cmd.Parameters.AddWithValue("@Imponibile", co.CommesseImponibile());

        c.cmd.Parameters.AddWithValue("@IVA", IVA);
        c.cmd.Parameters.AddWithValue("@Descrizione", Descrizione);

        c.Parametri = "Cod_Commessa = " + Cod_Commessa + " Data_Fattura = " + Data_Fattura + " Imponibile = " + co.CommesseImponibile() + " IVA = " + IVA + " Descrizione = " + Descrizione;
        c.EseguiComando();
    }

}