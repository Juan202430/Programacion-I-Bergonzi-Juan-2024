// See https://aka.ms/new-console-template for more information

/*Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró;
luego el sistema solicitará que ingrese el costo de cada uno de esos productos consumidos;
al terminar informará el total adeudado por el cliente.*/


Console.WriteLine("Debe ingresar primero las cantidades compradas y luego los costos unitarios de cada producto. Ingrese 0 para finalizar.");
List<int> cantidades = new List<int>(); /*Armo una lista para almacenar las cantidades de productos*/
int contador = 1;

while (true) /*Bucle para solicitar las cantidades de cada producto*/
{
    Console.Write($"Cantidad del producto {contador++}: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    if (cantidad == 0) /*Si el usuario ingresa '0' sale del bucle*/
    {
        break;
    }

    cantidades.Add(cantidad); /*agrego las cantidades a la lista*/
}

List<double> costos = new List<double>(); /*Armo una lista para almacenar los costos de productos*/

for (int i = 0; i < cantidades.Count; i++) /*Bucle para solicitar los costos de productos*/
{
    Console.Write($"Costo del producto {i + 1}: ");
    double costo = Convert.ToDouble(Console.ReadLine()?.Replace(".",","));
    costos.Add(costo);
}

double total = 0; /*Calculo el total adeudado*/
for (int i = 0; i < cantidades.Count; i++)
{
    total += cantidades[i] * costos[i];
}

Console.WriteLine($"El total adeudado por el cliente es:{total:C}");
