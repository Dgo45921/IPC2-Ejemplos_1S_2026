using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Barco : Vehiculo
    {
        public int MillasNauticasRecorridas { get; set; }

        public Barco(string medio, string marca, string color, int millasNauticasRecorridas)
            : base(medio, marca, color) 
        {
            MillasNauticasRecorridas = millasNauticasRecorridas;
        }
    }
}
