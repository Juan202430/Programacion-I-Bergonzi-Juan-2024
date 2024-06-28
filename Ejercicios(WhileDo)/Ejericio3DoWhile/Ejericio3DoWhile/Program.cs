// See https://aka.ms/new-console-template for more information
int limite = 0;
double numero;
double promedio = 0;
double suma = 0;
int contador = 0;

do
{
    Console.Write("Por favor, ingrese un número: ");
    if (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Ingreso inválido. Por favor, ingrese un número válido.");
    }

    if (numero >= limite)
    {
        Console.WriteLine("El número ingresado es positivo.");
    }
    else
    {
        Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
        suma += numero;
        contador++;

    }
} while (numero < limite);
promedio = suma / contador;
Console.WriteLine($"La cantidad de los números negativos ingresado es {contador}, su suma es {suma} y su promedio es, {promedio}");