// See https://aka.ms/new-console-template for more information
int limite = 0;
double numero;

do
{
    Console.Write("Por favor, ingrese un número: ");
    if (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Ingreso inválido. Por favor, ingrese un número válido.");
    }

    if (numero >= limite)
    {
        Console.WriteLine("El número ingresado es positivo.");
    }
    else
    {
        Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
    }
} while (numero < limite);