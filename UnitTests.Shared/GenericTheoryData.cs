namespace UnitTests.Shared
{
    /// <summary>
    /// Represents a generic piece of input/expected output
    /// theory data 'pairs'.
    /// </summary>
    /// <typeparam name="TInput">The input.</typeparam>
    /// <typeparam name="TExpectation">The expected output.</typeparam>
    public class GenericTheoryData<TInput, TExpectation> : TheoryData
    {
        /// <summary>
        /// Adds input/expected output pairs.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expectedValue">The expected output.</param>
        public void Add(TInput input, TExpectation expectedValue)
        {
            AddRow(input, expectedValue);
        }
    }
}
