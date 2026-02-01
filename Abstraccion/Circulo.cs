using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            // Usamos Math.PI para mayor precisión
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
