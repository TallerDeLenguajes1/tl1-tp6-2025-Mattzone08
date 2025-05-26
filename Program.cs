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

string opcion = Console.ReadLine();

// Ejecutar operación
switch (opcion)
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


