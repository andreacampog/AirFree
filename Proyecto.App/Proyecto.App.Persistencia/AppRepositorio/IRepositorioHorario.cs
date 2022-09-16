using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioHorario
    {
    
    Horario Agregar(Horario horario);
    Horario Modificar(Horario horarioactualizar);
    void Eliminar (int id);
    Horario ObtenerPorId(int id);
    // Este es como devolver una lista: IEnumerabe es una estructura RECORDARLO ANDREA!!!
    IEnumerable<Horario> ObtenerTodos(); 

    }

}