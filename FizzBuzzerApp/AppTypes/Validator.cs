using FizzBuzzerApp.Interfaces;
using System;

namespace FizzBuzzerApp.AppTypes
{
    /// <summary>
    /// A fixed validator for FizzBuzzing.
    /// </summary>
    public class Validator : IValidator
    {
        /// <inheritdoc/>
        public bool TryParseInput(string rawStartValue, string rawEndValue, out (int StartValue, int EndValue) inputValues)
        {
            throw new NotImplementedException();
        }
    }
}
