// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresar los 8 números");
double n;
double suma = 0;
for (int i = 0; i <= 8; i++)
{
    Console.Write($"El valor inresado es: {i}");
    if (!Double.TryParse(Console.ReadLine(), out n))
    {
        suma += n;
    }
    else
    {
        Console.WriteLine("Debe ingresar un número");
        i--;
    }
}
double promedio = suma / 8;
Console.WriteLine($"El promedio de los números es; {promedio}" );