using NUnit.Framework;
using ExceptionHandlingApp;
using System;

namespace ExceptionHandlingTests {
    [TestFixture]
    public class MathOperationsTests {
        private MathOperations mathOperations;

        [SetUp]
        public void Setup() {
            mathOperations = new MathOperations();
        }

        [Test]
        public void Divide_NonZeroDivisor_ReturnsQuotient() {
            int result = mathOperations.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_DivisorIsZero_ThrowsArithmeticException() {
            var ex = Assert.Throws<ArithmeticException>(() => mathOperations.Divide(10, 0));
            Assert.AreEqual("Cannot divide by zero.", ex.Message);
        }

        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient() {
            int result = mathOperations.Divide(-10, 2);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Divide_ZeroNumerator_ReturnsZero() {
            int result = mathOperations.Divide(0, 5);
            Assert.AreEqual(0, result);
        }
    }
}
