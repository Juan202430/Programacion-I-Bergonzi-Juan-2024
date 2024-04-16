// See https://aka.ms/new-console-template for more information

Console.WriteLine("Escriba un número; ");
double n1, n2;
if (!Double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Error, debe ingresar  un numero");
}
else
{
    Console.Write("Ingrese otro número: ");
    if (!Double.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }
    else
    {
        Console.WriteLine("La suma de los números es: " + (n1 + n2));
    }
}
