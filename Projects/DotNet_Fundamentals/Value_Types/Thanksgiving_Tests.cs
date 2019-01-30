using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThanksgivingConsole;

namespace Value_Types
{
    [TestClass]
    public class Thanksgiving_Tests
    {
        [TestMethod]
        public void Thanksgiving_Course_ShouldBeCorrectString()
        {
            Thanksgiving meal = new Thanksgiving();
            meal.MainCourse = "Turkey";

            string actual = meal.MainCourse;
            string expected = "Turkey";

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Thanksgiving_Guests_ShouldBeCorrectInt()
        {
            Thanksgiving meal = new Thanksgiving();
            meal.Guests = 10;

            int actualTwo = meal.Guests;
            int expectedTwo = 10;

            Assert.AreEqual(expectedTwo, actualTwo);

        }
        [TestMethod]
        public void Thanksgiving_MealIsVegan_ShouldReturnFalse()
        {
            Thanksgiving meal = new Thanksgiving();
            meal.Vegan = false;

            bool actualThree = meal.Vegan;
            bool expectedThree = false;

            Assert.AreEqual(expectedThree, actualThree);
        }
        [TestMethod]
        public void Thanksgiving_SideDish_ShouldBeCorrectString()
        {
            Thanksgiving meal = new Thanksgiving();
            meal.SideDish = "Mashed Potatoes";

            string actualFour = meal.SideDish;
            string expectedFour = "Mashed Potatoes";

            Assert.AreEqual(expectedFour, actualFour);

        }
    }
}
