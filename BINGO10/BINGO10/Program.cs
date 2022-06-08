/*
 Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19,
      la tercera del 20 al 29, así sucesivamente hasta la última columna la cual 
      contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/


//agregar que no sean iguales solamente y quizas las otras condiciones para que se ponga un numero mayor

int[,] carton = new int[3, 9]; //[filas, columnas]

Random aleatorio = new Random();

int numA = 0;
int contcero = 0;
int b1 = 0;

/*int control2 = 0;
int control = 0;
int salidaC = 0;
int salidaB = 0;*/


int contadorespacios=0;
int contadornumeros=0;

    for (int fila = 0; fila < 3; fila++)
{
    contcero = 0;
    b1 = 0;
    for (int columna = 0; columna < 9; columna++)
    {
        
            switch (columna)
            {
                case 0:
                    if(carton[0 , columna]==0 && carton[1 , columna]==0)
                    {
                        carton[fila, columna] = aleatorio.Next(1, 10);
                        b1++;
                    }
                    else if(carton[0, columna]>0 && carton[1, columna]>0)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;

                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(1, 10);
                            b1++;
                        }
                    }
                    
                    break;

                case 1:
                    if (carton[0, columna] == 0 && carton[1, columna] == 0)
                    {
                        carton[fila, columna] = aleatorio.Next(10, 20);
                        b1++;
                    }
                    else if (carton[0, columna] > 0 && carton[1, columna] > 0)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;

                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(10, 20);
                            b1++;
                        }
                    }

                    break;

            case 2:

                if (carton[0, columna] == 0 && carton[1, columna] == 0)
                {
                    carton[fila, columna] = aleatorio.Next(20, 30);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0)
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(20, 30);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(20, 30);
                            b1++;
                        }
                    }
                }

                break;

            

            case 3:

                if (carton[0, columna] == 0 && carton[1, columna] == 0)
                {
                    carton[fila, columna] = aleatorio.Next(30, 40);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0)
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(30, 40);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(30, 40);
                            b1++;
                        }
                    }
                }

                break;
            

            case 4:
                if (carton[0, columna] == 0 && carton[1, columna] == 0 && b1 != 5)
                {
                    carton[fila, columna] = aleatorio.Next(40, 50);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0 && contcero != 4 )
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(40, 50);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(40, 50);
                            b1++;
                        }
                    }
                }

                break;
            

            case 5:
                if (carton[0, columna] == 0 && carton[1, columna] == 0 && b1 != 5)
                {
                    carton[fila, columna] = aleatorio.Next(50, 60);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0 && contcero != 4 )
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(50, 60);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(50, 60);
                            b1++;
                        }
                    }
                }

                break;
            

            case 6:
                if (carton[0, columna] == 0 && carton[1, columna] == 0 && b1 != 5)
                {
                    carton[fila, columna] = aleatorio.Next(60, 70);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0 && contcero != 4 )
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(60, 70);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(60, 70);
                            b1++;
                        }
                    }
                }

                break;
            

            case 7:
                if (carton[0, columna] == 0 && carton[1, columna] == 0 && b1 != 5)
                {
                    carton[fila, columna] = aleatorio.Next(70, 80);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0 && contcero!=4)
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(70, 80);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                    else
                    {
                        numA = aleatorio.Next(2);
                        if (numA == 0)
                        {
                            carton[fila, columna] = 0;
                            contcero++;
                        }
                        else
                        {
                            carton[fila, columna] = aleatorio.Next(70, 80);
                            b1++;
                        }
                    }
                }

                break;
            

            case 8:
                if (carton[0, columna] == 0 && carton[1, columna] == 0 && b1!=5)
                {
                    carton[fila, columna] = aleatorio.Next(80, 90);
                    b1++;
                }
                else if (carton[0, columna] > 0 && carton[1, columna] > 0 && contcero!=4)
                {
                    carton[fila, columna] = 0;
                    contcero++;
                }
                else
                {
                    if (contcero == 4)
                    {
                        carton[fila, columna] = aleatorio.Next(80, 90);
                        b1++;
                    }
                    else if (b1 == 5)
                    {
                        carton[fila, columna] = 0;
                        contcero++;
                    }
                }

                break;
                
            }
        
        
    }    
}






for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 9; columna++)
    {
        Console.Write($"{carton[fila, columna]}\t");
    }
    Console.WriteLine();
}


for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 9; columna++)
    {
        if (carton[fila, columna] == 0)
        {
            contadorespacios++;
        }
        else
        {
            contadornumeros++;
        }

    }
}


Console.Write($"espacios:{contadorespacios}\t numeros{contadornumeros}");