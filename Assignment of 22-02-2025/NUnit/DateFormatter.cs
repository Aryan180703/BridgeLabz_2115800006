using NUnit.Framework;
using System;
using DateFormatterApp;

namespace DateFormatterTests
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter dateFormatter;

        [SetUp]
        public void Setup()
        {
            dateFormatter = new DateFormatter();
        }

        [TestCase("2023-12-31", ExpectedResult = "31-12-2023")]
        [TestCase("2024-01-01", ExpectedResult = "01-01-2024")]
        [TestCase("1999-05-15", ExpectedResult = "15-05-1999")]
        public string FormatDate_ValidDates_ReturnsCorrectFormat(string inputDate)
        {
            return dateFormatter.FormatDate(inputDate);
        }

        [TestCase("31-12-2023")]
        [TestCase("12/31/2023")]
        [TestCase("2023/12/31")]
        [TestCase("31/12/2023")]
        [TestCase("2023-13-01")]
        [TestCase("2023-02-30")]
        public void FormatDate_InvalidDates_ShouldThrowFormatException(string inputDate)
        {
            var ex = Assert.Throws<FormatException>(() => dateFormatter.FormatDate(inputDate));
            Assert.AreEqual("Invalid date format. Expected format: yyyy-MM-dd", ex.Message);
        }
    }
}



