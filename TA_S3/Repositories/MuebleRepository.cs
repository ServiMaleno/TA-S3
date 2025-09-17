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

        //Listar todo (Darwin)
        public List<Mueble> ListarTodo()
        {
            return muebles;
        }

        //Registrar (Percy)
        public void Registrar(Mueble mueble)
        {
            muebles.Add(mueble);
        }
        
       

        //Eliminar un mueble segun su codigo (Darwin)
        public void Eliminar(String codigo)
        {
            muebles.RemoveAll(mueble => mueble.Codigo.Equals(codigo));
        }
    
    
    }
    
}
