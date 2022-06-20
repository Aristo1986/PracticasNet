using EjercicioBilletera.Modelo;


Billetera[] billeteras = new Billetera[2];

billeteras[0] = new Billetera(); 
billeteras[1] = new Billetera();



Console.WriteLine("CARGA DE BILLETERAS");
Console.WriteLine();

for (int i = 0; i < 2; i++)
{
    //Pido datos al usuario
    Console.WriteLine("========================================================");
    Console.WriteLine($"BILLETERA{i+1}:");
    Console.WriteLine("========================================================");

    Console.WriteLine("Billetes de 10");
    int de10=int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 20");
    int de20 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 50");
    int de50 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 100");
    int de100 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 200");
    int de200 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 500");
    int de500 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Billetes de 1000");
    int de1000 = int.Parse(Console.ReadLine());

    billeteras[i].BilletesDe10 = de10;
    billeteras[i].BilletesDe20 = de20;
    billeteras[i].BilletesDe50 = de50;
    billeteras[i].BilletesDe100 = de100;
    billeteras[i].BilletesDe200 = de200;
    billeteras[i].BilletesDe500 = de500;
    billeteras[i].BilletesDe1000 = de1000;
}
Console.WriteLine("========================================================");
Console.WriteLine("TOTAL EN BILLETERAS");
Console.WriteLine("========================================================");
Console.WriteLine($"el total de la billetera 1 es {billeteras[0].Total()}");
Console.WriteLine($"el total de la billetera 2 es {billeteras[1].Total()}");
Console.WriteLine("========================================================");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Billetera b3 = billeteras[0].Combinar(billeteras[1]);
Console.WriteLine("========================================================");
Console.WriteLine("========================================================");
Console.WriteLine($"el total de la billetera 3 es: {b3.Total()}");

billeteras[0].Borrado();
billeteras[1].Borrado();

Console.WriteLine($"el total de la billetera 1 es {billeteras[0].Total()}");
Console.WriteLine($"el total de la billetera 2 es {billeteras[1].Total()}");
Console.WriteLine("========================================================");
Console.WriteLine("========================================================");

/*
//Creamos la primer billetera
Billetera b1=new Billetera();
b1.BilletesDe10 = 5;
b1.BilletesDe50 = 10;

//Creamos la segunda billetera
Billetera b2 = new Billetera();
b1.BilletesDe10 = 15;
b1.BilletesDe50 = 30;

Billetera b3 = b1.Combinar(b2);
*/