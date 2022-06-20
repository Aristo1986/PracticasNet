using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBilletera.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        public decimal Total()
        {
            decimal suma = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
            return suma;
        }

        public Billetera Combinar(Billetera segundaBilletera) //Combina billetera y me devuelve una nueva billetera (b3)
        {
            Billetera nuevaBilletera = new Billetera()
            {

                BilletesDe10 = BilletesDe10 + segundaBilletera.BilletesDe10,
                BilletesDe20 = BilletesDe20 + segundaBilletera.BilletesDe20,
                BilletesDe50 = BilletesDe50 + segundaBilletera.BilletesDe50,
                BilletesDe100 = BilletesDe100 + segundaBilletera.BilletesDe100,
                BilletesDe200 = BilletesDe200 + segundaBilletera.BilletesDe200,
                BilletesDe500 = BilletesDe500 + segundaBilletera.BilletesDe500,
                BilletesDe1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000
            };

             return nuevaBilletera;
        }

        public void Borrado()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }
    }
}
