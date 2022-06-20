/*
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo 
        en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, 
        el vector debe quedar así: 50, 40, 30, 20, 10.
        Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
6)      Mostrar el vector nuevamente.
*/


Console.WriteLine("Ingrese el tamaño deseado para el listado: ");
int n = int.Parse(Console.ReadLine());

int[] miVector = new int[n];
Random aleatorio = new Random();

for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(miVector.Length);
    Console.Write(miVector[i]+" ");
}

int extension_vector = miVector.Length - 1;

Console.WriteLine();
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

for (int i = 0; i < miVector.Length/2; i++)
{
    int tmp = miVector[i];
    miVector[i] = miVector[miVector.Length-1 - i];
    miVector[miVector.Length-1 - i] = tmp;
}

for (int i = 0; i < miVector.Length; i++)
{
    Console.Write(miVector[i] + " ");
}



