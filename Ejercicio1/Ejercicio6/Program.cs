// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar un número");
double n1;
if (!Double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Debe Ingresar un número");
}
else
{
    if (n1 > 0)
    {
        Console.WriteLine("El número es positivo");
    }
    else
    {
        Console.WriteLine("El número es negativo");
    }
}
