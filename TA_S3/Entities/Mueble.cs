using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S3.Entities
{
    internal class Mueble
    {
        //Definición de Constructor y Atributos (Oliver)
        public Mueble() { }
        
        public int Codigo { get; set; }

        public String Nombre { get; set; }

        public int Stock { get; set; }

        public double Precio { get; set; }
    }
}
