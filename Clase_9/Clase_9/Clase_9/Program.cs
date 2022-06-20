//EJERCICIO 1

Console.WriteLine("Ingrese el tamaño deseado para el listado: ");
int n = int.Parse(Console.ReadLine());

int[] miVector = new int[n];

Random aleatorio = new Random(); // Nombre d ela clase para obtener datos aleatorios es Random()

for(int i=0; i<miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(100);
}

var contador = 0;

foreach (int i in miVector)
{
    contador++;
    Console.WriteLine(contador+": "+i+" ");
}

Console.WriteLine();
Console.WriteLine("Ingrese posición a modificar: ");
var k = int.Parse(Console.ReadLine());

if (k>miVector.Length-1 || k < 0)
{
    Console.WriteLine("Indice incaorrecto");
}
else
{
    Console.WriteLine("Ingrese nuevo valor");
}

var contador = 0;

foreach (int i in miVector)
{
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}