using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loops_Examples
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void ExampleOne()
        {
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++; 
            }

        }
        [TestMethod]
        public void ExampleTwo()
        {
            int i = 0;
            while (true)
            {
                if (i < 10)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
