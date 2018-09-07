using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTestProject
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [Description("This test method checks if all numbers which are multiples of 3 are getting coverted to Fizz string")]
        public void CheckAllStringsForMultipleOfOnlyThree()
        {
            // Arrange
            List<int> multipleOfThree = GeneratorHelper.GenerateMultiplesofOnlyThree(300);
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz(multipleOfThree);

            // Act
            List<string> fizz = fb.GetFizzBuzzResult();

            //Assert
            Assert.IsTrue(fizz.All(p => p == "Fizz"), "Some strings are not Fizz");
        }

        [TestMethod]
        [Description("This test method checks if all numbers which are multiples of 5 are getting coverted to Buzz string")]
        public void CheckAllStringsForMultipleOfOnlyFive()
        {
            // Arrange
            List<int> multipleOfFive = GeneratorHelper.GenerateMultiplesofOnlyFive(300);
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz(multipleOfFive);

            // Act
            List<string> fizz = fb.GetFizzBuzzResult();

            //Assert
            Assert.IsTrue(fizz.All(p => p == "Buzz"), "Some strings are not Buzz");
        }

        [TestMethod]
        [Description("This test method checks if all numbers which are multiples of 3 and 5 are getting coverted to fizzbuzz string")]
        public void CheckAllStringsForMultipleOfOnlyFiveandThree()
        {
            // Arrange
            List<int> multipleOfFiveandThree = GeneratorHelper.GenerateMultipleofThreeAndFive(300);
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz(multipleOfFiveandThree);

            // Act
            List<string> fizz = fb.GetFizzBuzzResult();

            //Assert
            Assert.IsTrue(fizz.All(p => p == "FizzBuzz"), "Some strings are not FizzBuzz");
        }

        [TestMethod]
        [Description("This test method checks if all numbers which non multiples of 3 and 5 are not getting coverted to fizz or buzz or fizzbuzz strings")]
        public void CheckAllStringsForMultipleOfOnlyNeitherFiveandNorThree()
        {
            // Arrange
            List<int> multipleOfFiveandThree = GeneratorHelper.GenerateMultipleofNeitherThreeAndNorFive(300);

            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz(multipleOfFiveandThree);

            // Act
            List<string> fizz = fb.GetFizzBuzzResult();

            //Assert
            int number;
            Assert.IsTrue(fizz.All(p => int.TryParse(p, out number)), "Some strings are not numbers");
        }
    }
}
