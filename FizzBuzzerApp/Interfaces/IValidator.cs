namespace FizzBuzzerApp.Interfaces
{
    /// <summary>
    /// Interface for any FizzBuzzer implementing types.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Validates user input for a FizzBuzzing operation.
        /// </summary>
        /// <param name="rawStartValue">Denotes the raw start value that the User wants to begin processing at.</param>
        /// <param name="rawEndValue">Denotes the raw end value that the User wants to end processing at.</param>
        /// <param name="inputValues">An output named tuple for representing raw input values converted to integers (if validation succeeds).</param>
        /// <returns>A boolean that represents if validation succeeds or not.</returns>
        bool TryParseInput(string rawStartValue, string rawEndValue, out (int StartValue, int EndValue) inputValues);
    }
}
