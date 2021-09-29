using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuarios> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuarios>()
{
                new Usuarios{id=1,nombre="Mario",apellidos= "Sánchez",direccion= "Carrera 27",telefono= "8945412121"},
                new Usuarios{id=2,nombre="Camila",apellidos= "Rodriguez",direccion= "Calle 96",telefono= "895656562"},
                new Usuarios{id=3,nombre="Maria Carolina",apellidos= "Perez",direccion= "Avenida Sur con 14",telefono= "12145454"} 
            }; 
        }
 
        public IEnumerable<Usuarios> GetAll()
        {
            return usuarios;
        }
 
        public Usuarios GetUsuariosWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }
    }
}
