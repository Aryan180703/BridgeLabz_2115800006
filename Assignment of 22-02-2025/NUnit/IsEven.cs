using NUnit.Framework;
using IsEvenApp;

namespace IsEvenTests
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils numberUtils;

        [SetUp]
        public void Setup()
        {
            numberUtils = new NumberUtils();
        }

        [TestCase(2, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool IsEven_ParameterizedTests(int number)
        {
            return numberUtils.IsEven(number);
        }
    }
}
