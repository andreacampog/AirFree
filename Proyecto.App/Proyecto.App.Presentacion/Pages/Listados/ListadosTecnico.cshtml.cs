using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto.App.Presentacion.Pages
{
    public class ListadosTecnicoModel : PageModel
    {
        private string [] tecnicos = {"Tecnico 1" , "Tecnico 2" , "Tecnico 3"};
        public List <string> ListaTecnicos {get; set;}


        public void OnGet()
        {
            ListaTecnicos = new List<string>();
            ListaTecnicos.AddRange(tecnicos);
        }
    }
}
