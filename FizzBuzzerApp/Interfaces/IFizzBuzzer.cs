namespace FizzBuzzerApp.Interfaces
{
    /// <summary>
    /// Interface for any FizzBuzzer implementing types.
    /// </summary>
    public interface IFizzBuzzer
    {
        /// <summary>
        /// Operates on the input provided to return
        /// a FizzBuzz representation of the target value.
        /// </summary>
        /// <param name="number">The specific target value to return a FizzBuzz representation for.</param>
        /// <returns>'FizzBuzz' if the number is cleanly divisible by 3 & 5, 'Fizz' if the number is cleanly divisible by 3, "Buzz" if the number is cleanly divisible by 5. Otherwise, the number 'ToString' is returned.</returns>
        string FizzBuzz(int number);
    }
}
