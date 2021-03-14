using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Documento
    {
        public string tipoDeDocumento; 
        public string numeroDeDocumento; //referido A
        //Constructor
        public Documento()
        {

        }
        public Documento(string tipo,string numeroDeDocumento)
        {
            tipoDeDocumento = tipo;
            //referencia A
            this.numeroDeDocumento = numeroDeDocumento; //con 'this' me estoy refiriendo a la variable "numeroDeDocumento" del objeto en si en el que estoy trabajando, y sin el this, me refiero al parametro
        }
    }
}
