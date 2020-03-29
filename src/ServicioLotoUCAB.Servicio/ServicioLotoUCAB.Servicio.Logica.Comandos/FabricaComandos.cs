using ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos
{
    public class FabricaComandos
    {
        public static ComandoGetData FabricarComandoGetData()
        {
            return new ComandoGetData();
        }

        public static ComandoConsultarUsuarios FabricarComandoConsultarUsuarios()
        {
            return new ComandoConsultarUsuarios();
        }

        public static ComandoConsultarUsuarioPorID FabricarComandoConsultarUsuarioPorID()
        {
            return new ComandoConsultarUsuarioPorID();
        }

        public static ComandoEliminarUsuario FabricarComandoEliminarUsuario()
        {
            return new ComandoEliminarUsuario();
        }

        public static ComandoAgregarUsuario FabricarComandoAgregarUsuarios()
        {
            return new ComandoAgregarUsuario();
        }

        public static ComandoCrearUsuario FabricarComandoCrearUsuarios()
        {
            return new ComandoCrearUsuario();
        }

        public static ComandoModificarUsuario FabricarComandoModificarUsuario()
        {
            return new ComandoModificarUsuario();
        }

        public static ComandoUsuarioJuego FabricarComandoUsuarioJuego()
        {
            return new ComandoUsuarioJuego();
        }

        public static ComandoUsuarioJuegoConjunto FabricarComandoUJC()
        {
            return new ComandoUsuarioJuegoConjunto();
        }
        public static ComandoUsuarioJuegoConjuntoItem FabricarComandoUJCI()
        {
            return new ComandoUsuarioJuegoConjuntoItem();
        }
    }
}
