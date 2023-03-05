using labNetPractica1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    internal class Transporte
    {
        List<TransportePublico> transportes = new List<TransportePublico>();

        public void CargarDts(TransportePublico transporte)
        {
            transportes.Add(transporte);
        }
        public List<TransportePublico> Listado()
        {
            return this.transportes;
        }
    }
}
