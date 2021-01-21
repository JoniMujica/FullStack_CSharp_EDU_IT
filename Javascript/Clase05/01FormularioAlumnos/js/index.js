var agregarPersona = document.getElementById("btnAgregar");

function AgregarPersona() {
    var elementoTXTnombre = document.getElementById("txtNombre");
    var nombre = elementoTXTnombre.value;
    var elementoTXTapellido = document.getElementById("txtApellido");
    var apellido = elementoTXTapellido.value;
    var elementoTXTedad = document.getElementById("txtEdad");
    var edad = elementoTXTedad.value;

    var fila = "<tr><td>";
    fila += apellido;
    fila += "</td><td>";
    fila += nombre;
    fila += "</td><td>"
    fila += edad;
    fila += "</td></tr>"
    var elementoCuerpo = document.getElementById("cuerpoTablaPersonas");
    elementoCuerpo.innerHTML += fila;

    elementoTXTapellido.value = "";
    elementoTXTnombre.value = "";
    elementoTXTedad.value = "";
}

agregarPersona.onclick = AgregarPersona;