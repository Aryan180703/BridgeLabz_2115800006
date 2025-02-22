using NUnit.Framework;
using System;
using PasswordValidatorApp;

namespace PasswordValidatorTests {
    [TestFixture]
    public class PasswordValidatorTests {
        private PasswordValidator passwordValidator;

        [SetUp]
        public void Setup() {
            passwordValidator = new PasswordValidator();
        }

        [TestCase("StrongPass1")]
        [TestCase("Password123")]
        [TestCase("AbcdefG1")]
        public void IsValid_ValidPasswords_ReturnsTrue(string password) {
            bool result = passwordValidator.IsValid(password);
            Assert.IsTrue(result);
        }

        [TestCase("Pass1")]
        [TestCase("1234567")]
        [TestCase("Short1")]
        public void IsValid_InvalidLength_ThrowsArgumentException(string password) {
            var ex = Assert.Throws<ArgumentException>(() => passwordValidator.IsValid(password));
            Assert.AreEqual("Password must be at least 8 characters long.", ex.Message);
        }

        [TestCase("password1")]
        [TestCase("12345678")]
        [TestCase("lowercase1")]
        public void IsValid_NoUppercase_ThrowsArgumentException(string password) {
            var ex = Assert.Throws<ArgumentException>(() => passwordValidator.IsValid(password));
            Assert.AreEqual("Password must contain at least one uppercase letter.", ex.Message);
        }

        [TestCase("Password")]
        [TestCase("NoDigitsHere")]
        [TestCase("UppercaseOnly")]
        public void IsValid_NoDigit_ThrowsArgumentException(string password) {
            var ex = Assert.Throws<ArgumentException>(() => passwordValidator.IsValid(password));
            Assert.AreEqual("Password must contain at least one digit.", ex.Message);
        }
    }
}
