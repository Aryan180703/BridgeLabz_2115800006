using NUnit.Framework;
using StringUtilityApp;
using System;

namespace StringUtilityTests {
    [TestFixture]
    public class StringUtilsTests {
        private StringUtils stringUtils;

        [SetUp]
        public void Setup() {
            stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_ValidString_ReturnsReversed() {
            string result = stringUtils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void Reverse_EmptyString_ReturnsEmpty() {
            string result = stringUtils.Reverse("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void Reverse_NullString_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => stringUtils.Reverse(null));
        }

        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue() {
            bool result = stringUtils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse() {
            bool result = stringUtils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue() {
            bool result = stringUtils.IsPalindrome("");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NullString_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => stringUtils.IsPalindrome(null));
        }

        [Test]
        public void ToUpperCase_ValidString_ReturnsUpperCase() {
            string result = stringUtils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }

        [Test]
        public void ToUpperCase_EmptyString_ReturnsEmpty() {
            string result = stringUtils.ToUpperCase("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void ToUpperCase_NullString_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => stringUtils.ToUpperCase(null));
        }
    }
}
