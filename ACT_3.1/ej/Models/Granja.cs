using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    internal class Granja
    {
        List<Animal> animales = new List<Animal>();
        public Granja()
        {
            animales.Add(new Perro());
            animales.Add(new Gallina());
            animales.Add(new Benteveo());
            animales.Add(new Zorro());

        }
    }
}
