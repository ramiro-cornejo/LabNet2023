using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.Tests
{
    [TestClass()]
    public class Ejercicio02Tests
    {
        [TestMethod()]
        public void DividirTest()
        {
            string num01 = "6";
            string num02 = "0";
            
            string resultadoEsp = "0";

            Ejercicio02 ctrl = new Ejercicio02();

            string resultadoObt = ctrl.Dividir(num01 , num02);

            Assert.AreEqual(resultadoEsp, resultadoObt);

        }
    }
}