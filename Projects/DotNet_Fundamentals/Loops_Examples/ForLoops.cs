using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loops_Examples
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void ExampleOne()
        {
            //for Start      Condition   What we do between each loop
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ExampleTwo()
        {
            int number = 136;
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");

                else if (i % 3 == 0)
                    Console.WriteLine("fizz");

                else if (i % 5 == 0)
                    Console.WriteLine("buzz");

                else
                    Console.WriteLine(i);
            }
        }
    }
}
