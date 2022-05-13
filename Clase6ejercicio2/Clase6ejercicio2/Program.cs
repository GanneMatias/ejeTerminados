//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

//Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.


int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

int contador= 0;
int bandera = 999;

do
{
    Console.WriteLine("Ingrese un numero:");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numeroSecreto)
    {
        Console.WriteLine($"\nEl numero {numero1} es mayor que el numero secreto.\nIntente de adivinar de nuevo\n");
        bandera = 0;
    }
    else if (numero1 < numeroSecreto)
    {
        Console.WriteLine($"\nEl numero {numero1} es menor que el numero secreto.\nIntente de adivinar de nuevo\n");
        bandera = 0;
    }
    else
    {
        Console.WriteLine($"\n\tFelicitaciones, has adivinado el numero secreto que era : {numeroSecreto}");
        Console.WriteLine($"\n\tLo has logrado con {contador} intentos!!");
        bandera = 999;
    }

    contador++;
} while (bandera != 999);


