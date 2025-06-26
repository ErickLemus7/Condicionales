using System;

class Program
{
    public static void Main(string[] args)
    {
        //Uso de Operadores Condicinales
        if (1<0)
        {
            // Código si la condición es verdadera
        }
        else
        {
            // Código si la condición es falsa
        }
    }

    public void Ejemplo()
    {
        int edad = 18;
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }
    }

    //Ejemplo Usando if-else-if-else
    public void EjemploIfElse()
    {
        int nota = 75;
        if (nota >= 90)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Bueno");
        }
        else
        {
            Console.WriteLine("Necesitas mejorar");
        }
    }
}
