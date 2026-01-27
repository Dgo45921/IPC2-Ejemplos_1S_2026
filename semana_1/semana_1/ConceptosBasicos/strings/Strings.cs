using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBasicos.Strings
{
    public class Strings
    {
        static public void Run() {
            // Ejemplos básicos de manipulación de cadenas en C#

            // 1. Concatenación de cadenas
            string nombre = "Juan";
            string apellido = "Guerra";
            string nombreCompleto = nombre + " " + apellido;
            Console.WriteLine("Concatenación: " + nombreCompleto);

            // 2. Convertir a mayúsculas y minúsculas
            string texto = "Hola Mundo";
            Console.WriteLine("Mayúsculas: " + texto.ToUpper());
            Console.WriteLine("Minúsculas: " + texto.ToLower());

            // 3. Reemplazar texto en una cadena
            string frase = "Me gusta programar en Java";
            string fraseNueva = frase.Replace("Java", "Python");
            Console.WriteLine("Reemplazo: " + fraseNueva);

            // 4. Dividir una cadena en partes
            string datos = "manzana,pera,banana";
            string[] listaFrutas = datos.Split(',');
            Console.WriteLine("Lista de frutas: " + string.Join(", ", listaFrutas));

            // 5. Eliminar espacios al inicio y al final
            string mensaje = "   Hola, ¿cómo estás?   ";
            string mensajeLimpio = mensaje.Trim();
            Console.WriteLine("Mensaje limpio: " + mensajeLimpio);
        }
    }
}
