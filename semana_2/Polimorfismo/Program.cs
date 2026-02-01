using Polimorfismo;
using System;
using System.Collections.Generic;

class Program
{
    // Método que demuestra el polimorfismo
    static void ImprimirSonido(Animal animal)
    {
        Console.WriteLine(animal.HacerSonido());
    }

    static void Main()
    {
        // Creamos una lista de tipo Animal que contiene diferentes especies
        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Gato(),
            new Vaca()
        };

        foreach (var animal in animales)
        {
            ImprimirSonido(animal);
        }
    }
}