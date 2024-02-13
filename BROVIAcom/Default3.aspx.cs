using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Chiamata a un metodo per popolare il GridView con dati di esempio
            PopolaGridView();
        }
    }

    // Metodo per popolare il GridView con dati di esempio
    private void PopolaGridView()
    {
        // Creazione di una lista di oggetti per rappresentare i dati di esempio
        List<Prodotto> prodotti = new List<Prodotto>()
            {
                new Prodotto() { NomeColonna1 = "Prodotto 1", NomeColonna2 = "Descrizione Prodotto 1" },
                new Prodotto() { NomeColonna1 = "Prodotto 2", NomeColonna2 = "Descrizione Prodotto 2" },
                new Prodotto() { NomeColonna1 = "Prodotto 3", NomeColonna2 = "Descrizione Prodotto 3" }
                // Aggiungi altri oggetti Prodotto come necessario
            };

        // Assegna la lista di prodotti come origine dati per il GridView
        GridView1.DataSource = prodotti;
        GridView1.DataBind();
    }

    // Definizione di una classe di esempio per rappresentare un prodotto
    public class Prodotto
    {
        public string NomeColonna1 { get; set; }
        public string NomeColonna2 { get; set; }
        // Aggiungi altre proprietà del prodotto se necessario
    }
}