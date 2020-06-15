using FizzBuzzerApp.AppTypes;
using FizzBuzzerApp.Tests.TestData;
using FluentAssertions;
using Xunit;

namespace FizzBuzzerApp.Tests
{
    public class FizzBuzzerTests
    {
        [Theory()]
        [ClassData(typeof(FizzBuzzTestData))]
        public void FizzBuzz_Inputs_CorrectedTranslated(int inputValue, string expectedResult)
        {
            // Arrange/act/assert
            new FizzBuzzer().FizzBuzz(inputValue).Should().Be(expectedResult);
        }
    }
}
