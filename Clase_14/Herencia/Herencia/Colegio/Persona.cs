using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Colegio
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public int DNI { get; set; }

        public Persona()
        {
            NombreCompleto = "Juan Perez";
            DNI = 22336655;
        }

        protected string Clave()
        {
            return "hola55";
        }
    }
}
