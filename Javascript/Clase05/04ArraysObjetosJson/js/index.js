var alumnos = [];

var elementoBoton = document.getElementById("btnAgregar");
elementoBoton.onclick = function () {
    var elementoNombre = document.getElementById("txtNombre");
    var nombre = elementoNombre.value;
    var elementoApellido = document.getElementById("txtApellido");
    var apellido = elementoApellido.value;
    var elementoEdad = document.getElementById("txtEdad");
    var edad = parseInt(elementoEdad.value);
    //alumnos.push([nombre,apellido,edad]);

    //objeto
    var nuevaPersona = {
        Nombre : nombre,
        Apellido : apellido,
        Edad : edad
    }
    alumnos.push(nuevaPersona);
}