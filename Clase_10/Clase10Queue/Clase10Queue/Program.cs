//Pilas
/*
var miPila=new Stack<int>();

miPila.Push(1);
miPila.Push(2);
miPila.Push(3);
miPila.Push(4);

Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
*/

//Colas (FIFO:primiero en entrar es primero en salir)
var miCola=new Queue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());





/*
 Que son las estructura de datos LIFO y FIFO y dar un ejemplo de cada una

Estructura FIFO: estructura en cola, donde el primero que entra es el primero que sale. Ejemplo la cola de un supermercado
Estructura LIFO: estructura en pila, donde el ultimo en entrar es el primero en salir. Ejemplo cuando queremos volver al ultimo paso (Ctrl+z)
 */