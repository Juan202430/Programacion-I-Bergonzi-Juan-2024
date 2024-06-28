// See https://aka.ms/new-console-template for more information
double suma = 0;
int contador = 0;
double numero;
double promedio = 0;

Console.WriteLine("Ingresar un número mayor a 3 cifras para terminar.");

do
{
    Console.Write("Por favor, ingrese un número: ");
    if (!Double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
    {
        Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
    }
    else
    {
        suma += numero;
        contador++;
    }
} while (numero < 100);
promedio = suma / contador;
Console.WriteLine($"La cantidad de los números ingresados es {contador}, su suma es {suma} y su promedio es {promedio}");