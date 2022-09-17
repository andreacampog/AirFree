using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.App.Persistencia;
using Proyecto.App.Dominio;


namespace Proyecto.App.Presentacion.Pages
{  
    public class ListarCitaModel : PageModel
    {
        public IEnumerable<Cita> lista_citas {get; set;}  //Que necesito    
        //con que
        private IRepositorioCita _repoCita;

        public ListarCitaModel()
        {
            //al con que le asigno lo que traigo de la base de datos (Appcontext)
            _repoCita = new RepositorioCita(new Proyecto.App.Persistencia.AppContext());

        }          
        public void OnGet()
        {
            lista_citas= _repoCita.ObtenerTodas();
        }
    }
}
