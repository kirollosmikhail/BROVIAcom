using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;


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
    public DateTime? Data_Assunzione;
    public DateTime? Data_Licenziamento;
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
    public DataTable DipendentiCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "DipendentiCerca";
        c.cmd.Parameters.AddWithValue("@Cognome", Cognome);
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);

        c.EseguiSelect();
        return c.dt;
    }
    public void DipendentiMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Cod_Dipendente", Cod_Dipendente);
        c.cmd.Parameters.AddWithValue("@Cognome", Cognome);
        c.cmd.Parameters.AddWithValue("@Nome", Nome);
        c.cmd.Parameters.AddWithValue("@USR", USR);
        c.cmd.Parameters.AddWithValue("@Abilitato", Abilitato);
        c.cmd.Parameters.AddWithValue("@Codice_Fiscale", Codice_Fiscale);
        c.cmd.Parameters.AddWithValue("@P_IVA", P_IVA);
        c.cmd.Parameters.AddWithValue("@Data_Assunzione", Data_Assunzione);

        if (Data_Licenziamento != null)
        {
            c.cmd.Parameters.AddWithValue("@Data_Licenziamento", Data_Licenziamento);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Data_Licenziamento", DBNull.Value);
        }
       

        c.cmd.Parameters.AddWithValue("@Salario", Salario);
        c.cmd.Parameters.AddWithValue("@Telefono", Telefono);
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@CAP", CAP);
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Dipendente", Cod_Tipo_Dipendente);

        c.querydicomando = "DipendentiMod";
        c.EseguiComando();
    }
    public void DipendentiIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Cognome", Cognome);
        c.cmd.Parameters.AddWithValue("@Nome", Nome);
        c.cmd.Parameters.AddWithValue("@USR", USR);
        c.cmd.Parameters.AddWithValue("@Abilitato", true);
        c.cmd.Parameters.AddWithValue("@Codice_Fiscale", Codice_Fiscale);
        c.cmd.Parameters.AddWithValue("@P_IVA", P_IVA);
        c.cmd.Parameters.AddWithValue("@Data_Assunzione", Data_Assunzione);
        c.cmd.Parameters.AddWithValue("@PWD", "benvenuto");

        if (Data_Licenziamento != null)
        {
            c.cmd.Parameters.AddWithValue("@Data_Licenziamento", Data_Licenziamento);
        }
        else
        {
            c.cmd.Parameters.AddWithValue("@Data_Licenziamento", DBNull.Value);
        }


        c.cmd.Parameters.AddWithValue("@Salario", Salario);
        c.cmd.Parameters.AddWithValue("@Telefono", Telefono);
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@CAP", CAP);
        c.cmd.Parameters.AddWithValue("@Cod_Tipo_Dipendente", Cod_Tipo_Dipendente);

        c.querydicomando = "DipendentiIns";
        c.EseguiComando();
    }


}