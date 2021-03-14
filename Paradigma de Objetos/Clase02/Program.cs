using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = "Andres";
            alumno.apellido = "Villa";

            /*
            alumno.documento.tipoDeDocumento = "DU";  Esto me tira error ya que Documento no es una instancia objeto
            alumno.documento.numeroDeDocumento = "21312312";*/

            //se soluciona asi , creo el objeto "Documento" y se lo asigno a alumno.documento
            Documento documento = new Documento("DU","1321321"); //ahora como cree un costructor, elimina el constructor generico por defecto y reemplaza al que yo cree, obligandome a agregar elementos de los parametros creados por mi cosntructor
            /*documento.tipoDeDocumento = "DU";
            documento.numeroDeDocumento = "213412321";
            alumno.documento = documento;*/
            Documento docSinParam = new Documento();
            Console.ReadKey();
        }
    }
}
