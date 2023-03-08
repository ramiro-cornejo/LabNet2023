using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class DivisionCeroException : Exception
    {
        public DivisionCeroException() : base("Solo Chuck Norris divide por cero!")
        {

        }
    }
}
