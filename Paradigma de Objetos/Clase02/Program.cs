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
            Documento documento = new Documento();
            documento.tipoDeDocumento = "DU";
            documento.numeroDeDocumento = "213412321";
            alumno.documento = documento;
            Console.ReadKey();
        }
    }
}
