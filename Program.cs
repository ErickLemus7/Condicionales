using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        //Uso de Operadores Condicinales
        if (x==10)
        {
            // Código si la condición es verdadera
        }
        else
        {
            // Código si la condición es falsa
        }

        //Ejecutador
        

    }

    //Ejemplo If-Else
    public static void Ejemplo()
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
    public static void EjemploIfElse()
    {
        int nota = 75;
        if (nota >= 90)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Muy Bueno");
        }
        else if (nota >=70)
        {
            Console.WriteLine("Bueno");
        }
        else
        {
            Console.WriteLine("Necesita Mejorar");
        }
        Console.WriteLine("Nota ha sido evaluada");
    }

    public static void EjemploIgual()
    {
        int edad = 18;
        bool tieneLicencia = true;

        if (edad >= 18)
        {
            if (tieneLicencia == true)
            {
                Console.WriteLine("Puedes Manejar");
            }
            else
            {
                Console.WriteLine("No Puedes Manejar");
            }
        }
        else 
        {
            Console.WriteLine("No hay edad Suficiente");
        }
    }

    public static void EjemploAnd()
    {
        int edad = 18;
        bool tieneLicencia = true;

        if (edad >= 18 && tieneLicencia==true)
        {
            Console.WriteLine("Puedes Conducir");
        }
        else
        {
            Console.WriteLine("No Puedes conducir");
        }
    }

    public static void EjemploOr()
    {
        string dia = "Sabado";
        //Detectar si es fin de semana
        if (dia == "Sabado" || dia == "Domingo")
        {
            Console.WriteLine("Es fin de semana");
        }
        else
        {
            Console.WriteLine("Es dia de semana");
        }
    }

    public static void EjemploNegacion()
    {
        int edad = 18;
        bool tieneLicencia = true;

        if (!(edad >= 18 && tieneLicencia == true))
        {
            Console.WriteLine("No Puedes conducir");
        }
        else
        {
            Console.WriteLine("Puedes Conducir");
        }
    }

    public static void EjemploDiferente()
    {
        int dado = 5;

        if (dado != 5)
        {
            Console.WriteLine("Procede a premio");
        }
        else
        {
            Console.WriteLine("No hay premio");
        }
    }
}
