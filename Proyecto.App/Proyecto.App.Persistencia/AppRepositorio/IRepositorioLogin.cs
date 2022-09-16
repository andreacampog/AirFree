using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioLogin
    {
        Login Agregar(Login loginnueva);
        Login Modificar(Login loginactualizar);
        void Eliminar(int id);
        Login ObtenerPorId (int id);
        IEnumerable <Login> ObtenerTodas();

    }
}