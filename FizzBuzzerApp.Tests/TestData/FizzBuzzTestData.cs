using UnitTests.Shared;

namespace FizzBuzzerApp.Tests.TestData
{
    /// <summary>
    /// FizzBuzz specific test data.
    /// </summary>
    public class FizzBuzzTestData : GenericTheoryData<int, string>
    {
        /// <summary>
        /// Represents the 'Fizz' result.
        /// </summary>
        private const string Fizz = "Fizz";

        /// <summary>
        /// Represents the 'Buzz' result.
        /// </summary>
        private const string Buzz = "Buzz";

        /// <summary>
        /// Represents the 'FizzBuzz' result.
        /// </summary>
        private const string FizzBuzz = "FizzBuzz";

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzTestData"/> class.
        /// Constructs inline test data as required.
        /// </summary>
        public FizzBuzzTestData()
        {
            Add(0, FizzBuzz);
            Add(1, "1");
            Add(2, "2");
            Add(3, Fizz);
            Add(4, "4");
            Add(5, Buzz);
            Add(6, Fizz);
            Add(7, "7");
            Add(8, "8");
            Add(9, "9");
            Add(10, Buzz);
            Add(11, "11");
            Add(12, Fizz);
            Add(13, "13");
            Add(14, "14");
            Add(15, FizzBuzz);
        }
    }
}
