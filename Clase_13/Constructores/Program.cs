using Constructores.Modelo;

var persona1 = new Persona("Fernando Aparicio", "32034685", 36, true);

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Florencia"));

var persona2 = new Persona { NombreCompleto = "Florencia Turletti" };

//es necesario inicializar todos los atributos de la clase en el metodo constructor

//solo aquello a lo que voy a inicializar