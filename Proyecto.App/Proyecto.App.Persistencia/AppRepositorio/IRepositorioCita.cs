using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioCita
    {
        Cita Agregar(Cita citanueva);
        Cita Modificar(Cita citaactualizar);
        void Eliminar(int id);
        Cita ObtenerPorId (int id);
        IEnumerable <Cita> ObtenerTodas();

    }
}



