using System;
using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq; //Libreria que permite conexion con BD
using Microsoft.EntityFrameworkCore;

namespace Proyecto.App.Persistencia
{       

    
    public class RepositorioTecnico : IRepositorioTecnico   //no es herencia QUIERE DECIR QUE IMPLEMENTA
    
    {
        private readonly AppContext _appContext;    //creo una instancia de la Entidad AppContext para usarla en adelante

        public RepositorioTecnico (AppContext contexto) 
        {
            _appContext = contexto;
        }   

        IEnumerable<Tecnico> IRepositorioTecnico.ObtenerTodos()
        {
            return _appContext.Tecnicos;   //Aqui digo: Conextarse con la base de datos y traerme la tabla Clientes
            //El nombre de la tabla en la base de datos por eso esta en plural

        }
        
        Tecnico IRepositorioTecnico.Agregar(Tecnico tecniconuevo)
        {
 
            var tecnicoagregado= _appContext.Tecnicos.Add(tecniconuevo);
            _appContext.SaveChanges();
            return tecnicoagregado.Entity;

        }
        Tecnico IRepositorioTecnico.Modificar(Tecnico tecnicoactualizar)
        {
    
            
            var tecnicoModificar = _appContext.Tecnicos.FirstOrDefault(t=> t.PersonaId == tecnicoactualizar.PersonaId );
            if (tecnicoModificar != null)
            {
                tecnicoModificar.NumeroRegistro= tecnicoactualizar.NumeroRegistro;
                tecnicoModificar.Horario= tecnicoactualizar.Horario;
                _appContext.SaveChanges();  
            }
                return tecnicoModificar;
        }

        void IRepositorioTecnico.Eliminar (int idABorrar)
        {
            var tecnicoBorrar = _appContext.Tecnicos.FirstOrDefault(t => t.PersonaId ==idABorrar);
            if(tecnicoBorrar!=null)
            {
                _appContext.Tecnicos.Remove(tecnicoBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Tecnico IRepositorioTecnico.ObtenerPorId(int id)
        {
            return _appContext.Tecnicos.FirstOrDefault(t => t.PersonaId ==id);
            
        }       
    }
}
