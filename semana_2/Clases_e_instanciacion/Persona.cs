using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_e_instanciacion
{
    public class Persona
    {
        // Propiedades (Equivalentes a los atributos de Python)
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }

        // Constructor: El parámetro 'casado' tiene un valor por defecto (false) 
        public Persona(string nombre, int edad, bool casado = false)
        {
            Nombre = nombre;
            Edad = edad;
            Casado = casado;
        }

        // Método para saludar 
        public string Saludar()
        {
            return $"Hola, mi nombre es {Nombre} y tengo {Edad} años.";
        }

        // Método para verificar el estado civil 
        public string DecirSiEstoyCasado()
        {
            return Casado ? "Estoy casado." : "No estoy casado.";
        }
    }
}
