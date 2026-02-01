using Herencia;
using System;

class Program
{
    static void Main()
    {
        // Crear un objeto Barco
        Barco barco = new Barco("Marítimo", "Yamaha", "Blanco", 150);
        Console.WriteLine($"Barco: {barco.Medio}, Marca: {barco.Marca}, Color: {barco.Color}, Millas Náuticas: {barco.MillasNauticasRecorridas}");

        // Crear un objeto Carro
        Carro carro = new Carro("Terrestre", "Toyota", "Rojo", 4);
        Console.WriteLine($"Carro: {carro.Medio}, Marca: {carro.Marca}, Color: {carro.Color}, Ruedas: {carro.Ruedas}");
    }
}