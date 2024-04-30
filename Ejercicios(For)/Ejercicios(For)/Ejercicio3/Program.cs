// See https://aka.ms/new-console-template for more information
using System;


double sumatotal = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Compra N°{i}");
    Console.WriteLine("Ingresar precio unitario; ");
    if (double.TryParse(Console.ReadLine(), out double precio))
    {
        Console.WriteLine("Ingresar cantidad comprada; ");
        if (int.TryParse(Console.ReadLine(), out int cantcompra))
        {
            sumatotal += precio * cantcompra;
        }
        else
        {
            Console.WriteLine("Debe ingresar un número");
            i--;
        }
    }
    else
    {
        Console.WriteLine("Debe ingresar un número");
        i--;
    }
}
Console.WriteLine($"La suma de la factura es; {sumatotal}");
 