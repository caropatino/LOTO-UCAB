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
    public class ComandoModificarUsuario
    {
        Modificar respuesta = FabricaEntidad.modificar();

        //Intrumentacion Logger

        public Modificar Ejecutar(Usuario usuario)
        {
            DaoService dao = FabricaDAO.crearDaoService();
            Modificar respuesta = dao.ModificarUsuario(usuario);

            // Intrumentacion Logger

            return respuesta;
        }

    }
}
