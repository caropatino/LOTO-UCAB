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
    public class ComandoConsultarUsuarios : Comando<Consulta>
    {

        public override Consulta Ejecutar()
        {
            //Intrumentacion Logger

            DaoService dao = FabricaDAO.crearDaoService();
            Consulta respuesta = dao.ConsultarUsuarios();

            //Intrumentacion Logger

            return respuesta;
        }

    }
}

