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

// Ejercicio 3 

double numero;
string input;

// Pedir al usuario un número válido
do
{
    Console.Write("Ingrese un número: ");
    input = Console.ReadLine();

    if (!double.TryParse(input, out numero))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
    }

} while (!double.TryParse(input, out numero));

// Menú de opciones
Console.WriteLine("\nSeleccione una operación:");
Console.WriteLine("1. Valor absoluto");
Console.WriteLine("2. Cuadrado");
Console.WriteLine("3. Raíz cuadrada");
Console.WriteLine("4. Seno");
Console.WriteLine("5. Coseno");
Console.WriteLine("6. La parte entera de un tipo float");
Console.Write("Opción (1-6): ");

string opciones = Console.ReadLine();

// Ejecutar operación
switch (opciones)
{
    case "1":
        Console.WriteLine($"Valor absoluto de {numero} es: {Math.Abs(numero)}");
        break;
    case "2":
        Console.WriteLine($"Cuadrado de {numero} es: {Math.Pow(numero, 2)}");
        break;
    case "3":
        if (numero >= 0)
        {
            Console.WriteLine($"Raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
        }
        else
        {
            Console.WriteLine($"La raíz cuadrada no esta definida para números negativos como {numero}.");
        }
        break;
    case "4":
        Console.WriteLine($"El Seno de {numero} es: {Math.Sin(numero)}");
        break;
    case "5":
        Console.WriteLine($"El Coseno de {numero} es: {Math.Cos(numero)}");
        break;
    case "6":
        Console.WriteLine($"La parte entera de {numero} es: {Math.Truncate(numero)}");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

// Segunda parte: Solicitar dos números para comparar
double numero1, numero2;
string entrada1, entrada2;

Console.WriteLine("\nAhora ingrese dos números para comparar:");

// Primer número
do
{
    Console.Write("Ingrese el primer número: ");
    entrada1 = Console.ReadLine();

    if (!double.TryParse(entrada1, out numero1))
    {
        Console.WriteLine("Entrada no válida. Intente nuevamente.");
    }

} while (!double.TryParse(entrada1, out numero1));

// Segundo número
do
{
    Console.Write("Ingrese el segundo número: ");
    entrada2 = Console.ReadLine();

    if (!double.TryParse(entrada2, out numero2))
    {
        Console.WriteLine("Entrada no válida. Intente nuevamente.");
    }

} while (!double.TryParse(entrada2, out numero2));

// Menú de comparación
Console.WriteLine("\nSeleccione qué desea ver:");
Console.WriteLine("1. Máximo");
Console.WriteLine("2. Mínimo");
Console.WriteLine("3. Ambos");
Console.Write("Opción (1-3): ");
string opcionComparacion = Console.ReadLine();

switch (opcionComparacion)
{
    case "1":
        Console.WriteLine($"Máximo: {Math.Max(numero1, numero2)}");
        break;
    case "2":
        Console.WriteLine($"Mínimo: {Math.Min(numero1, numero2)}");
        break;
    case "3":
        Console.WriteLine($"Máximo: {Math.Max(numero1, numero2)}");
        Console.WriteLine($"Mínimo: {Math.Min(numero1, numero2)}");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}


