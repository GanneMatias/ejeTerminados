/*Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.*/



int[] numero = new int[5];
double suma=0;
double promedio = 0;
//Ingreso de numero y suma de numeros ingresados
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el numero: {i + 1}");
    numero[i]=int.Parse(Console.ReadLine());
    suma += numero[i];
}

Console.Clear();
Console.WriteLine("Resultado de actividad\n");
//imprime el resultado de la suma
Console.WriteLine($"Inciso 2-> Suma total: {suma}");


//Se obtiene el mayor y el menor numero
int mayor = 0, menor = 0;
menor = numero[0];//Inicializo en el primer elemento asi puede comparar

for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] > mayor)
    {
        //Console.WriteLine($"el numero {numero[i]} es mayor que {mayor}");
        mayor = numero[i];
    }
    else if (numero[i] < menor)
    {
        //Console.WriteLine($"el numero {numero[i]} es menor que {menor}");
        menor = numero[i];
    }
}

//Imprime mayor y menor
Console.WriteLine($"Inciso 3-> El numero MAYOR es:{mayor}");
Console.WriteLine($"Inciso 4-> El numero MENOR es:{menor}");

//calculo el promedio
promedio = suma / numero.Length;
Console.WriteLine($"Inciso 5-> Promedio es: {promedio}");

//Lectura de numeros ingresados
Console.WriteLine("Inciso 6-> Numeros ingresados:");
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"\t   {i + 1}° numero es :{numero[i]}");
}
