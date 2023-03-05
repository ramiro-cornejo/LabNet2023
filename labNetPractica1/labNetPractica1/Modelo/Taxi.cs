using labNetPractica1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Modelo
{
    public class Taxi : TransportePublico, IAccion
    {
        public Taxi(int _numtransporte, int _pasajeros) : base(_numtransporte, _pasajeros)
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
            return $"El Táxi número  {this.NumTransporte} viaja con {this.Pasajeros} pasajeros.";
        }
    }
}
