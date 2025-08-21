using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public class Perro: Animal
    {
        override public List<string> CorreRutina()
        {
            string ladrar = Ladrar();
            acciones.Add($"El perro ladra {ladrar}");
            return acciones;
        }
        public string Ladrar()
        {
            return "guau guau";
        }
    }
}
