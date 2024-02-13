using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DIPENDENTI
/// </summary>
public class DIPENDENTI
{
    public int Cod_Dipendente;
    public string Cognome;
    public string Nome;
    public string USR;
    public string PWD;
    public bool Abilitato;
    public string Codice_Fiscale;
    public string P_IVA;
    public DateTime Data_Assunzione;
    public DateTime Data_Licenziamento;
    public decimal Salario;
    public string Telefono;
    public string Indirizzo;
    public string Citta;
    public string CAP;
    public int Cod_Tipo_Dipendente;
    public DIPENDENTI()
    {
        
    }

    public DataTable Login()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "Login";
        c.cmd.Parameters.AddWithValue("@USR", USR);
        c.cmd.Parameters.AddWithValue("@PWD", PWD);

        c.EseguiSelect();
        return c.dt;
    }

    public void CambiaPassword()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "CambiaPassword";
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);
        c.cmd.Parameters.AddWithValue("@PWD", PWD);

        c.EseguiComando();
    }

    public DataTable DipendentiSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "DipendentiSelect";

        c.EseguiSelect();
        return c.dt;
    }
}