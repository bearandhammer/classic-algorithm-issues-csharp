using UnitTests.Shared;

namespace FizzBuzzerApp.Tests.TestData
{
    public class OutOfRangeInputValues : GenericTheoryData<(string, string), bool>
    {
        public OutOfRangeInputValues()
        {
            Add(("-1", "0"), false);
            Add(("0", "-1"), false);
            Add(("101", "0"), false);
            Add(("0", "101"), false);

            //Add(new Tuple<string, string>("-1", "0"), false);
            //Add(new Tuple<string, string>("0", "-1"), false);
            //Add(new Tuple<string, string>("101", "0"), false);
            //Add(new Tuple<string, string>("0", "101"), false);
        }
    }
}
