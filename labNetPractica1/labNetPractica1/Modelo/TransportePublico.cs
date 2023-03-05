using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Modelo
{
    public abstract class TransportePublico
    {
        private int Pasajeros { get; set; }
        public TransportePublico( int _pasajeros )
        {
            this.Pasajeros = _pasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
