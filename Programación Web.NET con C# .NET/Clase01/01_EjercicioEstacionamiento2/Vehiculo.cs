using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ENCAPSULAMIENTO
/// </summary>
///
namespace _03_EjercicioEstacionamiento
{
    abstract class Vehiculo //con abstract no puedo crear una instancia de esta clase
    {
        /* ///////////////////////PROPERTY FULL IMPLEMENTADA////////////////////////////

        // private char[] patente;
        private string patente;
        public Vehiculo(string patente) //al string lo puedo tomar como un array de caracteres
        {
            Patente = patente;
        }
        //Utilizo setter y getter , con esto evito tener varias operaciones en una misma clase
        //get obtiene el valor del estado de "patente"
        //set le asigna un nuevo valor al estado de "patente"

        //Este metodo no lleva parametros  (forma 1° de como estructurar el get y set)
        /*public string Patente
        {
            get
            {
                return patente; //el get si o si debe retornar algo
            }
            set
            {
                patente = value; // value hace referencia al valor que se le asigno desde afuera y este le cambia el estado de "patente" (seria como obtener y setear con el parametros de una operacion)
            }
        }*/


        
        ////////////////////////////////////PROPERTY  AUTO IMPLEMENTADA/////////////////////////////////////////
        //Este metodo no lleva parametros  (forma 2° de como estructurar el get y set) - property auto-implementada 
        public string Patente { get; set;}

        public string MetodoEjemeplo()
        {
            return "Esto es un vehiculo!";
        }
        public Vehiculo() //al string lo puedo tomar como un array de caracteres
        {

        }

    }
}
