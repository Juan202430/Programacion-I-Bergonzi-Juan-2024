// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar un número:");
double lado;
if (!Double.TryParse(Console.ReadLine(), out lado))
{
    Console.WriteLine("Debe ingresar un número");
}
else
{
    Console.WriteLine("El área del cuadrado es:" + (lado * lado));
}

