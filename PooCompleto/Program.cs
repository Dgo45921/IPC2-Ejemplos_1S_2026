using PooCompleto;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear instancias de diferentes animales
        Leon leon = new Leon("Simba", 5);
        Tigre tigre = new Tigre("Shere Khan", 7);
        Elefante elefante = new Elefante("Dumbo", 10);

        // Polimorfismo: Lista de la clase base que contiene objetos derivados
        List<Animal> animales = new List<Animal> { leon, tigre, elefante };

        // Mostrar información de cada animal
        foreach (Animal animal in animales)
        {
            Console.WriteLine($"Nombre: {animal.GetNombre()}");
            Console.WriteLine($"Edad: {animal.GetEdad()} años");
            Console.WriteLine($"Sonido: {animal.Sonido()}");
            Console.WriteLine($"Costo de mantenimiento: ${animal.CostoMantenimiento()} al mes");
            Console.WriteLine(new string('-', 30));
        }
    }
}