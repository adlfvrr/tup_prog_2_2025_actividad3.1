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
        public int Racion;
        public int poneHuevos;
        bool tieneHambre = false;
        List<string> accionesGallina = new List<string>();

        public override List<string> CorreRutina()
        {
            TieneHambre();
            Come();
            accionesGallina.Add($"La gallina puso {PoneHuevos} huevos\n");
            return accionesGallina;
        }
        public override int PoneHuevos()
        {
            return poneHuevos;
        }
        public override void Come()
        {
            if (tieneHambre == true)
            {
                int racionesDadas = random.Next(0, 10);
                int racionesComidas = random.Next(racionesDadas);
                PoneHuevos = racionesComidas;
                accionesGallina.Add($"La gallina come {racionesComidas} raciones de las {racionesDadas}.\n");
            } 
        }
        override public void TieneHambre()
        {
            int hambre = random.Next(1, 2);
            if (hambre == 1)
            {
                tieneHambre = true;
                accionesGallina.Add("La gallina tiene hambre\n");
            }
            else
            {
                accionesGallina.Add("La gallina no tiene hambre\n");
            }

        }
    }
}
