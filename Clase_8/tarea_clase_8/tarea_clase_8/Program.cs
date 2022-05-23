/*
Ejercicio

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

/*
Console.WriteLine("Ingrese cantidad de columnas");
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de filas");
int cantidadFilas = int.Parse(Console.ReadLine());


int[,] numeros = new int[cantidadFilas, cantidadColumnas];
double[] promedios = new double[cantidadColumnas];


int lengthFilas = numeros.GetUpperBound(0) + 1;       //cantidad de filas
int lengthColumnas = numeros.GetUpperBound(1) + 1;    //cantidad de columnas


//Recorremos las columnas
for (int columna=0; columna<lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Número de la columna N°: {columna+1}");

    //recorremos las filas
    for(int fila=0; fila<lengthFilas; fila++)
    {
        Console.WriteLine();
        Console.WriteLine($"Cargue N° {fila + 1}:");
        numeros[fila, columna] = int.Parse(Console.ReadLine());                     
    }
}

for (int columna = 0; columna < cantidadColumnas; columna++)
{
    double suma = 0;
    
    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        suma += numeros[fila, columna];
    }
    promedios[columna] = suma / cantidadFilas;
}
Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();
for (int i=0; i<cantidadColumnas; i++)
{
    Console.WriteLine($"El promedio de la columna N° {i + 1} es: {promedios[i]}");
}

Console.ReadKey();

*/





Console.WriteLine("Ingrese cantidad de columnas");
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de filas");
int cantidadFilas = int.Parse(Console.ReadLine());


int[,] numeros = new int[cantidadFilas, cantidadColumnas];
double[] promedios = new double[cantidadColumnas];


int lengthFilas = numeros.GetUpperBound(0) + 1;       //cantidad de filas
int lengthColumnas = numeros.GetUpperBound(1) + 1;    //cantidad de columnas


//Recorremos las columnas
for (int i = 0; i < lengthColumnas; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Número de la columna N°: {i + 1}");
    double suma = 0;

    //recorremos las filas
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine();
        Console.WriteLine($"Cargue N° {j + 1}:");
        numeros[j, i] = int.Parse(Console.ReadLine());
        suma += numeros[j, i];
        Console.WriteLine($"El N° de la fila {j + 1} y columna {i + 1} es:{numeros[j, i]}");
    }
    promedios[i] = suma / cantidadFilas;
}
Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();

//for (int i = 0; i < cantidadColumnas; i++)
//{
//    for (int j = 0; j < cantidadFilas; j++)
//    {
//        Console.WriteLine($"El N° de la fila {j+1} y columna {i + 1} es:{numeros[j,i]}");
//    }
//}

Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();
for (int i = 0; i < cantidadColumnas; i++)
{
    Console.WriteLine($"El promedio de la columna N° {i + 1} es: {promedios[i]}");
}

Console.ReadKey();



//nandooooooooo