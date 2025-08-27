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
            animales.Add(new Zorro(this));
        }
        public List<Ave> VerAvesVivas()
        {
            List<Ave> aves = new List<Ave>();
            foreach(var animal in animales)
            {
                if(animal is Ave)
                {
                    Ave ave = (Ave)animal;
                    if (ave.EstaVivo)
                    {
                        aves.Add(ave);
                    }
                }
            }
            return aves;
        }
        public List<string> SimularDia()
        {
            List<string> resultados = new List<string>();
            foreach(Animal animal in animales)
            {
                List<string> accionesAnimal = animal.CorreRutina();
                resultados.AddRange(accionesAnimal.ToArray());
            }
            return resultados;
        }
    }
}
