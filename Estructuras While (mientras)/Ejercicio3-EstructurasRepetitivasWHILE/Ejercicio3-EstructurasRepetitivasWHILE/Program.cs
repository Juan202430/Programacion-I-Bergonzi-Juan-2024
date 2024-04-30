// See https://aka.ms/new-console-template for more information

/*El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre 
vacío, sin datos; el sistema informará cuántos nombres se han ingresado*/

Console.WriteLine("Ingrese nombre y/o apellido, deje el campo vacío para terminar.");
Console.Write("Ingrese nombre y/o apellido: ");
int cantidad = 0;
string? nombre = Console.ReadLine();

while (!string.IsNullOrEmpty(nombre))
{
    if (int.TryParse(nombre, out _))
    {
        Console.WriteLine("Error: Por favor, ingrese un nombre válido.");
    }
    else
    {
        cantidad++;
    }
    Console.Write("Ingrese nombre y/o apellido: ");
    nombre = Console.ReadLine();
}
Console.WriteLine($"Se ha ingresado un total de {cantidad} nombres");