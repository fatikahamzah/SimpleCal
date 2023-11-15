using NUnit.Framework;
using SimpleConsoleApp;
using System;

namespace SimpleConsoleApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            double result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtraction()
        {
            double result = calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestMultiplication()
        {
            double result = calculator.Multiply(7, 2);
            Assert.AreEqual(14, result);
        }

        [Test]
        public void TestDivision()
        {
            double result = calculator.Divide(15, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
    }
}

