using NUnit.Framework;
using System;
using UserRegistrationApp;

namespace UserRegistrationTests {
    [TestFixture]
    public class UserRegistrationTests {
        private UserRegistration userRegistration;

        [SetUp]
        public void Setup() {
            userRegistration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInputs_ReturnsSuccessMessage() {
            string result = userRegistration.RegisterUser("AryanUpadhyay", "aryan@example.com", "password123");
            Assert.AreEqual("User registered successfully! Welcome, Aryan Upadhyay!", result);
        }

        [TestCase("", "aryan@example.com", "password123")]
        [TestCase("Ar", "aryan@example.com", "password123")]
        [TestCase("   ", "aryan@example.com", "password123")]
        public void RegisterUser_InvalidUsername_ThrowsArgumentException(string username, string email, string password) {
            var ex = Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser(username, email, password));
            Assert.AreEqual("Username must be at least 3 characters long.", ex.Message);
        }

        [TestCase("AryanUpadhyay", "", "password123")]
        [TestCase("AryanUpadhyay", "aryanexample.com", "password123")]
        [TestCase("AryanUpadhyay", "aryan@.com", "password123")]
        [TestCase("AryanUpadhyay", "aryan@com", "password123")]
        public void RegisterUser_InvalidEmail_ThrowsArgumentException(string username, string email, string password) {
            var ex = Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser(username, email, password));
            Assert.AreEqual("Invalid email format.", ex.Message);
        }

        [TestCase("AryanUpadhyay", "aryan@example.com", "")]
        [TestCase("AryanUpadhyay", "aryan@example.com", "12345")]
        [TestCase("AryanUpadhyay", "aryan@example.com", "     ")]
        public void RegisterUser_InvalidPassword_ThrowsArgumentException(string username, string email, string password) {
            var ex = Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser(username, email, password));
            Assert.AreEqual("Password must be at least 6 characters long.", ex.Message);
        }
    }
}
