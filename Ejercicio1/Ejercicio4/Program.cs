// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar un número;");
double n1, n2, n3;
if (!Double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Debe ingresar un número");
}
else
{
    Console.WriteLine("Ingresar un número:");
    if (!Double.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("Debe ingresar un número");
    }
    else
    {
        Console.WriteLine("Ingresar un número:");
        if (!Double.TryParse(Console.ReadLine(), out n3))
        {
            Console.WriteLine("Debe ingresar un número:");
        }
        else
        {
            Console.WriteLine("El promedio de la suma es;" + (n1 + n2 + n3) / 3);
        }
    }
}
