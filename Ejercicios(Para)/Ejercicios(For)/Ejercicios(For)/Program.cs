// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar 5 números enteros: ");

double suma = 0;
for (int i = 0; i <= 5; i++)
{
Console.Write($"Valor ingresado{i}; ");
if (!Double.TryParse(Console.ReadLine(), out double numero))
    {
        suma += numero;
    }
else
    {
        Console.WriteLine("Debe ingresar un número");
        i--;
    }
}
Console.WriteLine("La suma de los números es;" + suma);