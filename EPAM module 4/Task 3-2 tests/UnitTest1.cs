using EPAM_task_3_2;
using NUnit.Framework;

namespace Task_3_2_tests
{
    public class TestsGCD
    {
        [TestCase(new int[] { 8, 4, 16, 24, 48 }, ExpectedResult = 4)]
        [TestCase(new int[] { 8, 3, 16, 24, 48 }, ExpectedResult = 1)]
        public int GCDEuclid(int[] array, bool fill = false)
        {
            var GCD = new GreatesCommonDivisor();
            return GCD.Euclid(array, fill);
        }

        [TestCase(new int[] { 8, 4, 16, 24, 48 }, ExpectedResult = 4)]
        [TestCase(new int[] { 8, 3, 16, 24, 48 }, ExpectedResult = 1)]
        public int GCDBinary(int[] array, bool fill = false)
        {
            var GCD = new GreatesCommonDivisor();
            return GCD.Euclid(array, fill); 
        }
    }
}