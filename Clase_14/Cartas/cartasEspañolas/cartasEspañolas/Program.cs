using cartasEspañolas.Modelos;

int opcion, posicion;
int siguientePosicion = 0;
int cont = 0;


Console.WriteLine("¡Bienvenido a la Baraja Española!");
Baraja nuevaBaraja = new Baraja();      //Creo una instancia (nuevaBaraja) de la clase "Baraja"

/////////////////////////MEZCLO CARTAS ANTES DE INICAR/////////////////////////////////

Array maso = nuevaBaraja.Barajar();     //Creo un array (maso) al que le paso el método Barajar perteneciente a la instancia "nuevaBaraja"


do
{
    Console.WriteLine("\nSeleccione una de las siguientes opciones: \n1 - Barajar \n2 - Mostrar siguiente carta \n3 - Mostrar cartas disponibles \n4 - Dar cartas \n5 - Mostrar cartas del monton \n6 - Mostrar baraja \n7 - Salir");
    Console.Write("Su seleccion es: ");
    opcion = int.Parse(Console.ReadLine());
    while (opcion < 1 || opcion > 7)
    {
        Console.Write("Opcion erronea, favor de seleccion un valor entre 1 y 7: ");
        opcion = int.Parse(Console.ReadLine());
    }

    switch (opcion)     
    {
        case 1:     //usamos método barajar creado por si quiero volver a mezclar
            maso = nuevaBaraja.Barajar();
            cont = 0;
            break;

        case 2:     //Mostrar o repartir siguiente carta
            if (cont == 0)
                posicion = 0;
            
            else
                posicion = siguientePosicion;
            Console.WriteLine($"- La siguiente carta es: {nuevaBaraja.SiguienteCarta(maso, posicion, out siguientePosicion)}");
            posicion = siguientePosicion;
            cont++;
            break;

        case 3:     //Mostrar cartas
            if (cont == 0)
                posicion = 0;
            else
                posicion = siguientePosicion;
            Console.WriteLine($"- La cantidad de cartas disponibles es: {nuevaBaraja.CartasDisponibles(maso, posicion)}");
            break;

        case 4:     //Dar cartas
            var cant = 0;
            Array mano;

            if (cont == 0)
                posicion = 0;
            else
                posicion = siguientePosicion;

            Console.Write("- Cuantas cartas desea dar: ");
            cant = int.Parse(Console.ReadLine());

            mano = nuevaBaraja.DarCartas(maso, posicion, cant, out siguientePosicion);
            posicion = siguientePosicion;
            cont = cont + cant;

            Console.Write("- Las cartas recibidas son: ");
            foreach (string i in mano)
            {
                Console.Write($"| {i} ");
            }
            Console.Write("|");
            break;
        case 5:         //Mostrar cartas del monton
            Array monton;
            if (cont == 0)
                posicion = 0;
            else
                posicion = siguientePosicion;

            monton = nuevaBaraja.CartasMonton(maso, posicion);
            foreach (string i in monton)
            {
                Console.Write($"| {i} ");
            }
            Console.Write("|");
            break;
        case 6:

            Array mostrarBaraja;
            if (cont == 0)
                posicion = 0;
            else
                posicion = siguientePosicion;

            mostrarBaraja = nuevaBaraja.MostrarBaraja(maso, posicion);
            Console.Write("- Las cartas restantes son: ");
            foreach (string i in mostrarBaraja)
            {
                Console.Write($"| {i} ");
            }
            Console.Write("|");
            break;
        case 7:
            Console.WriteLine("¡Hasta luego!");
            break;
    }
    Console.ReadKey();
    Console.Clear();



} while (opcion != 7);


