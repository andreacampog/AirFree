using System;
using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq; //Libreria que permite conexion con BD
using Microsoft.EntityFrameworkCore;

namespace Proyecto.App.Persistencia
{       
 
    
    public class RepositorioLogin: IRepositorioLogin
    
    {
        private readonly AppContext _appContext;    //creo una instancia de la Entidad AppContext para usarla en adelante

        public RepositorioLogin (AppContext contexto) 
        {
            _appContext = contexto;
        }   

        IEnumerable<Login> IRepositorioLogin.ObtenerTodas()
        {
            return _appContext.Logins;   //Aqui digo: Conextarse con la base de datos y traerme la tabla Clientes
            //El nombre de la tabla en la base de datos por eso esta en plural

        }
        
        Login IRepositorioLogin.Agregar(Login loginnuevo)
        {

            var loginagregado= _appContext.Logins.Add(loginnuevo);
            _appContext.SaveChanges();
            return loginagregado.Entity;

        }
        Login IRepositorioLogin.Modificar(Login loginactualizar)
        {
           
            var loginModificar = _appContext.Logins.FirstOrDefault(l=> l.LoginId == loginactualizar.LoginId );
            if (loginModificar != null)
            {
                loginModificar.LoginId            = loginactualizar.LoginId;
                loginModificar.Usuario           = loginactualizar.Usuario;
                loginModificar.Contraseña        = loginactualizar.Contraseña;           
                _appContext.SaveChanges();  
            }
                return loginModificar;
        }

       
        void IRepositorioLogin.Eliminar (int idABorrar)
        {
            var LoginBorrar = _appContext.Logins.FirstOrDefault(l => l.LoginId ==idABorrar);
            if(LoginBorrar!=null)
            {
                _appContext.Logins.Remove(LoginBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Login IRepositorioLogin.ObtenerPorId(int id)
        {
            return _appContext.Logins.FirstOrDefault(l => l.LoginId ==id);
            
        }       
    }
}
