using System;
using _02_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class ClaimRepository_Tests
    {
        [TestMethod]
        public void AddClaimToQueue_ShouldReturnCorrectValue()
        {
            ClaimRepository _claimRepo = new ClaimRepository();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            _claimRepo.AddClaimToQueue(claim);
            _claimRepo.AddClaimToQueue(claimTwo);
            _claimRepo.AddClaimToQueue(claimThree);

            int actual = _claimRepo.GetClaims().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveClaimFromQueue_ShouldReturnCorrectValue()
        {
            ClaimRepository _claimRepo = new ClaimRepository();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            _claimRepo.AddClaimToQueue(claim);
            _claimRepo.AddClaimToQueue(claimTwo);
            _claimRepo.AddClaimToQueue(claimThree);

            _claimRepo.RemoveClaim();

            int actual = _claimRepo.GetClaims().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
