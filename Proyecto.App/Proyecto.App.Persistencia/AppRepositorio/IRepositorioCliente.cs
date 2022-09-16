using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente AgregarCliente(Cliente clientenuevo);
        Cliente ModificarCliente (Cliente clienteactualizar);
        void Eliminar(int id);
        Cliente ObtenerPorId (int id);
        IEnumerable <Cliente> ObtenerTodosClientes();

    }
}

