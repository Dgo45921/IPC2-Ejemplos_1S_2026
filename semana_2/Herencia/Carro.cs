using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Carro : Vehiculo
    {
        public int Ruedas { get; set; }

        public Carro(string medio, string marca, string color, int ruedas)
            : base(medio, marca, color)
        {
            Ruedas = ruedas;
        }
    }
}
