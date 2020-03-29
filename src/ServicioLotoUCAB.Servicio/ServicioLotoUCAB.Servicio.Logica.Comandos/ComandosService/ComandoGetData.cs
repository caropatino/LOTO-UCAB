using ServicioLotoUCAB.Servicio.AccesoDatos;
using ServicioLotoUCAB.Servicio.AccesoDatos.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos.ComandosService
{
    public class ComandoGetData : Comando<string>
    {
        public override string Ejecutar()
        {
            //Intrumentacion Logger

             DaoService dao = FabricaDAO.crearDaoService();
             string respuesta = dao.GetData();

             //Intrumentacion Logger
            return respuesta;
        }

    }
}
