using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartasEspañolas.Modelos
{
    internal class Baraja
    {
        public Array Basto { get; set; }
        public Array Oro { get; set; }
        public Array Espada { get; set; }
        public Array Copa { get; set; }

        public Array GeneracionDePalo() //Metodo para crear un array "palo" con 10 cartas, sin 8 ni 9
        {
            int[] palo = new int[10];
            for (int i = 0; i < palo.Length; i++)
            {
                if (i < 7)
                    palo[i] = i + 1;         //el numero de la posicion 0=1 para que quede acorde a los n° de cartas

                else
                    palo[i] = i + 3;         //a la posición 7(n°8) se le suma 3 numeros para que quede en 10
            }
            return palo;
        }
        /* Aca ya tengo ya tendríamos las 10 cartas por palo*/

        public Array Barajar()      //Creo un método llamado "Barajar" que me devuelve un array
        {
            string[] mazoBarajado = new string[40];       //Creo un array llamado "mazoBarajado" de extensión del mazo

            Basto = GeneracionDePalo();     //al atributo del array le asigo 10 valores a traves del metodo
            Oro = GeneracionDePalo();
            Espada = GeneracionDePalo();
            Copa = GeneracionDePalo();

            Random var = new Random();

            var cont = 0;
            for (int i = 0; i < mazoBarajado.Length; i++)
            {
                int pos = var.Next(0, 40);          //genero numero aleatorio de posicion
                while (mazoBarajado[pos] != null)      //bucle para validar si la posicion oleatoria no fue ocupada
                {
                    pos = var.Next(0, 40);
                }

                if (cont == 10)     //reseteo la catidad de carta para pasar al siguiente palo
                {
                    cont = 0;
                }

                if (i < 10)
                {
                    mazoBarajado[pos] = $"{(int)Basto.GetValue(cont)}_B";
                    cont++;
                }
                else if (i > 9 && i < 20)
                {

                    mazoBarajado[pos] = $"{(int)Oro.GetValue(cont)}_O";
                    cont++;
                }
                else if (i > 19 && i < 30)
                {

                    mazoBarajado[pos] = $"{(int)Espada.GetValue(cont)}_E";
                    cont++;
                }
                else if (i > 29 && i < 40)
                {

                    mazoBarajado[pos] = $"{(int)Copa.GetValue(cont)}_C";
                    cont++;
                }
            }
            return mazoBarajado;
        }

        public string SiguienteCarta(Array maso, int posicion, out int posicionProxima)
        {
            Array baraja = maso;        //creo la variable array y le asigno el valor del array maso

            string siguienteCarta = (string)baraja.GetValue(posicion);  //creo la variable donde guardo sig carta y le asigno el valor (string) que ocupa la posicion que le paso
            posicionProxima = posicion + 1;

            return siguienteCarta;
        }

        public int CartasDisponibles(Array maso, int posicion)
        {
            int cantidad = 0;
            Array baraja = maso;
            cantidad = baraja.Length - posicion;
            return cantidad;
        }

        public Array DarCartas(Array maso, int posicion, int cantidad, out int proxima)
        {
            Array baraja = maso;
            int cant = cantidad; // Cantidad de cartas solicitadas
            string[] cartas = new string[cant]; //array de las cartas que te van a dar

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = (string)baraja.GetValue(posicion);  //le asigno el valor de la posicion a la carta
                posicion++;
            }
            proxima = posicion;

            return cartas;
        }

        public Array CartasMonton(Array maso, int posicion)
        {
            string[] monton = new string[posicion];
            if (posicion == 0)
                Console.WriteLine("- De momento no se asignaron cartas al monton");
            else
            {
                for (int i = 0; i < monton.Length; i++)
                {
                    monton[i] = (string)maso.GetValue(i);
                }
            }
            return monton;
        }

        public Array MostrarBaraja(Array maso, int posicion)
        {
            string[] barajaMostrar = new string[maso.Length - posicion];
            for (int i = 0; i < barajaMostrar.Length; i++)
            {
                barajaMostrar[i] = (string)maso.GetValue(i + posicion);
            }
            return barajaMostrar;
        }

    }
}
