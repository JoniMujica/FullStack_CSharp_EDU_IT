using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    /*ESTO HACE VISIBLE O INVISIBLE CUANDO TENEMOS MAS DE 1 PROYECTO
     * 
     * 
     * Visibilidad a nivel Clase:
     * public: Se puede ver desde todos los proyectos (ENSAMBLADO)
     * internal: Se puede ver solo del mismo proyecto
     * private: Solo se puede ver desde la misma clase
     */
    class Alumno
    {
        /*
         * Visibilidad a nivel miembros (Atributos y Metodos) Hay 3 tipos de visibilidad:
         * public: Se puede ver desde cualquier lado (dentro del mismo objeto o fuera del mismo)
         * protected (por defecto): es publico para la clase o sus hijos, y privado para afuera
         * private: solo se puede ver en la misma clase
         * 
         */
        public string nombre; //cambio la visibilidad de protected a public (visible para todos)
        public string apellido;
        public string documento; //lo pongo como string por si llegase a ser pasaporte (que tiene letras)

        //Cursos
        //Asistencia
        //Pagos
        public bool pagosAlDia;

        //Metodo (Operacion)
        string obtenerEstadoAlumno()
        {
            string estado;
            if (pagosAlDia == true)
            {
                estado = "Tiene los pagos al dia";
            }
            else
            {
                estado = "Debe algun pago";
            }
            string resultado = nombre + " " + apellido + " (" + documento + ") " + estado;
            return resultado;
        }

        public void imprimirEstadoAlumno()
        {
            string descripcionEstado = obtenerEstadoAlumno();
            Console.WriteLine(descripcionEstado);
        }

        //Sobre Carga de operaciones
        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre + " " + apellido);
        }
        public void Saludar(string saludo)
        {
            Console.WriteLine(saludo + ", soy " + nombre + " " + apellido);
        }
    }
}
