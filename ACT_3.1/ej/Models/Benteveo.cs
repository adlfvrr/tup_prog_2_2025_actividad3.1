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
        public override List<string> CorreRutina()
        {
            Come();
            acciones.Add($"El benteveo pone {PoneHuevos()} huevo");
            return acciones;
        }
        public override void Come()
        {
            if (TieneHambre() == true)
            {
                acciones.Add("Benteveo manguea torta");
            }
        }
        public override int PoneHuevos()
        {
            int huevos = 0;
            if (TieneHambre() == true)
                { huevos = 1; }
            return huevos;
        }
        public override bool TieneHambre()
        {
            int hambre = random.Next(0,1);
            if (hambre == 0) {return false;}
            else { return true;}
        }
    }
}
