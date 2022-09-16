namespace Proyecto.App.Dominio
{
    public class Cita
    {
        public int CitaId {get; set;} 
        public string Descripcion {get; set;}
        public Cliente Cliente {get; set;}
        public Tecnico Tecnico {get; set;}
        public TipoServicio Servicio {get; set;}  //Se relaciona pero no crea llave foranea 
        
        
    }
}