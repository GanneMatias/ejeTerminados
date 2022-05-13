//escribir un programa que haga lo siguiente:

//1) borrar la pantalla.
//2) pedir el nombre de una persona.
//3) saludarlo con un texto que diga "¡hola [nombreingresado]!"
//4) preguntar si se quiere continuar.
//5) si la respuesta es "s" repetir desde el punto 1.
//6) si la respuesta es "n" finalizar el
//programa mostrando un mensaje que diga "programa
//finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien
//finalice el programa, pero mostrando un mensaje que diga
//"Opcion no valida".

string Respuesta = "S";

while (Respuesta.ToUpper() != "N")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre:");
    var nombre = Console.ReadLine();
    Console.Clear();

    Console.WriteLine($"\n\t¡Hola {nombre}!\n");
    
    Console.WriteLine("\tDesea continuar");
    Console.WriteLine("\t<S> para si \n\t<N> para no");
    Respuesta = Console.ReadLine();
    

    if (Respuesta.ToUpper() == "N")
    {
        Console.Clear();
        Console.WriteLine(">programa finalizado correctamente<");
    }
    else if(Respuesta.ToUpper() != "N" && Respuesta.ToUpper() != "S")
    {
        Console.WriteLine("\nOpcion no valida");
        Console.WriteLine("Por favor, Ingrese <S> o <N> \n");
        Console.ReadKey();
    } 

}

