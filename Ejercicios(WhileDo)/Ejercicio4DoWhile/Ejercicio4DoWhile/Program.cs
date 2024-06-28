// See https://aka.ms/new-console-template for more information
double suma = 0;
int contador = 0;
double numero;

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
Console.WriteLine($"La cantidad de los números ingresados es {contador} y su suma es {suma}");