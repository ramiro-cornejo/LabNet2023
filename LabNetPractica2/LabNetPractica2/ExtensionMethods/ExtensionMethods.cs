using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static decimal StringConvert(this string convert)
        {
            return Convert.ToDecimal(convert);
        }
    }
}
