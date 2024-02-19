// Funzione per calcolare la larghezza della finestra del browser
    function getWindowWidth() {
        return window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
    }

    // Funzione per verificare se la larghezza della finestra è inferiore alla larghezza di .table-container
    function checkWidth() {
        var tableContainer = document.querySelector('.table-container');
    var windowWidth = getWindowWidth();

    if (windowWidth < tableContainer.offsetWidth) {
        // La larghezza della finestra è inferiore alla larghezza di .table-container
        // Rimuovi la classe overflow-auto se presente
        tableContainer.classList.remove('overflow-auto');
        } else {
        // La larghezza della finestra è maggiore o uguale alla larghezza di .table-container
        // Aggiungi la classe overflow-auto
        tableContainer.classList.add('overflow-auto');
        }
    }

    // Esegui la funzione all'avvio della pagina e ogni volta che la finestra viene ridimensionata
    window.onload = checkWidth;
    window.onresize = checkWidth;