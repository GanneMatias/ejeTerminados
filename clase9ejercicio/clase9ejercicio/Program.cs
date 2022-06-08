/*
1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, 
        el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 
        10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.Se debe usar solo lo visto en clase
        hasta ahora y no los métodos que trae C# para estas cuestiones.
6)      Mostrar el vector nuevamente.
*/

Console.WriteLine("Ingrese el tamaño del vector[]:");
int longitudVector= int.Parse(Console.ReadLine());
int[] vector = new int[longitudVector];

Random datoAleatorio = new Random();   

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = datoAleatorio.Next(1,100);
}

var contador = 0;
Console.WriteLine("NORMAL:");
foreach (var i in vector)
{
    contador++;
    Console.Write($"{i} ");
}

var aux = 0;
for (int i = 0; i < (vector.Length)/2; i++)
{
    //aux = vector[i];
    //vector[i]=vector[(vector.Length-1)-i];
    //vector[(vector.Length - 1) - i] =aux;
    aux = vector[i];
    vector[i] = vector[contador - 1-i];
    vector[contador - 1-i] = aux;
    /*12345
    aux = 1   	aux = 2		aux = 	3	aux = 4		aux = 5 
    v1[0]=5	  	v1[1]= 4	1[2]= 	3	v1[3]=2 	v1[4]=1	
    V1[c-1-i]=1	V1[c-1-i]=2	V1[c-1-i]=3	V1[c-1-i]=4	V1[c-1-i]=5    
     */
}

Console.WriteLine("\nInvertido:");
foreach (var i in vector)
{
    Console.Write($"{i} ");
}