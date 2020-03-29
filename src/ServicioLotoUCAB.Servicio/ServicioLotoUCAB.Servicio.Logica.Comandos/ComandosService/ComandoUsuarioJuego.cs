using ServicioLotoUCAB.Servicio.AccesoDatos;
using ServicioLotoUCAB.Servicio.AccesoDatos.Dao;
using ServicioLotoUCAB.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService
{
    public class ComandoUsuarioJuego
    {
        Crear respuesta = FabricaEntidad.crear();

        //Intrumentacion Logger


        // public override Crear Ejecutar(Usuario usuario)
        public Crear Ejecutar(Usuario usuario)
        {
            DaoService dao = FabricaDAO.crearDaoService();
            Crear respuesta = dao.AgregarUsuario(usuario);

            // Intrumentacion Logger

            return respuesta;
        }
    }
}
