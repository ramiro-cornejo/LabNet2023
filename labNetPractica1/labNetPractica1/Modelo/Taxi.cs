﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Modelo
{
    public class Taxi : TransportePublico
    {
        public Taxi(int _pasajeros) : base(_pasajeros)
        {

        }
        public override string Avanzar()
        {
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
