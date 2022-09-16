using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq; //Libreria que permite conexion con BD

namespace Proyecto.App.Persistencia
{       
    // RepositorioPersona firma un contrato con IRepositorioPersona
    //Significa que esta obligado a implementar todos los metodos
    //que estan en IRepositorioPersona
    
    public class RepositorioPersona : IRepositorioPersona   //Se ve como una herencia 
    
    {
        private readonly AppContext _appContext;  
        public RepositorioPersona (AppContext contexto) 
        {
            _appContext = contexto;
        }   

         IEnumerable<Persona> IRepositorioPersona.ObtenerTodos()
        {
            return _appContext.Personas;  //El nombre de la tabla en la base de datos 

        }
        
        Persona IRepositorioPersona.Agregar(Persona personanueva)
        {
            //Le digo a la base de datos osea al appcontext
            //agregueme una persona nueva
            //queda guardado en personaagregada con id y todo
            //para eso lo devuelvo 

            var personaagregada= _appContext.Personas.Add(personanueva);
            _appContext.SaveChanges();
            return personaagregada.Entity;

        }
        Persona IRepositorioPersona.Modificar(Persona personaactualizar)
        {
            //Aqui es diferente porque tengo que jalar el id de la persona
            //Como tomar el atributo id de la persona en los otros metodos me llega por parametro id
            
            var personaModificar = _appContext.Personas.FirstOrDefault(p=> p.PersonaId == personaactualizar.PersonaId );
            if (personaModificar != null)
            {
                personaModificar.Nombre= personaactualizar.Nombre;
                personaModificar.Apellido= personaactualizar.Apellido;
                personaModificar.Direccion= personaactualizar.Direccion;
                personaModificar.Telefono= personaactualizar.Telefono;
                personaModificar.Correo= personaactualizar.Correo;
                personaModificar.Edad= personaactualizar.Edad;
                personaModificar.Genero= personaactualizar.Genero;
                personaModificar.Administrador =personaactualizar.Administrador;
                personaModificar.Login =personaactualizar.Login;    
                _appContext.SaveChanges();  
            }
                return personaModificar;
        }

        void IRepositorioPersona.Eliminar (int idABorrar)
        {
            var PersonaBorrar = _appContext.Personas.FirstOrDefault(p => p.PersonaId ==idABorrar);
            if(PersonaBorrar!=null)
            {
                _appContext.Personas.Remove(PersonaBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Persona IRepositorioPersona.ObtenerPorId(int id)
        {
            return _appContext.Personas.FirstOrDefault(p => p.PersonaId ==id);
            
        }

        
    
        

    }
}

