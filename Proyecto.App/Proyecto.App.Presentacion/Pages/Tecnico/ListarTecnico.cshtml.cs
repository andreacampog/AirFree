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
    public class ListarTecnicoModel : PageModel
    {
        public IEnumerable <Tecnico> lista_tecnicos {get;set;} //Que voy a traer

        //Con que lo voy a traer
        private IRepositorioTecnico _repoTecnico;

        public ListarTecnicoModel()
        {
            //Al con que lo voy a traer le asigno lo que voy a traer y es todo lo que contiene la base de datos
            //pero especificamente todo lo de los TECNICOS 
            _repoTecnico= new RepositorioTecnico(new Proyecto.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            lista_tecnicos= _repoTecnico.ObtenerTodos();
        }
    }
}
