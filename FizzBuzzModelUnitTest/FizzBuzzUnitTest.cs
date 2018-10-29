using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;
using System.Collections.Generic;

namespace FizzBuzzModelUnitTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        private IFizzBuzzModel _IFizzBuzzModel;

        private void SetingFizzBuzzModelObject()
        {
            _IFizzBuzzModel = new FizzBuzzModel();
        }

        private void SetingFizzBuzzModelObject(List<NumTokenPair> NumTokenPairs)
        {
            _IFizzBuzzModel = new FizzBuzzModel(NumTokenPairs);
        }
        private static string[] classicFizzBuzzExpectedResult = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
        private static string[] customPositiveNumTokenPairsExpectedResult = new string[] { "Frog","Duck", "Chicken" };
        private static string[] negativeValueExpectedResult = new string[] { "-1", "-2", "Fizz", "-4", "Buzz", "Fizz", "-7", "-8", "Fizz", "Buzz", "-11", "Fizz", "-13", "-14", "FizzBuzz" };

        private static List<NumTokenPair> customNumTokenPairs = new List<NumTokenPair>() {
            new NumTokenPair(4, "Frog"),
            new NumTokenPair(13, "Duck" ),
            new NumTokenPair(9, "Chicken")
        };

        [TestMethod]
        public void FizzBuzzModel_Null_NumTokenPair_List_Input()
        {
            Assert.ThrowsException<InvalidProgramException>(() => SetingFizzBuzzModelObject(null));
        }

        [TestMethod]
        public void FizzBuzzModel_Zero_NumTokenPair()
        {
            Assert.ThrowsException<InvalidOperationException>(() => new NumTokenPair(0, "Tarun"));
        }

        [TestMethod]
        public void Classic_FizzBuzz_Test()
        {
            SetingFizzBuzzModelObject();
            for (int i = 1; i < 15; i++)
            {
                var result = _IFizzBuzzModel.Process(i);
                Assert.AreEqual(result, classicFizzBuzzExpectedResult[i - 1]);
            }
        }

        [TestMethod]
        public void FizzBuzzModel_Custom_Positive_NunTokenPair()
        {
            SetingFizzBuzzModelObject(customNumTokenPairs);
            var PositiveValue = new int[] { 4, 13, 9 };
            for (int i = 0; i < PositiveValue.Length; i++)
            {
                var result = _IFizzBuzzModel.Process(PositiveValue[i]);
                Assert.AreEqual(result, customPositiveNumTokenPairsExpectedResult[i]);
            }
        }

        [TestMethod]
        public void FizzBuzzModel_NegativeValue()
        {
            SetingFizzBuzzModelObject();
            var NegativeValue = new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, -11, -12, -13, -14, -15 };
            for (int i = 0; i < NegativeValue.Length; i++)
            {
                var result = _IFizzBuzzModel.Process(NegativeValue[i]);

                Assert.AreEqual(result, negativeValueExpectedResult[i]);
            }
        }
    }
}
