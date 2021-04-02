using NUnit.Framework;
using EPAM_task_6_6;

namespace Task_6_6_test
{
    public class Tests
    {

        [TestCase("1234,3", "1234,3", ExpectedResult ="2468,6")]
        public string SummarizerTest(string fnumber, string snumber)
        {
            var calc = new Calculation();
            return calc.SummaryOfTwoDoubles(fnumber, snumber);
        }
    }
}