using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Proyecto.App.Presentacion.Pages
{
    public class FormularioClienteModel : PageModel
    {

        

        private readonly ILogger<FormularioClienteModel> _logger;

        public FormularioClienteModel(ILogger<FormularioClienteModel> logger)
       {
            _logger = logger;
        }
        
        public void OnGet()
        {
      
        }
    }
}
