using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Logic
    {
        public Exception DispararException()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                return ex;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
