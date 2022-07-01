using clase14ejercicio.modelo;

Baraja baraja = new Baraja();

for (int i = 0; i < baraja.baraja.Length; i++)
{
    Carta carta = new Carta();
    Random randpalo = new Random();
    Random randnumero = new Random();
    int numcarta = randnumero.Next(1, 13);
    while (numcarta == 8 || numcarta == 9)
    {
        numcarta = randnumero.Next(1, 13);
    }
    int palocarta = randpalo.Next(4);
    switch (palocarta)
    {
        case 0:
            carta.palo = "Espada";
            carta.numero = numcarta;
            baraja.baraja[i] = carta;
            break;
        case 1:
            carta.palo = "Basto";
            carta.numero = numcarta;
            baraja.baraja[i] = carta;
            break;
        case 2:
            carta.palo = "Oro";
            carta.numero = numcarta;
            baraja.baraja[i] = carta;
            break;
        case 3:
            carta.palo = "Copa";
            carta.numero = numcarta;
            baraja.baraja[i] = carta;
            break;
    }

}



for (int i = -1; i < baraja.baraja.Length; i++)
{
    Console.WriteLine("Ingrese la opcion a realizar");
    Console.WriteLine("1_Barajar\n2_Mostrar siguiente carta\n3_Mostrar cartas disponibles\n4_Dar cartas\n5_Mostrar cartas del monton\n6_Mostrar baraja\n7_Salir");
    int respuesta = int.Parse(Console.ReadLine());
    switch (respuesta)
    {
        case 1:
            baraja.Barajar(i);
            i--;
            break;
        case 2:
            baraja.SiguienteCarta(i);
            i--;
            break;
        case 3:
            baraja.CartasDisponibles(i);
            i--;
            break;
        case 4:
            Console.WriteLine("\n\nCuantas cartas desea?");
            int cantidad = int.Parse(Console.ReadLine());
            i = baraja.DarCartas(cantidad, i);
            break;
        case 5:
            baraja.CartasMonton(i);
            i--;
            break;
        case 6:
            baraja.MostrarBaraja(i);
            i--;
            break;
        default:
            Environment.Exit(1);
            break;
    }

}

