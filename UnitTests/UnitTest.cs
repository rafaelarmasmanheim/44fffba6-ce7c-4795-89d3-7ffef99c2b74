using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CandidateTest;

namespace CandidateUnitTests
{
    [TestClass]
    public class CandidateUnitTests
    {
        [TestMethod]
        public void AverageIsCorrect_TwoValues()
        {
            var calculatedValue = TestFunctions.Average(new List<int>(){2, 1});
            var expectedValue = 1.5;
            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }

        [TestMethod]
        public void AverageIsCorrect_ThreeValues()
        {
            var calculatedValue = TestFunctions.Average(new List<int>(){3, 2, 1});
            var expectedValue = 2;
            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }

        [TestMethod]
        public void AverageIsCorrect_FourValues()
        {
            var calculatedValue = TestFunctions.Average(new List<int>(){10, 11, 12, 13});
            var expectedValue = 11.5;
            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }

        [TestMethod]
        public void NamesAreUnique()
        {
            string[] names1 = { "Ava", "Emma", "Olivia" };
            string[] names2 = { "Olivia", "Sophia", "Emma" };
            string expectedValue = "Sophia, Olivia, Emma, Ava";
            var calculatedValue = string.Join(", ", TestFunctions.UniqueNames(names1, names2));

            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }
        [TestMethod]
        public void PhraseWasReversed()
        {
            var calculatedValue = TestFunctions.ReversePhrase("I want to work for Cox Automotive");
            var expectedValue = "Automotive Cox for work to want I";

            Assert.AreEqual(expectedValue, calculatedValue, "Value is incorrect");
        }
    }
}
