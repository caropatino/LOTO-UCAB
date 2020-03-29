using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioLotoUCAB.Servicio.AccesoDatos;
using ServicioLotoUCAB.Servicio.AccesoDatos.Dao;
using ServicioLotoUCAB.Servicio.Entidades;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService
{
    public class ComandoEliminarUsuario
    {
        public  Eliminar Ejecutar(int id_usuario, int estadoeliminado)
        {
            //Intrumentacion Logger

            DaoService dao = FabricaDAO.crearDaoService();
            Eliminar respuesta = dao.EliminarUsuario(id_usuario,estadoeliminado);

            //Intrumentacion Logger

            return respuesta;
        }
    }
}
