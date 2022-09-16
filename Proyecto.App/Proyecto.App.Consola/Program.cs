using System;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Consola
{
    class Program
    {
        //Se debe instanciar Repositorio porque contiene los metodos
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Proyecto.App.Persistencia.AppContext());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Proyecto.App.Persistencia.AppContext());
        private static IRepositorioTecnico _repoTecnico = new RepositorioTecnico(new Proyecto.App.Persistencia.AppContext());
        private static IRepositorioCita _repoCita = new RepositorioCita(new Proyecto.App.Persistencia.AppContext());
        
       
        
        private static void Main(string[] args)
        {
            Console.WriteLine("HOLA ANDREA TU CONSOLA SI FUNCIONA!");
           
            //Agregar();
            //AgregarCliente();
            //ActualizarCliente();
            //ObtenerTodosClientes();
            //Buscar(8);
            //Actualizar();
            //Eliminar(2);
            //EliminarCliente(8);
            //BuscarCliente(4);
            //AgregarTecnico();
            AgregarCita();

        }

        private static void Agregar()
        {
            //instancio un objeto como en Java
            //pero como tengo que retornar lo almaceno en una variable persona
            var log = new Login{Usuario = "anamaria", Contraseña = "12345678"}; 
            Genero myvar = Genero.Transexual;
            var persona = new Persona{
                Nombre          = "Ana Maria ",
                Apellido        = "Ruiz Balanta",
                Direccion       = "Carrera 13 #14-10",
                Telefono        = "305412478",
                Correo          = "anitabalanta@hotmail.com" ,
                Genero          = myvar,
                Edad            = "30",
                Administrador   = 10,  //RECORDAR AQUI PONER TIPO bool NO RECORDABA COMO HACERLO EN C# PORQUE LO TENGO INT 
                Login           = log
            };
            _repoPersona.Agregar(persona);
        }

         private static void AgregarCliente()
        {
            //instancio un objeto como en Java
            //pero como tengo que retornar lo almaceno en una variable persona
            var log = new Login{Usuario = "yenni", Contraseña = "12345678"}; 
            Genero myvar = Genero.Femenino;
            var cliente = new Cliente{
                Nombre          = "Yenni Lorena ",
                Apellido        = "Munioz Alcazar",
                Direccion       = "Carrera 13 #14-10",
                Telefono        = "305412478",
                Correo          = "yennilorena@hotmail.com" ,
                Genero          = myvar,
                Edad            = "30",
                Administrador   = 10,  //RECORDAR AQUI PONER TIPO bool NO RECORDABA COMO HACERLO EN C# PORQUE LO TENGO INT 
                Login           = log,
                Membresia       = 1
            };
            _repoCliente.AgregarCliente(cliente);
        }

        
        //*****************Buscar *****************
        private static void Buscar(int idp)
        {
            //lo voy a buscar por id
            var pers = _repoPersona.ObtenerPorId(idp); 
            if (pers!= null)
            {           
            Console.WriteLine("El cliente que buscas es: " + pers.Nombre + " " +pers.Apellido);
            }
            else
            {
            Console.WriteLine("El cliente  que buscas no existe");
            }
        } 
        
   
         //*****************Modificar *****************
          private static void Actualizar()
        {
            var log = new Login{Usuario = "personamodificada", Contraseña = "00000000"}; 
            Genero myvar = Genero.Femenino;
            var persona = new Persona{
                PersonaId       = 3,
                Nombre          = "Persona Modificada ",
                Apellido        = "Utilizando el metodo",
                Direccion       = "Diagonal 10 #2-48",
                Telefono        = "3002239841",
                Correo          = "personamodificada@hotmail.com" ,
                Genero          = myvar,
                Edad            = "50",
                Administrador   = 0,  //RECORDAR AQUI PONER TIPO bool NO RECORDABA COMO HACERLO EN C# PORQUE LO TENGO INT 
                Login           = log
            };
            Console.WriteLine("Se actualizo el registro ");
           _repoPersona.Modificar(persona);
                         
        }

           private static void ActualizarCliente()
        {
            var log = new Login{Usuario = "clientemodificado", Contraseña = "00000000"}; 
            Genero myvar = Genero.Femenino;
            var cliente = new Cliente{
                PersonaId       = 7,
                Nombre          = "Cliente Modificado ",
                Apellido        = "Utilizando el metodo",
                Direccion       = "Diagonal 10 #2-48",
                Telefono        = "3002239841",
                Correo          = "clientemodificado@hotmail.com" ,
                Genero          = myvar,
                Edad            = "50",
                Administrador   = 0,  //RECORDAR AQUI PONER TIPO bool NO RECORDABA COMO HACERLO EN C# PORQUE LO TENGO INT 
                Login           = log,
                Membresia       = 0
            };
            Console.WriteLine("Se actualizo el registro ");
           _repoCliente.ModificarCliente(cliente);
                         
        }

        //*****************Eliminar *****************
        private static void Eliminar(int idp)
        {
            var pers = _repoPersona.ObtenerPorId(idp); 
            if (pers!= null)
            {           
            Console.WriteLine("La persona que eliminaste es: " + pers.Nombre + " " +pers.Apellido);
            _repoPersona.Eliminar(idp);
            }
            else
            {
            Console.WriteLine("La persona que deseas eliminar no existe");
            }

        }   

        //*****************Eliminar Cliente*****************
        private static void EliminarCliente(int idp)
        {
            var client = _repoCliente.ObtenerPorId(idp); 
            if (client!= null)
            {           
            Console.WriteLine("La persona que eliminaste es: " + client.Nombre + " " +client.Apellido);
            _repoPersona.Eliminar(idp);
            }
            else
            {
            Console.WriteLine("La persona que deseas eliminar no existe");
            }

        }

        //*****************Buscar *****************
        private static void BuscarCliente(int idp)
        {
            //lo voy a buscar por id
            var client = _repoCliente.ObtenerPorId(idp); 
            if (client!= null)
            {           
            Console.WriteLine("La persona que buscas es: " + client.Nombre + " " +client.Apellido);
            }
            else
            {
            Console.WriteLine("La persona que buscas no existe");
            }
        }    


         private static void AgregarTecnico()
        {
            var log = new Login{Usuario = "tecnico", Contraseña = "05550"}; 
            var horario = new Horario{Fecha = new DateTime(2022, 11,10) };
            var tecnico = new Tecnico{
                
                Nombre          = "Creacion Tecnico",   
                Apellido        = "Lopez Diaz",
                Direccion       = "Carrera 3 #1-52",
                Telefono        = "398746478",
                Correo          = "tecnico@hotmail.com" ,
                Genero          = Genero.Masculino,
                Edad            = "36",
                Administrador   = 10, 
                Login           = log,
                NumeroRegistro  = "123456",
                Horario         = horario
              
            };
            _repoTecnico.Agregar(tecnico);
        }


        
         private static void AgregarCita()
        {
            var log = new Login{Usuario = "tecnico", Contraseña = "05550"}; 
            var horario = new Horario{Fecha = new DateTime(2022, 11,10) };
            TipoServicio mymant = TipoServicio.Mantenimiento;      
            var cliente = new Cliente{
                Nombre          = "Cliente agregado ",
                Apellido        = "desde citas",
                Direccion       = "Diagonal 10 #2-48",
                Telefono        = "3002239841",
                Correo          = "cliente4@hotmail.com" ,
                Genero          = Genero.Femenino,
                Edad            = "50",
                Administrador   = 0,  //RECORDAR AQUI PONER TIPO bool NO RECORDABA COMO HACERLO EN C# PORQUE LO TENGO INT 
                Login           = log,
                Membresia       = 0
            };

            var tecnico      =   new Tecnico{                
                Nombre          = "Creacion Tecnico2",   
                Apellido        = "Lopez Diaz",
                Direccion       = "Carrera 3 #1-52",
                Telefono        = "398746478",
                Correo          = "tecnico@hotmail.com" ,
                Genero          = Genero.Masculino,
                Edad            = "36",
                Administrador   = 10, 
                Login           = log,
                NumeroRegistro  = "123456",
                Horario         = horario
              
            };
               var cita = new Cita {Descripcion= "Aqui esta la descripcion", Cliente= cliente, Tecnico= tecnico, Servicio= mymant} ;           
            
            _repoCita.Agregar(cita);
        }


         
          
    }
}


