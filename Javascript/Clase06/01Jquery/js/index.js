$('p').html("<strong>adsada</strong>");

$("span").html("<b>asdasd</b>");

// con JS solo
var elementos = document.getElementsByTagName("div");
for (var i = 0; i < elementos.length; i++) {
    var unElemento = elementos[i];
    unElemento.innerHTML = "<b>esto esta hecho con JavaScript</b>" ;   
}

$("div").html("<b>Es mas facil con Jquery</b>");
$(".distingo").html("<b>Elemento Div distinto con class JQuery!!");
//leer elementos jquery
alert($("p").text())

$("#unElemento").val("Pongo el valor al Input");