/*
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, 
      así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/


String[,] carton = new string[9, 3];

int[] cantColum = new int[9];

int[] numInser = new int[9];


Random num = new Random();

Random pos = new Random();


int lengthColumna = carton.GetUpperBound(0) + 1;// Obtener la dimension

int lengthFila = carton.GetUpperBound(1) + 1;//Se le pasa el indice de la dimension


int num2;

int num3;


for (int fila = 0; fila < lengthFila; fila++)      //Recorro las filas (3) cuando lleno las columnas

{

    int min = 0;    // Variable para incrementar el minimo en 10

    int max = 10;   // Variable para incrementar el maximo en 10


    for (int columna = 0; columna < lengthColumna; columna++) // Recorro las columnas (9)

    {

        num3 = num.Next(min, max); // Coloco las variables min y max en la funcion random para que me de un numero aleatorio en ese rango

        for (int i = 0; i < numInser.Length; i++)   //Recorro el vector auxiliar para verificar si el numero ya fue utilizado

        {

            while (numInser[i] == num3)             //Verifico que no se repita este nuevo numero

            {

                num3 = num.Next(min, max);

                for (int j = 0; j < numInser.Length; j++)

                {

                    if (numInser[i] == num3) num3 = num.Next(min, max);



                }

            }

        }

        carton[columna, fila] = Convert.ToString(num3); // Guardo el numero obtenido en forma de string

        numInser[columna] = num3;   // Guardo el numero obtenido en el vector auxiliar para posteriormente usarlo para el control

        min += 10;  //Incremento en 10 la variabla para pasar al nuevo rango

        max += 10;  //Incremento en 10 la variabla para pasar al nuevo rango

    }

}


for (int i = 0; i < lengthColumna - 5; i++) // Recorre la columna

{

    for (int j = 0; j < lengthFila; j++) // Recorre la fila

    {

        num2 = pos.Next(0, 3);  //Genero una posicion aletoria

        while (carton[num2, j] == "  " || cantColum[num2] > 1)     // Controlo que en la posicion no haya un blanco o que en la columana no haya mas de 2 blancos

        {

            num2 = pos.Next(9);  //Genero una nueva posicion aleatoria  

        }

        carton[num2, j] = "  "; //Se guarda un blanco en la posicion aleatoria

        cantColum[num2] += 1; // Se suma 1 en el contador del vector auxiliar

    }

}


for (int fila = 0; fila < lengthFila; fila++) // Recorre las filas

{

    Console.WriteLine();

    for (int columna = 0; columna < lengthColumna; columna++)// Recorre las columnas

    {

        if (columna == 0 && carton[columna, fila] != "  ")

            Console.Write($" | 0{carton[columna, fila]}");// Muestra lo guardado en la posicion recorrida

        else

            Console.Write($" | {carton[columna, fila]}");// Muestra lo guardado en la posicion recorrida

    }

}