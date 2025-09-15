using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA_S3.Entities;

namespace TA_S3.Repositories
{
    internal class MuebleRepository
    {
        //Lista de Muebles
        private List<Mueble> muebles = new List<Mueble>();

        //Validar
        public bool Existe(String codigo)
        {
            return muebles.Exists(mueble => mueble.Codigo.Equals(codigo));
        } 
    }
}
