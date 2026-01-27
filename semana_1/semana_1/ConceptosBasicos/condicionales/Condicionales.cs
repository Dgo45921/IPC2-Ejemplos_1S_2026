using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBasicos.condicionales
{
    public class Condicionales
    {
        static public void Run() {

            // Ejemplo 1: Sentencia if simple
            int numero = 10;

            // Verifica si el número es mayor que 5
            if (numero > 5)
            {
                Console.WriteLine("El número es mayor que 5");

                if (numero == 10)
                {
                    Console.WriteLine("el numero es 10");
                }
            }

            // Ejemplo 2: if-else
            string usuario = "admin";

            // Verifica si el usuario es administrador
            if (usuario == "admin")
            {
                Console.WriteLine("Acceso permitido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            // Ejemplo 3: if-else if-else
            int edad = 15;

            // Clasifica la edad en categorías
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if (edad >= 13)
            {
                Console.WriteLine("Eres adolescente");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}
