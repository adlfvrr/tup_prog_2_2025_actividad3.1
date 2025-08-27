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
        int raciones;
        public override int PoneHuevos()
        {
            int huevos = 0;
            if (TieneHambre() == false)
            {
                int maximo = raciones;
                if (maximo > 1) 
                {
                    maximo = 2;
                    huevos = random.Next(0, maximo);
                }
                raciones = 0;
            }
            acciones.Add($"La gallina puso {huevos} huevos");
            return huevos;
        }
        public override void Come()
        {
            if (TieneHambre() == true)
            {
                raciones += random.Next(0, 10);
                acciones.Add($"La gallina comió {raciones} raciones");
            }
        }
        override public bool TieneHambre()
        {
            return random.Next(0, 2) == 1;
        }
    }
}
