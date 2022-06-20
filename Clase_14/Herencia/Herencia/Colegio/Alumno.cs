using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Colegio
{
    public class Alumno:Persona //La clase Alumno hereda de Persona 
    {
        public string Curso { get; set; }
        public string Division { get; set; }

        public string recuperarClave()
        {
            return Clave();
        }
    }
}
