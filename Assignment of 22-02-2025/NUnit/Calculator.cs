using NUnit.Framework;
using CalculatorApp;
using System;

namespace CalculatorTests {
    [TestFixture]
    public class CalculatorTests {
        private Calculator calculator;

        [SetUp]
        public void Setup() {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum() {
            int result = calculator.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference() {
            int result = calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct() {
            int result = calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsQuotient() {
            int result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_DivisionByZero_ThrowsException() {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
