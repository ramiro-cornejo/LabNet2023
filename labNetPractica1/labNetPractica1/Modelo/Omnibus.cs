using labNetPractica1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Modelo
{
    public class Omnibus : TransportePublico, IAccion
    {
        public Omnibus(int _numtransporte, int _pasajeros) : base(_numtransporte, _pasajeros)
        {
            this.NumTransporte = _numtransporte;
            this.Pasajeros = _pasajeros;
        }

        public string Avanzar()
        {
            throw new NotImplementedException();
        }

        public string Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("El Omnibus número {0} viaja con {1} pasajeros.", NumTransporte , Pasajeros);
        }
    }
}
