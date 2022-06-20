using Alumnitos;

var alumno1 = new Alumno();

alumno1.Apellido = "Aparicio";
alumno1.Nombre = "Fernando";
alumno1.Legajo = 1;
alumno1.DNI = "32034685";
alumno1.FechaNacimiento = new DateTime(1986,1,1);    //Me devuelve la fecha de ese momento-minuto 27
alumno1.Calificaciones = new List<int>();


var alumno2=new Alumno();
alumno2.Apellido = "Diaz";
alumno2.Nombre = "Darío";
alumno2.Legajo = 2;
alumno2.DNI = "34589963";
alumno2.FechaNacimiento = new DateTime(2000, 6, 2);

//Usa () porque es un método y lo otro son propiedades. Para poder llamar un método o función si o si hay que usar ()

//Cómo invocamos o llamamos a una funcion o método? Una función o método se llama si o si con el uso de ()

alumno1.CargarCalificacion(9, new DateTime(2022,6,1));
alumno1.CargarCalificacion(2, new DateTime(2022, 4, 10)); 
alumno1.CargarCalificacion(8);


Console.WriteLine(alumno1.Calificaciones.Count);
Console.WriteLine(alumno1.ObtenerPromedio());

/* es posible tener dos funciones con el mismo nombre? justifique su repuesta
Si. Por sobrecarga, que es la posibilidad de crear dos métodos o funciones con el mismo nombre pero con distintos parámetros
*/