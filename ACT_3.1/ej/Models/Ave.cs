using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public abstract class Ave: Animal
    {
        public bool EstaVivo = true;

        public abstract void Come();
        public abstract int PoneHuevos();
        public abstract void TieneHambre();
    }
}
