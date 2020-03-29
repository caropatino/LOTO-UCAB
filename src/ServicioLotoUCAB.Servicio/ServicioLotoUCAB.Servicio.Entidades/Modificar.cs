using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class Modificar: IOperacion
    {
        int afectados;
        public int Afectados
        {
            get { return afectados; }
            set { afectados = value; }
        }
    }
}
