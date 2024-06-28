// See https://aka.ms/new-console-template for more information
/* 1.Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir
este ingreso hasta que el usuario ingrese la clave correcta: 667788.*/


int claveI = 0;
int claveC = 667788;
Console.WriteLine("Ingrese su usuario:");
string? nombre = (Console.ReadLine());

do
{
    Console.WriteLine("Ingrese su clave:");
    if (!int.TryParse(Console.ReadLine(), out claveI))
    {
        Console.WriteLine("Debe ingresar números. ");
    }
    else if (claveI == claveC)
    {

        Console.WriteLine("Constraseña Correcta");
    }
    else
    {
        Console.WriteLine("Error, contraseña incorrecta.");
    }
} while (claveI != claveC);
