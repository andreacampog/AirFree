using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio;  //Este se agrega cuando verifico que agregue la referencia desde el terminal 
using System;

namespace Proyecto.App.Persistencia
{
    public class AppContext : DbContext  //La clase base es DbContext 
    {
        public DbSet<Persona> Personas { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Tecnico> Tecnicos {get; set;}
        public DbSet<Cita> Citas {get; set;}
        public DbSet<Horario> Horarios {get; set;}
        public DbSet<Login> Logins {get; set;}
        

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DATAPRO");  //Cadena de conexion HospiEnCasaData es el nombre de la base de datos 
            }
        }
    }
}