using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioTecnico
    {
        Tecnico Agregar(Tecnico tecniconuevo);
        Tecnico Modificar (Tecnico tecnicoactualizar);
        void Eliminar(int id);
        Tecnico ObtenerPorId (int id);
        IEnumerable <Tecnico> ObtenerTodos();

    }
}

