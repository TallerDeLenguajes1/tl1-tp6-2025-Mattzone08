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

// Ejercicio 4

// 1. Ingreso y longitud de cadena
Console.Write("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine($"Longitud: {cadena1.Length}");

// 2. Concatenar con segunda cadena
Console.Write("Ingrese una segunda cadena: ");
string cadena2 = Console.ReadLine();
string concatenada = string.Concat(cadena1, cadena2);
Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// 3. Extraer subcadena
Console.Write("Ingrese el índice de inicio para la subcadena: ");
int inicio = int.Parse(Console.ReadLine());
Console.Write("Ingrese la longitud de la subcadena: ");
int largo = int.Parse(Console.ReadLine());
Console.WriteLine($"Subcadena: {cadena1.Substring(inicio, largo)}");

// 4. Mostrar operación matemática como texto
Console.Write("Ingrese un número: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese otro número: ");
double num2 = double.Parse(Console.ReadLine());
double suma = num1 + num2;
Console.WriteLine($"La suma de {num1} y de {num2} es igual a: {suma.ToString()}");

// 5. Recorrer cadena con foreach
Console.WriteLine("Caracteres de la primera cadena:");
foreach (char c in cadena1)
{
    Console.WriteLine(c);
}

// 6. Buscar palabra
Console.Write("Ingrese palabra a buscar: ");
string palabra = Console.ReadLine();
bool encontrada = cadena1.Contains(palabra);
Console.WriteLine(encontrada ? "Palabra encontrada." : "Palabra no encontrada.");

// 7. Mayúsculas y minúsculas
Console.WriteLine($"En mayúsculas: {cadena1.ToUpper()}");
Console.WriteLine($"En minúsculas: {cadena1.ToLower()}");

// 8. Separar cadena por carácter
Console.Write("Ingrese una cadena separada por un carácter (ej: uno-dos-tres): ");
string separada = Console.ReadLine();
Console.Write("Ingrese el carácter separador (ej: -): ");
char separador = char.Parse(Console.ReadLine());
string[] partes = separada.Split(separador);
Console.WriteLine("Partes:");
foreach (var parte in partes)
{
    Console.WriteLine(parte);
}

// 9. Resolver ecuación simple tipo “58+2”
Console.Write("Ingrese una ecuación simple (por ejemplo 58+2): ");
string ecuacion = Console.ReadLine();
char[] operadores = { '+', '-', '*', '/' };
char operador = '\0';
foreach (char op in operadores)
{
    if (ecuacion.Contains(op))
    {
        operador = op;
        break;
    }
}
if (operador != '\0')
{
    string[] nums = ecuacion.Split(operador);
    double a = double.Parse(nums[0]);
    double b = double.Parse(nums[1]);
    double resultado = operador == '+' ? a + b :
                       operador == '-' ? a - b :
                       operador == '*' ? a * b :
                       b != 0 ? a / b : double.NaN;
    Console.WriteLine($"Resultado: {resultado}");
}
else
{
    Console.WriteLine("Operador no válido.");
}