var parraf1 = document.getElementById("parrafoUno");
var parraf2 = document.getElementById("parrafoDos");

var aux = parraf1.innerText;
parraf1.innerText = parraf2.innerText;
parraf2.innerText = aux;