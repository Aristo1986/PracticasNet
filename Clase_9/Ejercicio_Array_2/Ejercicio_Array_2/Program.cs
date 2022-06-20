int[] primos = new int[10];

int posicion= 0;
int aux = 0;
int numero = 1;

while (posicion < primos.Length)
{
    aux = 0;
    for (var i=0; i<=numero; i++)
    {
        if (numero % i == 0)
        {
            aux++;
        }
        
    }
    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;
}

foreach(var i in primos)
{
    Console.WriteLine
}
// el tipo de datos lo damos entre comillas angulares <"tipoDeDato">