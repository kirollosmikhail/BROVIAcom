// Funzione per calcolare la larghezza della finestra del browser
function getWindowWidth() {
    return window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
}

// Funzione per verificare se la larghezza della finestra è inferiore alla larghezza di .table-container
function checkWidth() {
    if (document.querySelector('.table-container') != null) {
        var tableContainer = document.querySelector('.table-container');
        var table = document.querySelector('.table-container').querySelector('table');
        var containerWidth = document.querySelector('.container');

        if (containerWidth.offsetWidth > table.offsetWidth) {
            // La larghezza della finestra è inferiore alla larghezza di .table-container
            // Rimuovi la classe overflow-auto se presente
            tableContainer.classList.remove('overflow-auto');
            console.log("Ciao, mondo!")
        } else {
            // La larghezza della finestra è maggiore o uguale alla larghezza di .table-container
            // Aggiungi la classe overflow-auto
            tableContainer.classList.add('overflow-auto');
        }
    }
    var width = window.screen.width;
    if (width <= 600) {
        // Se la larghezza della finestra è inferiore o uguale a 600px, imposta lo zoom a 1.9
        document.body.style.zoom = 1.9;
    }
    else if (width <= 990) {
        // Se la larghezza della finestra è inferiore o uguale a 990px, imposta lo zoom a 1.4
        document.body.style.zoom = 1.4;
    }
    else {
        // Altrimenti, lascia lo zoom predefinito
        document.body.style.zoom = 1;
    }
}

function checkWidth2() {
    if (document.querySelector('.table-container') != null) {
        var tableContainer = document.querySelector('.table-container');
        var table = document.querySelector('.table-container').querySelector('table');
        var containerWidth = document.querySelector('.container');

        if (containerWidth.offsetWidth > table.offsetWidth) {
            // La larghezza della finestra è inferiore alla larghezza di .table-container
            // Rimuovi la classe overflow-auto se presente
            tableContainer.classList.remove('overflow-auto');
            console.log("Ciao, mondo!")
        } else {
            // La larghezza della finestra è maggiore o uguale alla larghezza di .table-container
            // Aggiungi la classe overflow-auto
            tableContainer.classList.add('overflow-auto');
        }
    }
}
// Esegui la funzione all'avvio della pagina e ogni volta che la finestra viene ridimensionata
window.onload = checkWidth;

window.onresize = checkWidth2;
