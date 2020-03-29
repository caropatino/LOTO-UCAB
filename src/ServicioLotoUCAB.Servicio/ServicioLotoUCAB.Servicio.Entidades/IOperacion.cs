using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class IOperacion
    {
        int status;
        string mensaje;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }
}
