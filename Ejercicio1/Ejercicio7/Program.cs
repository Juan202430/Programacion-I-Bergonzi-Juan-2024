// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar el número 1:");
double n1, n2;
if (!Double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Debe ingresar un número");
}
else
{
    Console.WriteLine("Ingresar el número 2:");
    if (!Double.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("Debe ingresar un número");
    }
    else
    {
        if (n1 > n2)
        {
            Console.WriteLine("El número 1 es mayor que el número 2");
        }
        else
        {
            if (n1 == n2)
            {
                Console.WriteLine("El número 1 y 2 son iguales");
            }
            else
            {
                Console.WriteLine("El número 2 es mayor que el número 1");
            }
        }
    }
}

