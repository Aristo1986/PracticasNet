using Clase14;

var personas = new List<Persona>();

//Persona p=null;                 // si no le asigno algo da error de compilación
for (int i = 0; i < 10; i++)    
{
    p=new Persona();
}

Console.WriteLine($"{p.nombre} {p.apellido}");

/*
Al correr el programa solo imprime uno. Donde están los otros objetos? Están en memoria.
La primera vez que entra a p le asigna la "persona". La memoria (RAM) tiene dos lugares (geap y stack), el geap que es donde
vivien los objetos. La persona se va guardando en geap, en el monton y no se pueden recuperar ni borrar, lo que se destruye es la referencia al objeto
pero el objeto continua ahi. El lenguaje .Net va destruyendo la memoria que va usando con garbage collector (recolector de basura)
*/

//que es el recolector de basura
//Es un proceso propio del Lenguaje NET en el cual se va limpiando automáticamente la memoria