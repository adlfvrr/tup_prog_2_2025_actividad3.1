using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    internal class Zorro: Animal
    {
        Granja granjaZorro;
        Random random = new Random();
        public Zorro(Granja granja)
        {
            this.granjaZorro = granja;
        }
        public override List<string> CorreRutina()
        {
            Ave ave = VerAves();
            if (ave != null)
            {
                Come(ave);
            }
            return acciones;
        }
        public bool TieneHambre()
        {
            Random random = new Random();
            return random.Next(0,2) == 1;
        }    
        public Ave VerAves()
        {
            Ave aveElegida = null;
            List<Ave> avesVivas = granjaZorro.VerAvesVivas();
            if (avesVivas != null & avesVivas.Count > 0)
            {
                int idxAveSorteada = random.Next(0, avesVivas.Count);
                aveElegida = avesVivas[idxAveSorteada];
                if(aveElegida != null)
                {
                    acciones.Add("El zorro ha elegido a una presa");
                }
                else
                {
                    acciones.Add("El zorro no ha elegido presas");
                }
            }
            return aveElegida;
        }
        public void Come(Ave ave)
        {
            if(ave != null && TieneHambre() == true)
            {
                ave.EstaVivo = false;
                acciones.Add("El zorro ha comido un ave");
            }
            else
            {
                acciones.Add("El zorro no ha comido");
            }
        }
    }
}
