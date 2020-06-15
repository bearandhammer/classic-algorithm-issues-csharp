using FizzBuzzerApp.Constants;
using FizzBuzzerApp.Interfaces;

namespace FizzBuzzerApp.AppTypes
{
    /// <summary>
    /// The core class that handles a FizzBuzz operation
    /// on a target value.
    /// </summary>
    public class FizzBuzzer : IFizzBuzzer
    {
        /// <inheritdoc/>
        public string FizzBuzz(int number) =>
            number % 3 == 0 && number % 5 == 0
            ? FizzBuzzResult.FizzBuzz
            : number % 3 == 0 ? FizzBuzzResult.Fizz
            : number % 5 == 0 ? FizzBuzzResult.Buzz
            : number.ToString();
    }
}
