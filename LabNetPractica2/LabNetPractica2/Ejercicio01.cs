using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Ejercicio01
    {
        public string Dividir(decimal num01)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch(DivideByZeroException ex)
            {
                return ex.Message;
            }
        }
    }
}
