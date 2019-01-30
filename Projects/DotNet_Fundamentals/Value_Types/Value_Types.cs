using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Value_Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            //Character
            char c = 'a';

            //Boolean
            bool on = false;
            bool off = true;

            //Numbers
            byte by = 255;

            int intMin = -2147483648;
            int intMax = 2147483647;

            short sh = 32000;
            long l = 98787;

            float floatExample = 1.978f;
            double doubleExample = 0.9998d;
            decimal decimalExample = 9.8989m;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
        }

        [TestMethod]
        public void Declaration()
        {
            byte smallNumber;
            int number;
            bool statement;
            decimal money;
            short small;
        }

        [TestMethod]
        public void Declaration_Than_Initialization()
        {
            byte smallNumber;
            int number;
            bool statement;
            decimal money;
            short small;



            smallNumber = 5;
            number = 500;
            statement = true;
            money = 8000.56m;
            small = 30000;
        }
        [TestMethod]
        public void DeclarationAndInitialization()
        {
            byte smallNumber = 5;
            int number = 500;
            bool statement = true;
            decimal money = 8000.56m;
            short small = 30000;

        }
       
    }
}
