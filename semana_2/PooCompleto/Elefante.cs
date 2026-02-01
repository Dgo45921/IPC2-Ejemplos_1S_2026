using System;
using System.Collections.Generic;
using System.Text;

namespace PooCompleto
{
    public class Elefante : Animal
    {
        public Elefante(string nombre, int edad) : base(nombre, edad) { }

        public override string Sonido() => "Trompetea"; 
        public override int CostoMantenimiento() => 700;
    }
}
