// See https://aka.ms/new-console-template for more information

/*El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0
(cero). El sistema deberá informar la suma de los ingresados.*/

Console.WriteLine("Ingrese valores enteros o decimales positivos, use 0 (cero) para terminar.");

double suma = 0;
double valor = 1; /*Inicializado con un valor diferente de cero para que entre al bucle*/

while (valor != 0)
{
    Console.Write("Ingrese un valor: ");
    if (double.TryParse(Console.ReadLine()?.Replace(".",","), out valor))
    {
        /*Verifica si el valor es positivo*/
        if (valor > 0)
        {
            /*Suma el valor al total*/
            suma += valor;
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
/*Muestra la suma de los valores ingresados*/
Console.WriteLine("La suma de los valores ingresados es: " + suma);
