using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.Exceptions
{
    public class PersonalizadaException : Exception
    {
        public PersonalizadaException() : base("Exception personalizada.")
        {

        }
    }
}
