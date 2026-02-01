using System;
using System.Collections.Generic;
using System.Text;

namespace PooCompleto
{
    public class Tigre : Animal
    {
        public Tigre(string nombre, int edad) : base(nombre, edad) { }

        public override string Sonido() => "Gruñe"; 
        public override int CostoMantenimiento() => 600; 
    }
}
