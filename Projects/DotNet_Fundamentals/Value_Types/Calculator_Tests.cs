using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void Calculator_AddTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValue = calcRepo.AddTwoNumbers(4, 3);
            int expected = 7;

            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_SubtractTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValueTwo = calcRepo.SubtractTwoNumbers(4, 3);
            int expectedTwo = 1;

            Assert.AreEqual(expectedTwo, actualValueTwo);
        }

        [TestMethod]
        public void Calculator_MultiplyTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValueThree = calcRepo.MultiplyTwoNumbers(4, 3);
            int expectedThree = 12;

            Assert.AreEqual(expectedThree, actualValueThree);

        }

        [TestMethod]
        public void Calculator_DivideTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValueFour = calcRepo.DivideTwoNumbers(10, 5);
            int expectedFour = 2;

            Assert.AreEqual(expectedFour, actualValueFour);

        }
    }
}



