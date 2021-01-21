$("#btnSaludar").click(function () { 
    alert("Hola " + $("#txtNombre").val());
});
$("#unUso").click(funcionaUnaSolaVez);

function funcionaUnaSolaVez(){
    alert("Funciona una sola vez!!");
    $("#unUso").off("click",funcionaUnaSolaVez);
}