using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaId = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av.Evergreen 123",
                FechaNaci = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaId = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNaci = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaId = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av.Los Manzanos 101",
                FechaNaci = Convert.ToDateTime("1982-02-14"),
                Email = "juan@mail.com"
            });
            return View(personas);
        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaId = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av.Evergreen 123",
                FechaNaci = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaId = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNaci = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaId = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av.Los Manzanos 101",
                FechaNaci = Convert.ToDateTime("1982-02-14"),
                Email = "juan@mail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaId == id
                               select p).FirstOrDefault();

            return View(persona);
        }
    }
}