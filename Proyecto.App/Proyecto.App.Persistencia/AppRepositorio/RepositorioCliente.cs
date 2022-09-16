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
    
    public class RepositorioCliente : IRepositorioCliente   //no es herencia QUIERE DECIR QUE IMPLEMENTA
    
    {
        private readonly AppContext _appContext; 
        

        public RepositorioCliente (AppContext contexto) 
        {
            _appContext = contexto;
        }  
        
        IEnumerable<Cliente> IRepositorioCliente.ObtenerTodosClientes()
        {
          return _appContext.Clientes;   //Aqui digo: Conextarse con la base de datos y traerme la tabla Clientes
            //El nombre de la tabla en la base de datos por eso esta en plural

        }
        
        Cliente IRepositorioCliente.AgregarCliente(Cliente clientenuevo)
        {
            //Le digo a la base de datos osea al appcontext
            //agregueme un cliente nuevo
            //queda guardado en clienteagregado con id y todo
            //para eso lo devuelvo 

            var clienteagregado= _appContext.Clientes.Add(clientenuevo);
            _appContext.SaveChanges();
            return clienteagregado.Entity;

        }
        Cliente IRepositorioCliente.ModificarCliente(Cliente clienteactualizar)
        {
            //Aqui es diferente porque tengo que jalar el id del cliente
            //Como tomar el atributo id del cliente en los otros metodos me llega por parametro id
            
            var clienteModificar = _appContext.Clientes.FirstOrDefault(c=> c.PersonaId == clienteactualizar.PersonaId );
            if (clienteModificar != null)
            {
                clienteModificar.Nombre= clienteactualizar.Nombre;
                clienteModificar.Apellido= clienteactualizar.Apellido;
                clienteModificar.Direccion= clienteactualizar.Direccion;
                clienteModificar.Telefono= clienteactualizar.Telefono;
                clienteModificar.Correo= clienteactualizar.Correo;
                clienteModificar.Edad= clienteactualizar.Edad;
                clienteModificar.Genero= clienteactualizar.Genero;
                clienteModificar.Administrador =clienteactualizar.Administrador;
                clienteModificar.Login =clienteactualizar.Login;    
                clienteModificar.Membresia = clienteactualizar.Membresia;
                _appContext.SaveChanges();  
            }
                return clienteModificar;
        }

        void IRepositorioCliente.Eliminar (int idABorrar)
        {
            var clienteBorrar = _appContext.Clientes.FirstOrDefault(c => c.PersonaId ==idABorrar);
            if(clienteBorrar!=null)
            {
                _appContext.Clientes.Remove(clienteBorrar);
                _appContext.SaveChanges();
    
            }
        }

        Cliente IRepositorioCliente.ObtenerPorId(int id)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.PersonaId ==id);
            
        } 

          
    }
}
