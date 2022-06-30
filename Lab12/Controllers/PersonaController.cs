using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;

namespace Lab12.Controllers
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
                Nombre = " Nicolle",
                Apellido = "Puma",
                FechaNaci = Convert.ToDateTime("2001-11-05"),
                Direccion = "Arequipa-3 de Octubre Mz E' Lote 4",
                Email = "nicolle.puma@tecsup.edu.pe"
            });

            personas.Add(new Persona
            {
                PersonaId = 2,
                Nombre = "Josias",
                Apellido = "Martinez",
                FechaNaci = Convert.ToDateTime("1982-02-14"),
                Direccion = "Av. Los manzanos 101",
                Email = "josias@gmail.com"
            });

            personas.Add(new Persona
            {
                PersonaId = 3,
                Nombre = " Maria Jose",
                Apellido = "Salas",
                FechaNaci = Convert.ToDateTime("1995-10-28"),
                Direccion = "Av. Progreso 325",
                Email = "maria.salas@gmail.com"
            });
            return View(personas);


        }
    }
}