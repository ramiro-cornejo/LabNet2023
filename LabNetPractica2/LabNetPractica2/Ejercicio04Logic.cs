using LabNetPractica2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Ejercicio04Logic
    {
        public Exception DispararException()
        {
            try
            {
                throw new PersonalizadaException();
            }
            catch(PersonalizadaException ex)
            {
                return ex;
            }
            catch(Exception ex)
            {
                return ex;
            }
        }
    }
}
