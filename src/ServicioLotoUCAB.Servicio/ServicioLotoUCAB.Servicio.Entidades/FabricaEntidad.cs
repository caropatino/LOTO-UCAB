using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Entidades
{
    public class FabricaEntidad
    {
        public static Usuario crearUsuario()
        {
            return new Usuario();
        }

        public static Usuario crearPadre(int id)
        {
            return new Usuario(id);
        }

        public static Dominio crearDominio(int id)
        {
            return new Dominio(id);
        }

        public static Dominio crearDominio()
        {
            return new Dominio();
        }

        public static ListaUsuario crearListaUsuario()
        {
            return new ListaUsuario();
        }

        public static Consulta crearConsulta()
        {
            return new Consulta();
        }

        public static Crear crear()
        {
            return new Crear();
        }
        public static Modificar modificar()
        {
            return new Modificar();
        }
        public static TipoUsuario crearTipoUsuario (int id)
        {
            return new TipoUsuario(id);
        }
        public static TipoUsuario crearTipoUsuario()
        {
            return new TipoUsuario();
        }

        public static Eliminar crearEliminar()
        {
            return new Eliminar();
        }


        public static Juego crearJuego()
        {
            return new Juego();
        }
    }
}
