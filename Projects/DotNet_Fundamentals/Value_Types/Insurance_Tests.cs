using System;
using Insurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Insurance_Tests
    {
        [TestMethod]
        public void CarMethodOne()
        {
            Car carOne = new Car();
            carOne.Brand = "Jeep";
            carOne.Model = "Wrangler";
            carOne.Year = 2010;
            carOne.TypeOfVehicle = "SUV";
            carOne.Color = "Red";
            carOne.Wheels = 4;
            carOne.HadAccidents = false;
            carOne.Owners = 1;

            Assert.AreEqual("Jeep", carOne.Brand);
            Assert.AreEqual("Wrangler", carOne.Model);
            Assert.AreEqual(2010, carOne.Year);
            Assert.AreEqual("SUV", carOne.TypeOfVehicle);
            Assert.AreEqual("Red", carOne.Color);
            Assert.AreEqual(4, carOne.Wheels);
            Assert.AreEqual(false, carOne.HadAccidents);
            Assert.AreEqual(1, carOne.Owners);
        }
        [TestMethod]
        public void CarMethodTwo()
        {
            Car carTwo = new Car("Ford", "Ranger", 1999, "Truck", "Black", 4, true, 3);

            Assert.AreEqual("Ford", carTwo.Brand);
            Assert.AreEqual("Ranger", carTwo.Model);
            Assert.AreEqual(1999, carTwo.Year);
            Assert.AreEqual("Truck", carTwo.TypeOfVehicle);
            Assert.AreEqual("Black", carTwo.Color);
            Assert.AreEqual(4, carTwo.Wheels);
            Assert.AreEqual(true, carTwo.HadAccidents);
            Assert.AreEqual(3, carTwo.Owners);


        }
        [TestMethod]
        public void Car_Brand_ShouldBeCorrect()
        {
            Car car = new Car();
            car.Brand = "Ford";

            string actual = car.Brand;
            string expected = "Ford";

            Assert.AreEqual(expected, actual);
           

        }
        [TestMethod]
        public void Car_Model_ShouldBeCorrect()
        {
            Car car = new Car();
            car.Model = "Ranger";

            string actual = car.Model;
            string expected = "Ranger";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_Year_ShouldBeCorrect()
        {
            Car car = new Car();
            car.Year = 1999;

            int actual = car.Year;
            int expected = 1999;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_TypeOfVehicle_ShouldBeCorrect()
        {
            Car car = new Car();
            car.TypeOfVehicle = "Truck";

            string actual = car.TypeOfVehicle;
            string expected = "Truck";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_Color_ShouldBeCorrect()
        {
            Car car = new Car();
            car.Color = "Black";

            string actual = car.Color;

        }
    }
}
