using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    internal class Benteveo: Ave
    {
        Random random = new Random();
        public override void Come()
        {
            if (TieneHambre() == true)
            {
                acciones.Add("Benteveo manguea torta");
            }
            else
            {
                acciones.Add("El benteveo no ha comido");
            }
        }
        public override int PoneHuevos()
        {
            int huevos = 0;
            if (TieneHambre() == false)
            { 
                huevos = random.Next(0,1);
                acciones.Add($"El benteveo pone {huevos} huevos");
                return huevos;
            }
            return 0;
        }
        public override bool TieneHambre()
        {
            return random.Next(0, 2) == 1;
        }
    }
}
