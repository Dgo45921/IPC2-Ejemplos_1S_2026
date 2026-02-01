using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Animal
    {
        // virtual permite que las clases hijas modifiquen este método
        public virtual string HacerSonido()
        {
            return "";
        }
    }
}
