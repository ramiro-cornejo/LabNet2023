using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Modelo
{
    public abstract class TransportePublico
    {
        public TransportePublico(int _numtransporte, int _pasajeros)
        {
            this.NumTransporte = _numtransporte;
            this.Pasajeros = _pasajeros;
        }
        public int Pasajeros { get; set; }
        public int NumTransporte { get; set; }
    }
}
