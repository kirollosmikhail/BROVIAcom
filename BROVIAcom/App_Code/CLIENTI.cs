using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class CLIENTI
{
    public int Cod_Cliente;
    public string Ragione_Sociale;
    public string Codice_Fiscale;
    public string P_IVA;
    public string Persona_Riferimento;
    public string Email;
    public string Indirizzo;
    public string Citta;
    public string CAP;
    public CLIENTI()
    {

    }

    public DataTable ClientiSelect()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ClientiSelect";

        c.EseguiSelect();
        return c.dt;
    }

    public DataTable ClientiCerca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ClientiCerca";

        c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);
        c.cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);

        c.Parametri = "Ragione_Sociale = " + Ragione_Sociale + " Cod_Cliente = " + Cod_Cliente ;
        c.EseguiSelect();
        return c.dt;
    }

    public void ClientiMod()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "ClientiMod";

        c.cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);
        c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);
        c.cmd.Parameters.AddWithValue("@Codice_Fiscale", Codice_Fiscale);
        c.cmd.Parameters.AddWithValue("@P_IVA", P_IVA);
        c.cmd.Parameters.AddWithValue("@Email", Email);
        c.cmd.Parameters.AddWithValue("@Persona_Riferimento", Persona_Riferimento);
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@CAP", CAP);

        c.Parametri = "Cod_Cliente = " + Cod_Cliente + " Ragione_Sociale = " + Ragione_Sociale + " Codice_Fiscale = " + Codice_Fiscale + " P_IVA = " + P_IVA + " Email = " + Email + " Persona_Riferimento = " + Persona_Riferimento + " Indirizzo = " + Indirizzo + " Citta = " + Citta + " CAP = " + CAP;
        c.EseguiComando();
    }

    public void ClientiIns()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicomando = "ClientiIns";

        c.cmd.Parameters.AddWithValue("@Ragione_Sociale", Ragione_Sociale);
        c.cmd.Parameters.AddWithValue("@Codice_Fiscale", Codice_Fiscale);
        c.cmd.Parameters.AddWithValue("@P_IVA", P_IVA);
        c.cmd.Parameters.AddWithValue("@Persona_Riferimento", Persona_Riferimento);
        c.cmd.Parameters.AddWithValue("@Email", Email);
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@CAP", CAP);

        c.Parametri = " Ragione_Sociale = " + Ragione_Sociale + " Codice_Fiscale = " + Codice_Fiscale + " P_IVA = " + P_IVA + " Email = " + Email + " Persona_Riferimento = " + Persona_Riferimento + " Indirizzo = " + Indirizzo + " Citta = " + Citta + " CAP = " + CAP;
        c.EseguiComando();
    }
}