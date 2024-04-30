// See https://aka.ms/new-console-template for more information

/*Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada;
cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.*/

Console.WriteLine("Ingrese los datos de la compra: Costo unitario y cantidad comprada.");
double deudatotal = 0;
double costounitario = 1; /*inicio con valor distinto a cero para iniciar bucle*/
int contador = 1;

while (costounitario != 0)
{
    Console.Write($"Compra {contador++}: ");
    Console.Write("Ingrese costo unitario:");
    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out costounitario))
    {
        Console.Write("Ingrese la cantidad comprada: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadcomprada))
        {
            double compratotal = costounitario * cantidadcomprada;
            deudatotal += compratotal;
        }
        else
        {
            Console.WriteLine("Cantidad compra inválida. Intente nuevamente.");
            contador--;
        }
    }
else
    {
        Console.WriteLine("Costo unitario inválido. Intente nuevamente.");
        contador--;
    }
}
Console.WriteLine($"El total adeudado es: ${deudatotal}");