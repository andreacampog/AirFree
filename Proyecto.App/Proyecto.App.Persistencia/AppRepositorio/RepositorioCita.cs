using System;
using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq; //Libreria que permite conexion con BD
using Microsoft.EntityFrameworkCore;

namespace Proyecto.App.Persistencia
{       
 
    
    public class RepositorioCita : IRepositorioCita  
    
    {
        private readonly AppContext _appContext;    //creo una instancia de la Entidad AppContext para usarla en adelante

        public RepositorioCita (AppContext contexto) 
        {
            _appContext = contexto;
        }   

        IEnumerable<Cita> IRepositorioCita.ObtenerTodas()
        {
            return _appContext.Citas;   //Aqui digo: Conextarse con la base de datos y traerme la tabla Clientes
            //El nombre de la tabla en la base de datos por eso esta en plural

        }
        
        Cita IRepositorioCita.Agregar(Cita citanueva)
        {

            var citaagregada= _appContext.Citas.Add(citanueva);
            _appContext.SaveChanges();
            return citaagregada.Entity;

        }
        Cita IRepositorioCita.Modificar(Cita citaactualizar)
        {
           
            var citaModificar = _appContext.Citas.FirstOrDefault(s=> s.CitaId == citaactualizar.CitaId );
            if (citaModificar != null)
            {
                citaModificar.CitaId            = citaactualizar.CitaId;
                citaModificar.Descripcion       = citaactualizar.Descripcion;
                citaModificar.Cliente           = citaactualizar.Cliente;
                citaModificar.Tecnico           = citaactualizar.Tecnico;
                citaModificar.Servicio          = citaactualizar.Servicio;          
                _appContext.SaveChanges();  
            }
                return citaModificar;
        }

       
        void IRepositorioCita.Eliminar (int idABorrar)
        {
            var CitaBorrar = _appContext.Citas.FirstOrDefault(s => s.CitaId ==idABorrar);
            if(CitaBorrar!=null)
            {
                _appContext.Citas.Remove(CitaBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Cita IRepositorioCita.ObtenerPorId(int id)
        {
            return _appContext.Citas.FirstOrDefault(s => s.CitaId ==id);
            
        }       
    }
}
