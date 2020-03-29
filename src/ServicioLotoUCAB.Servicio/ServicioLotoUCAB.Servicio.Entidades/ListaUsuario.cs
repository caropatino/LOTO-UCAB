using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class ListaUsuario
    {
        List<Usuario> lista;

        public ListaUsuario()
        {
            lista = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            this.lista.Add(usuario);
        }

        public List<Usuario> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}
