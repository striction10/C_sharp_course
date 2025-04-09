using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class begin32Tests
    {
        [TestMethod()]
        [DataRow(0, 32)]
        [DataRow(100, 212)]
        [DataRow(-40, -40)]
        public void ChangeTest(double val, double expected)
        {
            double var = begin32.Change(val);
            Assert.AreEqual(expected, var);
        }
    }
}