﻿using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto Persona, a partir de la clase Persona
            // Un objeto es una instancia de su clase
            // (Una galleta es una instancia de su molde de galletitas)
            Persona persona = new Persona("Alberto", "Dombledore");
            // (Tipo) (nombre de variable) = new (Tipo)();

            persona.Presentarse();
            Console.WriteLine(persona.nombre);
            Console.WriteLine(persona.apellido);

            // null -> sin valor
            Persona persona2 = new Persona("Mario", null);
            persona2.Presentarse();
            Console.WriteLine(persona2.nombre);
            Console.WriteLine(persona2.apellido);
        }
    }
}
