using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioPersona
    {
    
    Persona Agregar(Persona persona);
    Persona Modificar(Persona personaactualizar);
    void Eliminar (int id);
    Persona ObtenerPorId(int id);
    // Este es como devolver una lista: IEnumerabe es una estructura RECORDARLO ANDREA!!!
    IEnumerable<Persona> ObtenerTodos();     

    }

}

