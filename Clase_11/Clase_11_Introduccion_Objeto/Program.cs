

namespace IntroObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intancia 1
            Perro firulais = new Perro();
            firulais.Color = "Negro";
            firulais.Edad = "4";
            firulais.Tamanio = "Grande";
            firulais.Raza = "Mastin Napolitano";

            //Intancia 2
            Perro fatiga = new Perro();
            fatiga.Color = "Blanco";
            fatiga.Edad = "2";
            fatiga.Tamanio = "Chico";
            fatiga.Raza = "Maltes";

            //Intancia 3
            Perro cartucho = new Perro();
            cartucho.Color = "Negro";
            cartucho.Edad = "3";
            cartucho.Tamanio = "Medio";
            cartucho.Raza = "Chow Chow";

            //Lista de perros
            var perritos=new List<Perro>();

            perritos.Add(firulais);
            perritos.Add(fatiga);
            perritos.Add(cartucho);


            //Console.WriteLine(firulais.Raza);
            //Console.WriteLine(fatiga.Raza);
            //Console.WriteLine(cartucho.Raza);

            Console.WriteLine($"Hay {perritos.Count()} perritos en la lista");
            foreach (var item in perritos)
            {
                Console.Write(item.Raza+" -> ");
                item.Ladrar();
            }

        }
    }
}

namespace IntroObjetos
{
    public class Perro
    {
        //Campos-Fields
        public string Raza;

        public string Tamanio;

        public string Edad;

        public string Color;

        public void Ladrar()
        {
            Console.WriteLine("Guau");
        }
    }
}



// cual es la diferencia entre instancia y clase