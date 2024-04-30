// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese los datos de los 5 clientes:");

string cliente = "";
double mayorgasto = double.MinValue; 

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Cliente {i}: ");
    Console.Write("Ingrese el nombre del cliente: ");
    string nombrecliente = Console.ReadLine();

    Console.Write("Ingrese el total gastado: ");
    if (double.TryParse(Console.ReadLine(), out double gasto_total))
    {
        if (gasto_total > mayorgasto)
        {
            mayorgasto = gasto_total;
            cliente = nombrecliente;
        }
    }
    else
    {
        Console.WriteLine("Total gastado inválido. Intente nuevamente.");
        i--;
    }
}
Console.WriteLine($"El cliente que gastó más es: {cliente}");
