using FizzBuzzerApp.Constants;
using UnitTests.Shared;

namespace FizzBuzzerApp.Tests.TestData
{
    /// <summary>
    /// FizzBuzz specific test data.
    /// </summary>
    public class FizzBuzzTestData : GenericTheoryData<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzTestData"/> class.
        /// Constructs inline test data as required.
        /// </summary>
        public FizzBuzzTestData()
        {
            Add(0, FizzBuzzResult.FizzBuzz);
            Add(1, "1");
            Add(2, "2");
            Add(3, FizzBuzzResult.Fizz);
            Add(4, "4");
            Add(5, FizzBuzzResult.Buzz);
            Add(6, FizzBuzzResult.Fizz);
            Add(7, "7");
            Add(8, "8");
            Add(9, FizzBuzzResult.Fizz);
            Add(10, FizzBuzzResult.Buzz);
            Add(11, "11");
            Add(12, FizzBuzzResult.Fizz);
            Add(13, "13");
            Add(14, "14");
            Add(15, FizzBuzzResult.FizzBuzz);
        }
    }
}
