using NUnit.Framework;
using TemperatureConverterApp;

namespace TemperatureConverterTests {
    [TestFixture]
    public class TemperatureConverterTests {
        private TemperatureConverter temperatureConverter;

        [SetUp]
        public void Setup() {
            temperatureConverter = new TemperatureConverter();
        }

        [TestCase(0, ExpectedResult = 32)]
        [TestCase(100, ExpectedResult = 212)]
        [TestCase(-40, ExpectedResult = -40)]
        [TestCase(37, ExpectedResult = 98.6)]
        [TestCase(25, ExpectedResult = 77)]
        public double CelsiusToFahrenheit_ValidInput_ReturnsExpected(double celsius) {
            return temperatureConverter.CelsiusToFahrenheit(celsius);
        }

        [TestCase(32, ExpectedResult = 0)]
        [TestCase(212, ExpectedResult = 100)]
        [TestCase(-40, ExpectedResult = -40)]
        [TestCase(98.6, ExpectedResult = 37)]
        [TestCase(77, ExpectedResult = 25)]
        public double FahrenheitToCelsius_ValidInput_ReturnsExpected(double fahrenheit) {
            return temperatureConverter.FahrenheitToCelsius(fahrenheit);
        }
    }
}
