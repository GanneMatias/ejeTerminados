/*
Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/

using Clase13ejercicio.Modelo;

decimal total=0;

Billetera B1 = new Billetera();
Billetera B2 = new Billetera();

B1.BilletesDe10 = 1;
B1.BilletesDe20 = 2;
B1.BilletesDe50 = 3;
B1.BilletesDe100 = 4;
B1.BilletesDe200 = 5;
B1.BilletesDe500 = 6;
B1.BilletesDe1000 = 7;

total = B1.Total();
Console.WriteLine($"\nEl total de la Billetera 1 es : ${total}\n");

B2.BilletesDe10 = 7;
B2.BilletesDe20 = 6;
B2.BilletesDe50 = 5;
B2.BilletesDe100 = 4;
B2.BilletesDe200 = 3;
B2.BilletesDe500 = 2;
B2.BilletesDe1000 = 1;

total = B2.Total();
Console.WriteLine($"\nEl total de la Billetera 2 es : ${total}\n");


Console.WriteLine("Billeteras combinadas: \n\n");


Billetera billeteracombinar = B1.Combinar(B2);
Console.WriteLine($"Billetera1: {B1.Total()}");
Console.WriteLine($"Billetera2: {B2.Total()}");
Console.WriteLine($"Billetera combinada: {billeteracombinar.Total()}");

Console.WriteLine($"\n\nLos billetes de la billetera combinada son:\n");
billeteracombinar.MostrarBilletes();




