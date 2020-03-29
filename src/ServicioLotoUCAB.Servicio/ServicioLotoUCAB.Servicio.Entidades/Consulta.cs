using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class Consulta:IOperacion
    {
        ListaUsuario listado;

        public ListaUsuario Listado
        {
            get { return listado; }
            set { listado = value; }
        }
    }
}
