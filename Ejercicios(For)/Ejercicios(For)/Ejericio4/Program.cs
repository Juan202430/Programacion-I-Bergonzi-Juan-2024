// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese 8 números:");

double mayor = double.MinValue;

for (int i = 1;i <= 8; i++)
{
    Console.Write($"Número {i}: ");
    if (double.TryParse(Console.ReadLine(), out double numero))
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    else
    {
        Console.WriteLine("Debe ingresar un número");
        i--;
    }
}
Console.WriteLine($"El número más grande es: {mayor}");
