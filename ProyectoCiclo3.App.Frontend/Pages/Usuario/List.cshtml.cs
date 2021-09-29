using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListUsuarioModel : PageModel
    {
       
        private readonly RepositorioUsuarios repositoriosUsuario;
        public IEnumerable<Usuarios> Usuario {get;set;}
 
    public ListUsuarioModel(RepositorioUsuarios repositorioUsuario)
    {
        this.repositoriosUsuario=repositorioUsuario;
     }
 
    public void OnGet()
    {
        Usuario=repositoriosUsuario.GetAll();
    }
    }
}

