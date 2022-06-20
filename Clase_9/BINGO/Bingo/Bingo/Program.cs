var genRandom = new Random(DateTime.Now.Millisecond);

var carton = new int[3, 9];

//Generamos lo números para el cartón
for (int c = 0; c < 9; c++)
{
    for (int f = 0; f < 3; f++)
    {
        int nuevoNumero = 0;
        bool encontreUnoNuevo=false;
        while (!encontreUnoNuevo)
        {
            if (c == 0) //columna 0
            {
                nuevoNumero = genRandom.Next(1, 10);   //1 al 9

            }
            else if (c == 8)    //columna 9
            {
                nuevoNumero = genRandom.Next(80, 91);   //80 al 90

            }
            else                //todas las demas columnas
            {
                nuevoNumero = genRandom.Next(c * 10, c * 10 + 10);   //
            }

            //Buscamos si el nuevoNumero existe en la columna
            var esNuevo = false;
            for (int f2 = 0; f2 < 3; f2++)
            {
                if  (carton[f2,c] == nuevoNumero)
                {
                    encontreUnoNuevo = false;
                    break;
                }
            }
            //Si salio del bucle y no encontro repetidos,
            //encontreUnoNuevo=true y sale del bucle
        }

        carton[f,c] = nuevoNumero;
    }
}

//mostramos el cartón en pantalla

Console.WriteLine("--------------------------------------------------------");
for (int f = 0; f < 3; f++)
{
    for (int i = 0; i < length; i++)
    {

    }

}