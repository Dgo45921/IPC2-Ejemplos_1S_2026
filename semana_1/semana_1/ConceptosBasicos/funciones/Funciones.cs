using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBasicos.funciones
{
    public class Funciones
    {

        static public void Run()
        {
            Greet();
            PrintSum(10, 5);
            Console.WriteLine(Multiply(2, 2));
            SayHello();
            Console.WriteLine(IsEven(4));
        }

        // Ejemplo 1: Función sin parámetros y sin valor de retorno
        static void Greet()
        {
            Console.WriteLine("Hello, world!");
        }

        // Ejemplo 2: Función con parámetros y sin valor de retorno
        static void PrintSum(int a, int b)
        {
            Console.WriteLine("The sum is: " + (a + b));
        }

        // Ejemplo 3: Función con parámetros y valor de retorno
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Ejemplo 4: Función con un parámetro con valor por defecto
        static void SayHello(string name = "Guest")
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Ejemplo 5: Función que verifica si un número es par y retorna un valor booleano
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
