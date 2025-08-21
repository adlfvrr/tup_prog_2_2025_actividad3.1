using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    internal class Gallina: Ave
    {
        Random random = new Random();
        public int Racion { get; set; }

        public override List<string> CorreRutina()
        {
            Come();
            acciones.Add($"La gallina puso {PoneHuevos()} huevos");
            return acciones;
        }
        public override int PoneHuevos()
        {
            int maximo = Racion;
            if (maximo > 1) { maximo = 2; }
            int huevos = random.Next(maximo);
            return huevos;
        }
        public override void Come()
        {
            if (TieneHambre() == true)
            {
                Racion = random.Next(0, 10);
                acciones.Add($"La gallina comió {Racion} raciones");
            }
        }
        override public bool TieneHambre()
        {
            int tieneHambre = random.Next(0, 1);
            if(tieneHambre == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
