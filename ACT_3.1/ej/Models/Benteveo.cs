using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    internal class Benteveo: Ave
    {
        List<string> accionesBenteveo = new List<string>();
        bool tieneHambre = false;
        int poneHuevos;
        Random random = new Random();
        public override List<string> CorreRutina()
        {
            TieneHambre();
            Come();
            accionesBenteveo.Add($"Benteveo puso {poneHuevos} huevos\n");
            return accionesBenteveo;
        }
        public override void Come()
        {
            if (tieneHambre == true)
            {
                accionesBenteveo.Add("Benteveo manguea torta\n");
                poneHuevos = 1;
            }
        }
        public override int PoneHuevos()
        {
            return poneHuevos;
        }
        public override void TieneHambre()
        {
            int hambre = random.Next(1, 2);
            if (hambre == 1)
            {
                tieneHambre = true;
                accionesBenteveo.Add("Benteveo tiene hambre");
            }
            else
            {
                accionesBenteveo.Add("Benteveo no tiene hambre");
            }
        }
    }
}
