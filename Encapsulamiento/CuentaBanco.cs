using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{

    public class CuentaBanco
    {
        // Atributos privados (Encapsulamiento estricto)
        private string titular;
        private double saldo; 
        public int Edad;

        // Constructor
        public CuentaBanco(string titular, double saldo = 0, int edad = 18)
        {
            this.titular = titular;
            this.saldo = saldo;
            Edad = edad;
        }

        // Método para depositar
        public void Depositar(double cantidad)
        {
            if (cantidad > 0) 
        {
                saldo += cantidad; 
            Console.WriteLine($"Depósito de {cantidad} realizado. Nuevo saldo: {saldo}"); 
        }
        else
            {
                Console.WriteLine("Cantidad a depositar debe ser positiva."); 
        }
        }

        // Método para retirar
        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo) 
        {
                saldo -= cantidad; 
            Console.WriteLine($"Retiro de {cantidad} realizado. Nuevo saldo: {saldo}"); 
        }
        else
            {
                Console.WriteLine("Cantidad a retirar debe ser positiva y no puede exceder el saldo actual."); 
        }
        }

        // Métodos para obtener valores (Getters)
        public double ObtenerSaldo() => saldo; 
        public string ObtenerTitular() => titular; 
    }
}
