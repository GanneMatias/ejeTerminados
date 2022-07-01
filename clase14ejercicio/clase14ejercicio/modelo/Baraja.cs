using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase14ejercicio.modelo
{
    internal class Baraja
    {
        static int y = 40;
        public Carta[] baraja = new Carta[y];


        public void Barajar(int i)
        {
            Carta[] mezclador = new Carta[y];
            for (int t = i + 1; t < y; t++)
            {
                Random j = new Random();
                int x = j.Next((i + 1), y);
                while (mezclador[x] != null)
                {
                    x = j.Next((i + 1), y);
                }

                mezclador[x] = baraja[t];
            }
            for (int t = i + 1; t < y; t++)
            {
                baraja[t] = mezclador[t];
            }
        }

        public void SiguienteCarta(int i)
        {
            if (i == y - 1)
            {
                Console.WriteLine("No hay mas cartas");
            }
            else
            {
                Console.WriteLine($"La siguiente carta es:  {baraja[i + 1].numero} de {baraja[i + 1].palo}\n\n");
            }
        }

        public void CartasDisponibles(int i)
        {
            int restantes = (y - 1) - i;
            Console.WriteLine($"Quedan {restantes} cartas restantes");
        }

        public int DarCartas(int cantidad, int i)
        {
            if (cantidad + i >= y)
            {
                Console.WriteLine("Hay menos cartas que la cantidad ingresada");
                return i = i - 1;
            }
            Console.WriteLine($"Se entregaron {cantidad} cartas al usuario");
            return i += cantidad - 1;
        }

        public void CartasMonton(int i)
        {
            if (i == -1)
            {
                Console.WriteLine("Todavia no ha salido ninguna carta");
            }
            else
            {
                Console.WriteLine("Las Cartas del monton son:\n");
                for (int j = i; j >= 0; j--)
                {

                    Console.WriteLine($"{baraja[j].numero} de {baraja[j].palo}");
                }
            }
        }

        public void MostrarBaraja(int i)
        {
            if (i == y - 1)
            {
                Console.WriteLine("No hay mas cartas en la baraja");
            }
            else
            {
                Console.WriteLine("Las cartas de la baraja son:\n");
                for (int j = i + 1; j < y; j++)
                {
                    Console.WriteLine($"{baraja[j].numero} de {baraja[j].palo}");
                }
            }
        }


    }
}
