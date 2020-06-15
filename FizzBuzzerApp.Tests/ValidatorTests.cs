using FizzBuzzerApp.Tests.TestData;
using Xunit;

namespace FizzBuzzerApp.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void TryParseInput_RawStartEndValues_NotIntegers_Returns_False()
        {
            // TODO
        }

        [Theory]
        [ClassData(typeof(OutOfRangeInputValues))]
        public void TryParseInput_RawStartEndValues_OutsideZeroToOneHundredRange_Returns_False((string RawStartValue, string RawEndValue) inputValues, bool expectedResult)
        {
            // TODO
        }

        [Fact]
        public void TryParseInput_RawStartEndValues_StartGreaterThanEnd_Returns_False()
        {
            // TODO
        }

        [Fact]
        public void TryParseInput_RawStartEndValues_InRange_StartLessThanEnd_Returns_True()
        {
            // TODO
        }
    }
}
