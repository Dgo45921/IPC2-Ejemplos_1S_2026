using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBasicos.iteraciones
{
    public class Iteraciones
    {

        static public void Run() { 
          // Ejemplos básicos de iteraciones en C#

        // 1. Iterar sobre una lista usando foreach
        string[] frutas = { "manzana", "banana", "cereza" };
        Console.WriteLine("Ejemplo 1: Iterar sobre una lista");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        // 2. Usar for para imprimir números del 1 al 4
        Console.WriteLine("\nEjemplo 2: Usar for");
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // 3. Iterar sobre los caracteres de una cadena
        string texto = "Hola";
        Console.WriteLine("\nEjemplo 3: Iterar sobre los caracteres de una cadena");
        foreach (char letra in texto)
        {
            Console.WriteLine(letra);
        }

        // 4. Usar while para contar hasta 5
        Console.WriteLine("\nEjemplo 4: Usar while para contar");
        int contador = 1;
        while (contador <= 5)
        {
            Console.WriteLine(contador);
            contador++;
        }

        // Entrada de datos por consola
        Console.WriteLine("\nIngrese su edad:");
        string edad = Console.ReadLine();

        int edadNumero = int.Parse(edad);
        Console.WriteLine(edadNumero + 5);
        }
    }
}
