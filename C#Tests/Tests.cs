using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Integer11Tests
    {
        [TestMethod()]
        [DataRow(123, 3)]
        [DataRow(124, 4)]
        [DataRow(678, 8)]
        public void CheckNum3(int num, int expected)
        {
            double var = Integer11.Num3(num);
            Assert.AreEqual(expected, var);
        }
        [TestMethod()]
        [DataRow(123, 2)]
        [DataRow(124, 2)]
        [DataRow(678, 7)]
        public void CheckNum2(int num, int expected)
        {
            double var = Integer11.Num2(num);
            Assert.AreEqual(expected, var);
        }
        [TestMethod()]
        [DataRow(123, 1)]
        [DataRow(124, 1)]
        [DataRow(678, 6)]
        public void CheckNum1(int num, int expected)
        {
            double var = Integer11.Num1(num);
            Assert.AreEqual(expected, var);
        }
        [TestMethod()]
        [DataRow(0, 1, 2, 3)]
        [DataRow(1, 1, 1, 3)]
        [DataRow(2, 2, 2, 6)]
        public void CheckSum(int num_3, int num_2, int num_1, int expected)
        {
            double var = Integer11.Sum(num_3, num_2, num_1);
            Assert.AreEqual(expected, var);
        }
        [TestMethod()]
        [DataRow(0, 1, 2, 0)]
        [DataRow(1, 1, 1, 1)]
        [DataRow(1, 2, 3, 6)]
        public void CheckArg(int num_3, int num_2, int num_1, int expected)
        {
            double var = Integer11.Arg(num_3, num_2, num_1);
            Assert.AreEqual(expected, var);
        }
    }
}