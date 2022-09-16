namespace Proyecto.App.Dominio
{
    public class Persona
    {
        public int PersonaId {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public string Correo {get; set;}
        public string Edad {get; set;}
        public Genero Genero { get; set; } 
        public int Administrador {get; set;}
        public Login Login {get;set;}


    }
}