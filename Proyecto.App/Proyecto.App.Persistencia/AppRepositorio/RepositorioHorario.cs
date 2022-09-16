using System;
using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq; //Libreria que permite conexion con BD
using Microsoft.EntityFrameworkCore;

namespace Proyecto.App.Persistencia
{       
    // RepositorioCliente firma un contrato con IRepositorioCliente
    //Significa que esta obligado a implementar todos los metodos
    //que estan en IRepositorioCliente
    
    public class RepositorioHorario : IRepositorioHorario   //no es herencia QUIERE DECIR QUE IMPLEMENTA
    
    {
        private readonly AppContext _appContext;    //creo una instancia de la Entidad AppContext para usarla en adelante

        public RepositorioHorario (AppContext contexto) 
        {
            _appContext = contexto;
        }   

        IEnumerable<Horario> IRepositorioHorario.ObtenerTodos()
        {
            return _appContext.Horarios;   //Aqui digo: Conextarse con la base de datos y traerme la tabla Clientes
            //El nombre de la tabla en la base de datos por eso esta en plural

        }
        
        Horario IRepositorioHorario.Agregar(Horario horarionuevo)
        {

            var horarioagregado= _appContext.Horarios.Add(horarionuevo);
            _appContext.SaveChanges();
            return horarioagregado.Entity;

        }
        Horario IRepositorioHorario.Modificar(Horario horarioactualizar)
        {
           
            var horarioModificar = _appContext.Horarios.FirstOrDefault(h=> h.HorarioId == horarioactualizar.HorarioId );
            if (horarioModificar != null)
            {
                horarioModificar.HorarioId= horarioactualizar.HorarioId;
                horarioModificar.Fecha= horarioactualizar.Fecha;
                horarioModificar.Hora= horarioactualizar.Hora;              
                _appContext.SaveChanges();  
            }
                return horarioModificar;
        }

        void IRepositorioHorario.Eliminar (int idABorrar)
        {
            var horarioBorrar = _appContext.Horarios.FirstOrDefault(h => h.HorarioId ==idABorrar);
            if(horarioBorrar!=null)
            {
                _appContext.Horarios.Remove(horarioBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Horario IRepositorioHorario.ObtenerPorId(int id)
        {
            return _appContext.Horarios.FirstOrDefault(h => h.HorarioId ==id);
            
        }       
    }
}
