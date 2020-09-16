using NUnit.Framework;
using SimpleStringCalculator.Calculator;
using System;

namespace NUnitTestProject1
{
    //Happy tests
    public class HappyTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("4, 2", 2)]
        [TestCase("16, 2", 8)]
        [TestCase("45, 5", 9)]

        public void Divide_Numbers_ReturnDividing(string input, int result)
        {
            //arrange
            StringCalculator stringCalculator = new StringCalculator();
            int answer = 0;
            //act
            answer = stringCalculator.Divide(input);
            //assert
            Assert.AreEqual(result, answer);
        }

        /*[Test]
        public void Test1()
        {
            StringCalculator s = new StringCalculator();
            Assert.Pass();
        }*/
    }

    //Unhappy tests
    public class UnhappyTests
    {
        [TestCase("0, 0", typeof(DivideByZeroException))]
        [TestCase("null, 2", typeof(ArgumentException))]
        [TestCase("tekst, test", typeof(ArgumentException))]

        public void Divide_EmptyStrings_ReturnZero(string input, int result)
        {
            //arrange
            StringCalculator stringCalculator = new StringCalculator();
            int answer = 0;
            //act
            answer = stringCalculator.Divide(input);
            //assert
            Assert.AreEqual(result, answer);
        }
    }
}