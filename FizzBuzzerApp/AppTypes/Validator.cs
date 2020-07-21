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
            inputValues.StartValue = 0;
            inputValues.EndValue = 0;

            if (!int.TryParse(rawStartValue, out int parsedStartValue) 
                || !int.TryParse(rawEndValue, out int parsedEndValue))
            {
                return false;
            }

            if (parsedStartValue < 0
                || parsedEndValue > 100
                || parsedStartValue >= parsedEndValue)
            {
                return false;
            }

            inputValues.StartValue = parsedStartValue;
            inputValues.EndValue = parsedEndValue;

            return true;
        }
    }
}
