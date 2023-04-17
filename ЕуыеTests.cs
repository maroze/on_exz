using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class ЕуыеTests
    {
        [TestMethod()]
        public void MethodTest()
        {
            int[,] a = new int[2, 2] { { 2, 0 }, { 0, 2 }};
            int [,] result = Test.Method(a, 2);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(a[i,j], result[i, j]);

                }
            }
        }

    }
}