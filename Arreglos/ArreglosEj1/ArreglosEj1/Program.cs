// See https://aka.ms/new-console-template for more information

int[] numeros = new int[5];
int i = 0;

Console.WriteLine("Ingrese 5 números enteros.");
for (i = 0; i < numeros; i++) 
{
    Console.Write("Ingrese el número:");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        numeros[i] = numero;
    }
    else
    {
        Console.WriteLine("Debe ingresar un número entero.");
        i--;
    }
}
foreach (int num in numeros)
{
    Console.WriteLine($"Los números ingresados son: {num}");
}