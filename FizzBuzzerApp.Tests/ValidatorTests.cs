using FizzBuzzerApp.AppTypes;
using FizzBuzzerApp.Interfaces;
using FizzBuzzerApp.Tests.TestData;
using FluentAssertions;
using Xunit;

namespace FizzBuzzerApp.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void TryParseInput_RawStartEndValues_NotBothIntegers_Returns_False()
        {
            // Arrange
            IValidator validatorUnderTest = new Validator();
            string intValue = "5", nonIntValue = "zero";

            // Act/Assert
            validatorUnderTest.TryParseInput(nonIntValue, intValue, out _).Should().BeFalse();
            validatorUnderTest.TryParseInput(intValue, nonIntValue, out _).Should().BeFalse();
            validatorUnderTest.TryParseInput(string.Empty, null, out _).Should().BeFalse();
            validatorUnderTest.TryParseInput(null, string.Empty, out _).Should().BeFalse();
            validatorUnderTest.TryParseInput(null, null, out _).Should().BeFalse();
            validatorUnderTest.TryParseInput(string.Empty, string.Empty, out _).Should().BeFalse();
        }

        [Theory]
        [ClassData(typeof(OutOfRangeInputValues))]
        public void TryParseInput_RawStartEndValues_OutsideZeroToOneHundredRange_Returns_False((string RawStartValue, string RawEndValue) inputValues, bool expectedResult)
        {
            // Arrange/Act/Assert
            new Validator().TryParseInput(inputValues.RawEndValue, inputValues.RawEndValue, out _).Should().Be(expectedResult);
        }

        [Fact]
        public void TryParseInput_RawStartEndValues_StartGreaterThanEnd_Returns_False()
        {
            new Validator().TryParseInput("2", "1", out _).Should().BeFalse();
        }

        [Fact]
        public void TryParseInput_RawStartEndValues_InRange_StartLessThanEnd_Returns_True()
        {
            // TODO
            new Validator().TryParseInput("1", "2", out (int StartValue, int EndValue) inputValues).Should().BeTrue();
            inputValues.StartValue.Should().Be(1);
            inputValues.EndValue.Should().Be(2);
        }
    }
}
