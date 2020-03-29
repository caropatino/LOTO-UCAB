
using ServicioLotoUCAB.Servicio.Entidades;

namespace ServicioLotoUCAB.Servicio.Logica.Comandos
{
    public interface IComando<TSalida>
    {
        TSalida Ejecutar();
    }
}
