/*

int primerNumero = 1986;        //Variable del tipo valor

int segundoNumero = primerNumero;       //le damos el valor de la primera

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);

primerNumero = 1978;        //modifico el valor

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);
*/

/////////////////////////////////SEGUNDA PARTE///////////////////////////////
//Variables del tipo referencias
/*
using Clase15.Modelos;

var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "Juancito Perez"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miSegundaClase.Nombre);

miPrimerClase.Nombre = "Andres Gomez";

Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);

//las instancias son del tipo referencia
*/

/////////////////////////////////TERCERA PARTE///////////////////////////////
/*
using Clase15.Modelos;

var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "Pepe"
};

var miSegundaClase = new MiClase
{
    Id = 2,
    Nombre = "QUINO"
};

var miLista=new List<MiClase>();
miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);



foreach (var item in miLista)
{
    Console.WriteLine(item.Nombre);
    if(item.Id == 1)
    {
        item.Nombre = "ROBERTO";
    }
}
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);

//si yo creo una referencia de una instancia de una clase, y modifico el vamor de un atributo
// de dicha referencias, que sucede con la instancia original
//El valor del atributo de la instancia original tambien se modifica
*/

/////////////////////////////////CUARTA PARTE///////////////////////////////
///
using Clase15.Modelos;

var primerPersona = new Persona
{
    Apellido = "Mateos",
    Nombre = "Joaquin"
};

var PrimerDocente = new Docente
{
    Salario = 70000,
    Nombre = "Juan Pablo",
    Apellido = "Ferreyra"
};

var primerAlumno = new Alumno
{
    Legajo = 1234,
    Apellido = "Rodriguez",
    Nombre = "Ricardo"
};

var personas = new List<Persona>();
personas.Add(primerPersona);
personas.Add(primerAlumno);
personas.Add(PrimerDocente);

foreach (var persona in personas)
{
    Console.WriteLine(persona.Nombre);
    if (persona.GetType() == typeof(Docente))   //si el tipo que entra es igual al tipo salida, devuelve lo que esta entre parentesis
    {
        var docente = (Docente)persona;   //quiero que trates a persona como docente en la variable "docente"(castear)
        Console.WriteLine(docente.Salario);
    }

    //que sucede si intentamos castear una instancia de un objeto en una clase que no pertenece o no hereda
    

}