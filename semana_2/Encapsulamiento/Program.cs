using Encapsulamiento;
using System;

class Program
{
    static void Main()
    {
        // Instancia de la cuenta
        CuentaBanco cuenta = new CuentaBanco("Fabiano Caruana", 1000);

        // Acceso a través de métodos públicos
        Console.WriteLine($"Titular de la cuenta: {cuenta.ObtenerTitular()}"); 
        Console.WriteLine($"Saldo inicial: {cuenta.ObtenerSaldo()}");

        cuenta.Depositar(500); 
        cuenta.Retirar(200); 
        cuenta.Retirar(1500); // Intento de retiro mayor al saldo 

        Console.WriteLine($"Saldo final: {cuenta.ObtenerSaldo()}");

        // Acceso al atributo público
        Console.WriteLine($"Edad del titular: {cuenta.Edad}");

        // Error
        //Console.WriteLine($"Edad del titular: {cuenta.titular}");


    }
}