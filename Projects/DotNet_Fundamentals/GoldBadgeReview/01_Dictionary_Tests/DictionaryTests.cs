using System;
using System.Collections.Generic;
using _01_Dictionaries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Dictionary_Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DictionaryWork dictWork = new DictionaryWork();
        }
        [TestMethod]
        public void DictionaryChallengeTests()
        {
            DictionaryChallenge dC = new DictionaryChallenge();
            Dictionary<int, List<int>> dictionary = dC.GetDictionary();

            dictionary.Add(12, new List<int> { 3, 6, 9, 1, 2, 5 });

            var expected = 26;
            var actual = dC.GetSum(12);

            Assert.AreEqual(expected, actual);
        }
    }
}