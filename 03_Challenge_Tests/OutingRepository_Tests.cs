using System;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class OutingRepository_Tests
    {
        [TestMethod]
        public void OutingRepository_AddOuting_ShouldReturnCorrectCount()
        {
            OutingRepository _outingRepo = new OutingRepository();
            Outing outing = new Outing();
            Outing outingTwo = new Outing();
            Outing outingThree = new Outing();

            _outingRepo.AddOutingToList(outing);
            _outingRepo.AddOutingToList(outingTwo);
            _outingRepo.AddOutingToList(outingThree);

            int actual = _outingRepo.GetOutings().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OutingRepository_CalculateCostByType_ShouldBeCorrectCost()
        {
            OutingRepository _outingRepo = new OutingRepository();
            Outing outing = new Outing();
            Outing outingTwo = new Outing();
            Outing outingThree = new Outing();

            _outingRepo.AddOutingToList(outing);
            _outingRepo.AddOutingToList(outingTwo);
            _outingRepo.AddOutingToList(outingThree);

            outing.TypeOfEvent = EventType.Golf;
            outingTwo.TypeOfEvent = EventType.Golf;
            outingThree.TypeOfEvent = EventType.Bowling;

            outing.TotalCost = 200;
            outingTwo.TotalCost = 200;
            outingThree.TotalCost = 100;

            decimal actual = _outingRepo.CalculateCostOfEventType(EventType.Golf);
            decimal expected = 400;

            Assert.AreEqual(expected, actual);

            decimal actualTwo = _outingRepo.CalculateCostOfEventType(EventType.Bowling);
            decimal expectedTwo = 100;

            Assert.AreEqual(expectedTwo, actualTwo);

        }
        [TestMethod]
        public void OutingRepository_CalculateTotalCost_ShouldBeCorrectValue()
        {
            OutingRepository _outingRepo = new OutingRepository();
            Outing outing = new Outing();
            Outing outingTwo = new Outing();
            Outing outingThree = new Outing();

            _outingRepo.AddOutingToList(outing);
            _outingRepo.AddOutingToList(outingTwo);
            _outingRepo.AddOutingToList(outingThree);

            outing.TotalCost = 200;
            outingTwo.TotalCost = 200;
            outingThree.TotalCost = 100;

            decimal actual = _outingRepo.CalculateCostOfAllEvents();
            decimal expected = 500;

            Assert.AreEqual(expected, actual);

        }
    }
}
