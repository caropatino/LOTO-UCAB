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
    public class ComandoConsultarUsuarioPorID
    {
        Consulta repsuesta = FabricaEntidad.crearConsulta();
        public Consulta Ejecutar(int id_usuario)
        {
            //Intrumentacion Logger

            DaoService dao = FabricaDAO.crearDaoService();
            Consulta respuesta = dao.ConsultarUsuarioPorID(id_usuario);

            //Intrumentacion Logger

            return respuesta;
        }
    }
}
