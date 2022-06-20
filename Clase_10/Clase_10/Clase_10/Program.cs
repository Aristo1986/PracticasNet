//Listas
/*
 Estructuras de datos

1) Arrays

Un array es una colección de datos que se almacenan en una sola variable.
    Los arrays se pueden crear de dos formas:
        - Una variable de tipo array de una dimensión
        - Una variable de tipo array multidimensional

2) Listas
3) Colas
4) Pila
5) Diccionarios
*/

//Inicializacion de Array
var miArray = new Array[10];    //Le especifico una capacidad cuando se crea un Array 

for (int i = 0; i < miArray.Length; i++)
{
    Console.WriteLine(miArray[i]);
}

foreach (var item in miArray)
{
    Console.WriteLine(item);
}

//Inicializar una lista
/*
var personas = new List<string>();   //creo una instancia de una lista

personas.Add("Ezequiel");
personas.Add("Juan");
personas.Add("Eugenio");

foreach (var persona in personas)
{
    Console.WriteLine(persona);
}


Escribir un programa que permita al usuario confeccionar una lista de nombres. Se debe ofrecer las siguientes opciones:
1-Agregar un elemento (al final o en una posicion determinada)
2-Quitar un elemento
3-Mostrar en que posicion se encuentra un determinado elemento
4-Invertir lista
*/

var listaNombres = new List<string>();

string entradaUsuario;

do
{
    Console.WriteLine("Bienvenido a Lista");
    Console.WriteLine("Seleccione una de las siguientes opciones: ");
    Console.WriteLine("1-Agregar un elemento");
    Console.WriteLine("2-Quitar un elemento");
    Console.WriteLine("3-Ubicar un elemento");
    Console.WriteLine("4-Invertir la lista");
    Console.WriteLine("5-Ver el contenido de la lista");
    Console.WriteLine("0-Salir");

    entradaUsuario = Console.ReadLine();

    switch (entradaUsuario)
    {
        case "1":
            //Agregar un elemento
            Console.WriteLine("Ingrese el elemento: ");
            var nuevoElemento = Console.ReadLine();

            Console.WriteLine("Donde desea agregar el elemento?");
            Console.WriteLine("1-Al final");
            Console.WriteLine("2-En una posicion determinada");

            var opcionParaIngresar = Console.ReadLine();
            switch (opcionParaIngresar)
            {
                case "1":
                    //Al final
                    listaNombres.Add(nuevoElemento);
                    break;
                case "2":
                    //Insertar un elemento en una posición
                    Console.WriteLine("Ingrese posicion: ");
                    var posicionAIngresar = int.Parse(Console.ReadLine());

                    listaNombres.Insert(posicionAIngresar, nuevoElemento);
                    break;
            }
            break;
        case "2":
            //Quitar elemento
            Console.WriteLine("Ingrese el elemento que desa quitar: ");
            var elementoARemover = Console.ReadLine();
            listaNombres.Remove(elementoARemover);
            break;

        case "3":
            //Ubicar un elemento
            Console.WriteLine("Ingrese el elemento que desa ubicar: ");
            var elementoAUbicar = Console.ReadLine();
            var ubicacion = listaNombres.IndexOf(elementoAUbicar);
            if (ubicacion > -1)
            {
                Console.WriteLine("El elemento se encuentra en la posición " + ubicacion);
            }
            else
            {
                Console.WriteLine("Ese elemento no existe");
            }
            break;

        case "4":
            //Invertir la lista
            listaNombres.Reverse();
            Console.WriteLine("La lista se ha invertido. ");
            break;

        case "5":
            //Ver lista
            if (listaNombres.Count == 0)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                foreach (var item in listaNombres)
                {
                    Console.WriteLine(item);
                }
            }                       
            break;
    }
    
}
while (entradaUsuario != "0");


//var nuevoNombre = Console.ReadLine();


/*que significa count y capacity en una lista

Capacity: para saber cuantos elementos puede contener la lista sin ser redimensionada
Count: dice cuantos elementos hay en la lista
*/