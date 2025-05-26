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

// Ejercicio 2 



using System.Reflection.Metadata;

string Bandera = "si";

int  opcion, entrada = 0;
float num1, num2, result;
bool entradaValida;

while (Bandera == "si")
{

    if (entrada == 0)
    {

        Console.WriteLine("---------------Bienvenido a la calculadora--------------");
        entrada++;

    }

    Console.WriteLine("Estas son las operaciones para elegir");
    Console.WriteLine("1) Suma ");
    Console.WriteLine("2) Resta ");
    Console.WriteLine("3) Multiplicacion ");
    Console.WriteLine("4) Division ");

    do
    {
        Console.Write("Escriba el número de la operación que desea realizar: ");
        string control = Console.ReadLine();
        entradaValida = int.TryParse(control, out opcion);

        if (!entradaValida)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese solo números.");
        }

    } while (!entradaValida);



    switch (opcion)
    {
        case 1:

            Console.Write("Ingrese el primer numero a sumar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero a sumar: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("La suma de " + num1 + " + " + num2 + " es: " + result);

            break;

        case 2:

            Console.Write("Ingrese el primer numero a restar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero a restar: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 - num2;

            Console.WriteLine("La Resta de " + num1 + " - " + num2 + " es: " + result);

            break;

        case 3:

            Console.Write("Ingrese el primer numero a multiplicar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero a multiplicar: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 * num2;

            Console.WriteLine("La multiplicacion de " + num1 + " x " + num2 + " es: " + result);

            break;

        case 4:

            Console.Write("Ingrese el primer numero a dividir: ");
            num1 = int.Parse(Console.ReadLine());

            do
            {

                Console.Write("Ingrese el segundo numero a dividir (Recuerde que el denominador no puede ser 0): ");
                num2 = int.Parse(Console.ReadLine());

            } while (num2 == 0);

            result = num1 / num2;

            Console.WriteLine("La division de " + num1 + " / " + num2 + " es: " + result);

            break;

        default:

            Console.WriteLine("No ingreso una opcion valida");

            break;
    }


    Console.Write("si desea hacer otra operacion introduzca (si) caso contrario ingrese lo que desee para salir del programa: ");
    Bandera = Console.ReadLine();

}




// Ejercicio 2 



