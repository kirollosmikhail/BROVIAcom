using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class FATTURE
{
    public int Cod_Fattura;
    public string Numero_Fattura;
    public DateTime Data_Fattura;
    public string Descrizione;
    public decimal Imponibile;
    public decimal IVA;
    public decimal Totale;
    public int Cod_Commessa;

    public FATTURE()
    {
        
    }
}