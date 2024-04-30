// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un valor entero:");

int entero, factorial = 1;
if (!int.TryParse(Console.ReadLine(), out entero))
{
    Console.WriteLine("El número ingresado no es un entero.");
}
else
{
    for (int i = entero; i >= 1; i--)
    {
        factorial = factorial * i;
    }
    Console.WriteLine($"El factorial del entero {entero} es {factorial}");
}
