// Codigo de Pruebas

/*

Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

*/

// Codigo Ejercicio 1

/* 

int numero;

Console.WriteLine("Ingresa un numero: ");
string NumeroPalabra = Console.ReadLine();

if (int.TryParse(NumeroPalabra, out numero))
{

    if (numero > 0)
    {

        char[] caracteres = numero.ToString().ToCharArray(); // convierto el numero primero a cadena de texto y luego a array
        Array.Reverse(caracteres); // invierto el array

        string NumeroInvertido = new string(caracteres);
        Console.WriteLine("El numero ya invertido es: " + NumeroInvertido);

    }
    else
    {

        Console.WriteLine("El numero debe ser mayor que 0 para invertir");

    }

}
else
{

    Console.WriteLine("Lo ingresado no es un numero");

}

*/

