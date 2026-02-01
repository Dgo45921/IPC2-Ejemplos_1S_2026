using Clases_e_instanciacion;
using System;

class Program
{
    static void Main()
    {
        // Creando instancias de la clase Persona 
        // persona1 usa el valor por defecto para 'casado' (false)
        Persona persona1 = new Persona("Diego", 23);

        // persona2 especifica que está casado 
        Persona persona2 = new Persona("Juana", 25, true);

        // Llamar al método saludar y mostrar en consola 
        Console.WriteLine(persona1.Saludar());
        Console.WriteLine(persona2.Saludar());

        // Preguntar si están casados 
        Console.WriteLine(persona1.DecirSiEstoyCasado());
        Console.WriteLine(persona2.DecirSiEstoyCasado());
    }
}