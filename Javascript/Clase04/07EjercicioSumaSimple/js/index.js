function sumar() {
    var inpUno = document.getElementById("numeroUno");
    var inpDos = document.getElementById("numeroDos");
    var spanRes = document.getElementById("resultado");
    inpUno = parseFloat(inpUno.value);
    inpDos = parseFloat(inpDos.value);

    var res = inpUno + inpDos;
    spanRes.innerText = res;
}
