using FizzBuzzerApp.AppTypes;
using FizzBuzzerApp.Interfaces;
using System;

namespace FizzBuzzerApp
{
    /// <summary>
    /// Main Program class entry point for our FizzBuzzer.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point for our FizzBuzzer application
        /// that omits any string arguments (not required).
        /// </summary>
        private static void Main()
        {
            RunFizzBuzzerApp();
        }

        /// <summary>
        /// Core handler for the running FizzBuzz operations.
        /// </summary>
        private static void RunFizzBuzzerApp()
        {
            // Prepare types up front for use (interfaces are overkill for this sample)
            IValidator inputValidator = new Validator();
            IFizzBuzzer fizzBuzzer = new FizzBuzzer();

            // Raw input start/end values (you can specify the range for the FizzBuzz output, between 0 and 100)
            string rawStartValue, rawEndValue;

            do
            {
                // Retrieve raw range values for our FizzBuzzing operation
                rawStartValue = RetrieveInputFromPrompt("Specify the start value: ");
                rawEndValue = RetrieveInputFromPrompt("Specify the end value: ");

                // FizzBuzz to our hearts content (after validating the values)...
                PerformFizzBuzzerOperationRun(inputValidator, fizzBuzzer, rawStartValue, rawEndValue);

                // Should we run the process again?
                Console.WriteLine("Continue FizzBuzzing?");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }

        /// <summary>
        /// Utility helper that prompts for and returns
        /// User input.
        /// </summary>
        /// <param name="prompt">The desired prompt string.</param>
        /// <returns>The user input.</returns>
        private static string RetrieveInputFromPrompt(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Performs a single run (providing FizzBuzz output between the
        /// designated start/end values, if they are in range).
        /// </summary>
        /// <param name="inputValidator">The <see cref="IValidator"/> implementing type controlling how input is checked/parsed.</param>
        /// <param name="fizzBuzzer">The <see cref="IFizzBuzzer"/> implementing type controlling how FizzBuzz operations on a single value are performed.</param>
        /// <param name="rawStartValue">The raw start value (from the User).</param>
        /// <param name="rawEndValue">The raw end value (from the User).</param>
        private static void PerformFizzBuzzerOperationRun(IValidator inputValidator, IFizzBuzzer fizzBuzzer, string rawStartValue, string rawEndValue)
        {
            if (inputValidator.TryParseInput(rawStartValue, rawEndValue, out (int StartValue, int EndValue) inputValues))
            {
                for (int i = inputValues.StartValue = 0; i < inputValues.EndValue; i++)
                {
                    Console.WriteLine($"Result for '{ i }' is: ' { fizzBuzzer.FizzBuzz(i) } '");
                }
            }
            else
            {
                // Input does not meet (our very basic, fixed) rules
                Console.WriteLine("Start/end values must be integers between 0 and 100 (with the end value being greater than the start value).");
            }
        }
    }
}
