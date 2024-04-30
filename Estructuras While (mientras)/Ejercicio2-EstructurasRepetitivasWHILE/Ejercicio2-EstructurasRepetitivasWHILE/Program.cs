// See https://aka.ms/new-console-template for more information

/*Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.*/

Console.WriteLine("Ingrese valores enteros o decimales positivos, use 0 (cero) para terminar.");

double suma = 0;
int cantidad = 0;
double valor = 1; /*Inicializado con un valor diferente de cero para que entre al bucle*/

while (valor != 0)
{
    Console.Write("Ingrese un valor: ");
    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out valor))
    {
        /*Verifica si el valor es positivo*/
        if (valor > 0)
        {
            /*Suma el valor al total*/
            suma += valor;
            cantidad = cantidad +1;
        }
        else if (valor < 0)
        {
            Console.WriteLine("Error: Ingrese un valor positivo.");
        }
    }
    else
    {
        Console.WriteLine("Error: Ingrese un valor numérico válido.");
    }
}
 double promedio = suma / cantidad;
/*Muestra la suma de los valores ingresados*/
Console.WriteLine($"La suma de los valores ingresados es:{suma} y su promedio es:{promedio}");

