using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA_S3.Entities;
using TA_S3.Repositories;

namespace TA_S3.Services
{
    internal class MuebleService
    {
        //Llamar al repositorio
        private MuebleRepository muebleRepository = new MuebleRepository();

        //Registrar	
        public bool Registrar(Mueble mueble)
        {
            if (muebleRepository.Existe(mueble.Codigo.ToString()))
            {
                return false;
            }
            else
            {
                muebleRepository.Registrar(mueble);
                return true;
            }
        }

        //Listar todo
        public List<Mueble> ListarTodo()
        {
            return muebleRepository.ListarTodo();

        }

        //eliminar segun su codigo
        public void Eliminar(String codigo)
        {
            muebleRepository.Eliminar(codigo);
        }

        //comentariod PRUEBA

        //radio

        //Fundamentos



    }
}
