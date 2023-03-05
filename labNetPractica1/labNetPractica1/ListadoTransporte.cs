using labNetPractica1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class ListadoTransporte
    {
        int listomnibus = 0;
        int listtaxi = 0;

        Transporte transportes = new Transporte();

        public string CargarDts(string _tipotransporte, int _numpasajeros )
        {
            if (_tipotransporte != "")
            {
                TransportePublico transporte;
                if (_tipotransporte == "Omnibus")
                {
                    if (listomnibus <= 4)
                    {
                        listomnibus++;
                        transporte = new Omnibus(listomnibus, _numpasajeros);
                        transportes.CargarDts(transporte);
                        return string.Format("Datos del transporte cargados correctamente.");
                    }
                    else
                    {
                        return string.Format("Transporte no disponible.");
                    }
                }
                else
                {
                    if(listtaxi <= 4)
                    {
                        listtaxi++;
                        transporte = new Taxi(listtaxi, _numpasajeros);
                        transportes.CargarDts(transporte);
                        return string.Format("Datos del transporte cargados correctamente");
                    }
                    else
                    {
                        return string.Format("Transporte no disponible.");
                    }
                }
            }
            else
            {
                return string.Format("Elegir transporte público para poder cargar datos.");
            }
        }
        public List<TransportePublico> OrdenarList()
        {
            return transportes.Listado();
        }
    }
}
