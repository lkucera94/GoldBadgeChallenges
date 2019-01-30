using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void UsingOperators()
        {
            int number = 10;
            int numberTwo = 30;

            int c = number + numberTwo;
            Assert.AreEqual(40, c);

            int a = numberTwo - number;
            Assert.AreEqual(20, a);

            int b = numberTwo / number;
            Assert.AreEqual(3, b);

            int d = number * numberTwo;
            Assert.AreEqual(300, d);

            int e = numberTwo % number;
            Assert.AreEqual(0, e);
        }

        [TestMethod]
        public void UsingAMethod()
        {
            int f = 50;
            int g = 100;

            int j = AddTwoNumbers(f, g);
            Assert.AreEqual(150, j);

            int s = Subtract(g, f);
            Assert.AreEqual(50, s);

            int m = Multiply(f, g);
            Assert.AreEqual(5000, m);

            int d = Divide(g, f);
            Assert.AreEqual(2, d);
        }

        private int AddTwoNumbers(int kung, int fu)
        {
            int kungFu = kung + fu;
            return kungFu;
        }
        private int Subtract(int kung, int fu)
        {
            int kungFu = kung - fu;
            return kungFu;
        }
        private int Multiply(int kung, int fu)
        {
            int kungFu = kung * fu;
            return kungFu;
        }
        private int Divide(int kung, int fu)
        {
            int kungFu = kung / fu;
            return kungFu;
        }


        }

}
