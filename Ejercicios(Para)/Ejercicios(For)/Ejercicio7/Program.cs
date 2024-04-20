// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un número entero y positivo:");

int numero;

if (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("El número ingresado no es entero.");
}
else
{
    if (numero <= 0)
    {
        Console.WriteLine("El número ingresado no es positivo.");
    }
    else
    {
        for (int i = 0; i <= numero; i += 2)
        {
            if (i % 2 == 0) { Console.WriteLine(i); }
        }
    }
}
