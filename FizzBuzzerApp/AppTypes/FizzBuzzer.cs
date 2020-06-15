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
            ? "FizzBuzz" : number % 3 == 0
            ? "Fizz" : number % 5 == 0
            ? "Buzz" : number.ToString();
    }
}
