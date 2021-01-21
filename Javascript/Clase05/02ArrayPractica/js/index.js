var elementoBoton = document.getElementById("btnAgregar");
var personas = [];
elementoBoton.onclick = function(){
    var elementoNombre = document.getElementById("txtNombre");
    var nombre = elementoNombre.value;
    personas.push(nombre);
    elementoNombre.value="";
    console.log(personas);
    LlenarLista();
}
function LlenarLista() {
    var elementos = ""
    for (var i = 0; i < personas.length;i++) { 
        elementos+="<li>"+personas[i]+"</li>";
    }
    var elementosPersonas = document.getElementById("lstPersonas");
    elementosPersonas.innerHTML = elementos;
}