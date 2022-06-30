using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab13.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNaci { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}