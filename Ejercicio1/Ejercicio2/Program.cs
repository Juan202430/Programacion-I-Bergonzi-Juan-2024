// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número;");
double n1;
if (!Double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Debe ingresar un número; ");
}
else
if (n1 % 2 == 0)
{
    Console.WriteLine("El número ingresado es par");
}
else
{
    Console.WriteLine("El número es impar");
}

