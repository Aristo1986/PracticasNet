using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores.Modelo
{
    internal class Persona
    {
        //propiedades o variables o atributos propias de la clase
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        //Constructor: se ejecuta al momento de crear una instancia de la clase
        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva persona");
        }

        public Persona(string nombreCompleto, string numeroDocumento, int edad ,bool estaCasado)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Edad = edad;
            EstaCasado = estaCasado;
        }

        //Métodos o funciones
        public string ObtenerSaludo()
        {
            return $"Hola, soy {NombreCompleto}";
        }

        public string ObtenerSaludo(string nombredePersonaAQuienSaludar)
        {
            return $"Hola {nombredePersonaAQuienSaludar}, soy {NombreCompleto}";
        }
    }
}

//Constructor en una función que se ejecuta al momento de instanciarse la clase que estamos construyendo
