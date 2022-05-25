/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.WriteLine("Ingrese cantidad las filas");
int CantidadFilas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad las columnas");
int CantidadColumnas = int.Parse(Console.ReadLine());
Console.Clear();

int [,] numeros = new int[CantidadFilas, CantidadColumnas];
double[] promedio = new double[CantidadColumnas];


for (int fila = 0; fila < CantidadFilas; fila++)
{
    for (int columna = 0; columna < CantidadColumnas; columna++)
    {
        Console.WriteLine($"Ingrese el valor en la posicion:[F{fila + 1 }][C{columna + 1}]");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}
Console.Clear();
Console.WriteLine();
for (int fila = 0; fila < CantidadFilas; fila++)
{
    for (int columna = 0; columna < CantidadColumnas; columna++)
    {
        Console.Write($"\t{numeros[fila, columna]} ");
    }
    Console.WriteLine();
}


for (int columna = 0; columna < CantidadColumnas; columna++)
{
    double suma = 0;
    Console.WriteLine($"\nColumna:[{columna + 1 }]");
    for (int fila = 0; fila < CantidadFilas; fila++)
    {
        //promedio[columna] += numeros[fila, columna]; otra forma
        suma+= numeros[fila, columna];
        promedio[columna] = suma;
    }
    //suma = promedio[columna];
    //Console.WriteLine($"suma = {suma}");
    promedio[columna] /= CantidadFilas;
    Console.WriteLine($"promedio = {promedio[columna]}");
}

Console.WriteLine("\nLista de promedios:");
for (int i = 0; i < promedio.Length; i++)
{
    Console.WriteLine($"promedio N°{i+1} = {promedio[i]}");
}
