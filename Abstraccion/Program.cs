using Abstraccion;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una lista de figuras
        List<Figura> figuras = new List<Figura>
        {
            new Circulo(5),
            new Rectangulo(4, 6)
        };

        foreach (var figura in figuras)
        {
            Console.WriteLine($"El área de la figura es: {figura.CalcularArea()}");
        }
    }
}