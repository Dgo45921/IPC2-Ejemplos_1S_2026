using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Vehiculo
    {
        // Propiedades automáticas (reemplazan a obtener_medio, etc.)
        public string Medio { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        public Vehiculo(string medio, string marca, string color)
        {
            Medio = medio;
            Marca = marca;
            Color = color;
        }
    }
}
