using System;
using System.Collections.Generic;
using System.Text;

namespace PooCompleto
{
    public abstract class Animal
    {
        // Encapsulamiento: campos privados
        private string _nombre;
        private int _edad;

        public Animal(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        // Métodos para acceder a los atributos (Getters)
        public string GetNombre() => _nombre;
        public int GetEdad() => _edad;

        // Métodos abstractos (deben ser implementados por las clases hijas)
        public abstract string Sonido();
        public abstract int CostoMantenimiento();
    }
}
