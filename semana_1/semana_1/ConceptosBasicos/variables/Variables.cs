using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBasicos.Variables
{
    public class Variables
    {

        static public void Run() {
            // Tipos de datos básicos

            // int: números enteros
            int x = 10;
            Console.WriteLine(x + 5);

            // float / double: números decimales
            double y = 0.5;
            Console.WriteLine(0.5 + y);

            // string: texto
            string z = "3000";
            Console.WriteLine(z);

            // string multilínea
            string cadenaMultilinea = @"Hola como estan les mando un saludo

-- atentamente: yo
dsafa
fadsf
";

            // salto de línea con escape
            string prueba = "Hola \n Adios";

            Console.WriteLine(cadenaMultilinea);
            Console.WriteLine(prueba);

            // interpolación de strings
            string mensaje = "Hola, soy un mensaje de texto";
            string mensajeFormateado = $"Hola este es el mensaje: {mensaje}";

            Console.WriteLine(mensajeFormateado);

            // booleanos
            bool variableBooleana = true;

            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine("Variable negada: ", variableBooleana);
        }

    }
}
