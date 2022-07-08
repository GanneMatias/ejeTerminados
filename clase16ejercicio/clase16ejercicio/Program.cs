using clase16ejercicio.Figuras;
Console.WriteLine("SE NECESITA QUE PONGA LAS COORDENADAS DE LAS SIGUIENTES 3 FIGURAS EN ESTE ORDEN:");
Console.WriteLine("TRAPECIO\nCUADRADO\nRECTANGULO");
int[] x = new int[9];
int[] y = new int[9];
for (int j = 0; j < 9; j++)
{
    if (j < 4)
    {
        if (j < 2)
        {
            if (j == 0)
            {
                Console.WriteLine($"Ingrese la posicion x del punto {j + 1} del lado largo del trapecio  ");
                x[j] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese la posicion y del punto {j + 1} del lado largo del trapecio  ");
                y[j] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"La posicion y del punto {j + 1} sera la misma que el punto anterior, ingrese la coordenada x del otro punto del lado largo del trapecio");
                x[j] = int.Parse(Console.ReadLine());
                y[j] = y[j - 1];
            }
        }
        else
        {
            if (j == 2)
            {
                Console.WriteLine($"Ingrese la posicion x del punto {j + 1} del lado largo del trapecio  ");
                x[j] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese la posicion y del punto {j + 1} del lado largo del trapecio  ");
                y[j] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"La posicion y del punto {j + 1} sera la misma que el punto anterior, ingrese la coordenada x del otro punto del lado largo del trapecio");
                x[j] = int.Parse(Console.ReadLine());
                y[j] = y[j - 1];
            }
        }
    }
    if (j >= 4 && j < 6)
    {
        if (j != 5)
        {
            Console.WriteLine($"Ingrese la posicion x del punto {j - 3} del lado del cuadrado");
            x[j] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese la posicion y del punto {j - 3} del lado del cuadrado");
            y[j] = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine($"La posicion y del punto {j - 3} sera la misma que el punto anterior, ingrese la coordenada x del otro punto del lado del cuadrado ");
            x[j] = int.Parse(Console.ReadLine());
            y[j] = y[j - 1];
        }
    }
    if (j >= 6)
    {
        if (j == 6)
        {
            Console.WriteLine($"Ingrese la posicion x del punto {j - 5} de la base del rectangulo");
            x[j] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese la posicion y del punto {j - 5} de la base del rectangulo");
            y[j] = int.Parse(Console.ReadLine());
        }
        else if (j == 7)
        {
            Console.WriteLine($"La posicion del y del punto {j - 5} sera la misma que el punto anterior, ingrese la coordenada x del otro punto de la base del rectangulo");
            x[j] = int.Parse(Console.ReadLine());
            y[j] = y[j - 1];

        }
        else
        {
            Console.WriteLine($"La posicion x del punto {j - 5} sera la misma que el punto anterior, ingrese la coordenada y para determinar la altura del rectangulo");
            y[j] = int.Parse(Console.ReadLine());
            x[j] = x[j - 1];
        }
    }

}


Console.Clear();
Trapecio trapecio = new Trapecio(x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3]);
Cuadrado cuadrado = new Cuadrado(x[4], y[4], x[5], y[5]);
Rectangulo rectangulo = new Rectangulo(x[6], y[6], x[7], y[7], x[8], y[8]);
Console.WriteLine("TRAPECIO:");
Console.WriteLine($"Punto1:{trapecio.puntox1},{trapecio.puntoy1}\nPunto2:{trapecio.puntox2},{trapecio.puntoy2}\nPunto3:{trapecio.puntox3},{trapecio.puntoy3}\nPunto4:{trapecio.puntox4},{trapecio.puntoy4} ");
Console.WriteLine("CUADRADO:");
Console.WriteLine($"Punto1:{cuadrado.puntox1},{cuadrado.puntoy1}\nPunto2:{cuadrado.puntox2},{cuadrado.puntoy2}");
Console.WriteLine("RECTANGULO");
Console.WriteLine($"Punto1:{rectangulo.puntox1},{rectangulo.puntoy1}\nPunto2:{rectangulo.puntox2},{rectangulo.puntoy2}\nPunto3:{rectangulo.puntox3},{rectangulo.puntoy3}");
trapecio.CalcularArea();
cuadrado.CalcularArea();
rectangulo.CalcularArea();
