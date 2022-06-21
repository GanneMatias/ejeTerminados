using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13ejercicio.Modelo
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
            decimal total=0;
            total = ((BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000));
            return total;
        }

        public void MostrarBilletes()
        {
            Console.WriteLine("BILLETES:\nmonto:cantidad");
            Console.WriteLine($"10: {BilletesDe10}\n20: {BilletesDe20}\n50: {BilletesDe50}\n100: {BilletesDe100}\n200: {BilletesDe200}\n500: {BilletesDe500}\n1000: {BilletesDe1000}");
        }

        public void Vaciar()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

        public Billetera Combinar(Billetera combinar)
        {
            Billetera combinada = new Billetera();

            combinada.BilletesDe10 = BilletesDe10 + combinar.BilletesDe10;
            combinada.BilletesDe20 = BilletesDe20 + combinar.BilletesDe20;
            combinada.BilletesDe50 = BilletesDe50 + combinar.BilletesDe50;
            combinada.BilletesDe100 = BilletesDe100 + combinar.BilletesDe100;
            combinada.BilletesDe200 = BilletesDe200 + combinar.BilletesDe200;
            combinada.BilletesDe500 = BilletesDe500 + combinar.BilletesDe500;
            combinada.BilletesDe1000 = BilletesDe1000 + combinar.BilletesDe1000;
            this.Vaciar();
            combinar.Vaciar();
            return combinada;
        }
    }
}
    

