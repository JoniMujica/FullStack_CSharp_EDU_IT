var arrayVacio = [];
var arrayConValors = [10,15,"carlos",true,2.25];
var otraNotacion = new Array(10,15,"carlos",true,2.25);

console.log(arrayConValors);
console.log(otraNotacion);

//Largo del array
console.log(otraNotacion.length);
//Obtenemos por indice
console.log(otraNotacion[2]);

console.log(otraNotacion.push("Ultimo"));
console.log(otraNotacion);
otraNotacion.pop();
console.log(otraNotacion);

var sacoPrimer = otraNotacion.shift(); //con shift saco el primer elemento del array
console.log(otraNotacion);
console.log(sacoPrimer);

var extracto = otraNotacion.slice(1,4); //el slice copia una parte del array inidicado en posicion inicial (incluido) y un fin (no incluido)
console.log(extracto);

var matriz = [];
matriz[0] = [1,2];
matriz[1] = [1,5,7];
console.log(matriz);

for (var i = 0; i < matriz.length; i++) {
    for (var j = 0; j < matriz[i].length; j++) {
        console.log(matriz[i][j]);
    }
}