using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public Persona() { }
    }
}
