using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
using Microsoft.EntityFrameworkCore;


namespace Proyecto.App.Presentacion.Pages
{
    public class ListarModel : PageModel
    {
        //LO QUE QUIERO TRAER
        //Aqui estoy diciendo: NECESITO TRAER LA LISTA DE <CLIENTE> y debe tener get y set
        public IEnumerable<Cliente> lista_clientes {get; set;}

        //QUIEN ME LO TRAE 
        //Si tengo lista necesito aqui quien me lo traiga
        //los encargados de traer de la base de datos son los IREPOSITORIOS
        private IRepositorioCliente _repoCliente;  //LOGICA DEL NEGOCIO 



        public ListarModel()
        {
            _repoCliente= new RepositorioCliente(new Proyecto.App.Persistencia.AppContext());

        }
       
       
       
       public void OnGet()
        {
            lista_clientes= _repoCliente.ObtenerTodosClientes();
          
            

        }
    }
}
