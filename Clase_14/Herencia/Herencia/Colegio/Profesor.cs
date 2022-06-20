using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Colegio
{
    public class Profesor:Persona
    {
        public int CantidadAlumnos { get; set; }
        public int Materias { get; set; }
    }
}
