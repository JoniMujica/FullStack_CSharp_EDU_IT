var cantAlumnos = prompt("¿Cuantos alumnos desea agregar?");
cantAlumnos = parseInt(cantAlumnos);
var notasXalumnos = prompt("¿Cuantas notas por alumnos desea agregar?");
notasXalumnos = parseInt(notasXalumnos);

document.write("<table><thead><tr><th>Nombre</th><th>Apellido</th>");

for (var i = 0; i < notasXalumnos;  i++) {
    document.write("<th>Nota" + (i+1) + "</th>");
}
document.write("<th>Promedio</th></tr></thead><tbody>");

for (var i = 0; i < cantAlumnos; i++) {
    var nombre = prompt("Nombre del Alumno");
    var apellido = prompt("Apellido del Alumno");
    document.write("<tr><td>" + nombre + "</td><td>" + apellido) + "</td>";
    var total = 0;
    for (var k = 0; k < notasXalumnos; k++) {
        total = total + crearAlumno(k);
    }
   // var p = promedio(total,notasXalumnos);
    document.write("<td>" + promedio(total,notasXalumnos) + "</td>")
}
document.write("</td></tbody></table>")

function crearAlumno(cAlumno){
    var t = 0;
    var nota = prompt("Nota:" + (cAlumno+1)); 
    nota = parseInt(nota);
    document.write("<td>" + nota + "</td>");
    t = t + nota;
    return t;
}
function promedio(total,div){
    var prom = total/div;
    return prom;
}