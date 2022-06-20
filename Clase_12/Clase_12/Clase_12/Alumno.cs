﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnitos
{
    internal class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public List<int> Calificaciones { get; set; }
        


        public void CargarCalificacion(int Nota, DateTime Fecha)
        {
            Calificaciones.Add(Nota);
            Console.WriteLine(Fecha.ToString() + $"Se le asignó la calificación {Nota} al Legajo: {Legajo} ");
        }



        public void CargarCalificacion(int Nota)
        {
            Calificaciones.Add(Nota);
            var Fecha = DateTime.Now;
            Console.WriteLine(Fecha.ToString() + $"Se le asignó la calificación {Nota} al Legajo: {Legajo} ");
        }

        public decimal ObtenerPromedio()
        {
            decimal acumulador=0;
            foreach (var nota in Calificaciones)
            {
                acumulador+= nota;
            }   
            var promedio=acumulador/Calificaciones.Count();
            return promedio;
        }
    }
}