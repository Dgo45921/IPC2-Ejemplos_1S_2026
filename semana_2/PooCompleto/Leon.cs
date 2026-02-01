using System;
using System.Collections.Generic;
using System.Text;

namespace PooCompleto
{
    public class Leon : Animal
    {
        public Leon(string nombre, int edad) : base(nombre, edad) { }

        public override string Sonido() => "Ruge";
        public override int CostoMantenimiento() => 500; 
    }
}
