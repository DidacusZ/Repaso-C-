using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Recuperacio_C
{
    internal class Servicio
    {
        //SERVICIOS: conjunto de metodos que hacen una funcionalidad determinada
        //En cada clase los metodos se refiereen a lo mismo
        //ej: alumnos--   clase:matricula-alumno...   alumno:añadir,eliminar-alumno...

        public string Pedir(string mensaje)
        {
            Console.Write("{0}: ",mensaje);
            return Console.ReadLine();
        }

        public void Mostrar()
        {

        }

    }
}
