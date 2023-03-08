using LabNetPractica2.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Ejercicio02
    {
        public string Dividir(string num01, string num02)
        {
            try
            {
                decimal numero01 = num01.StringConvert();
                decimal numero02 = num02.StringConvert();

                if (numero02 == 0)
                {
                    throw new DivisionCeroException();
                }
                else
                {
                    return $"Resultado:  {numero01 / numero02}";
                }
            }
            catch(FormatException)
            {
                return string.Format("Seguro ingreso una letra o no ingreso nada. ¡Intente nuevamente!");
            }
            catch(DivisionCeroException ex)
            {
                return ex.Message;
            }
        }
    }
}
