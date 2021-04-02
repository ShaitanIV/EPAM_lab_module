using EPAM_task_1_3;
using NUnit.Framework;

namespace Task_1_3_test
{
    public class ElementSearcherTest
    {

        [TestCase(new double[] { 1, 2, 3 }, ExpectedResult = -1, TestName = "GoldenMiddleTest")]
        [TestCase(new double[] { 87, -22, 0, 25, 40 }, ExpectedResult = 2, TestName = "GoldenMiddleTest")]
        [TestCase(new double[] { 1024, double.MaxValue, double.MinValue }, ExpectedResult = -1, TestName = "GoldenMiddleTest")]
        [TestCase(new double[] { 6324, 23452, 123 }, ExpectedResult = -1, TestName = "GoldenMiddleTest")]

        public int GoldenMiddleTest(double[] array)
        {
            var searcher = new ElementSearcher();
            return searcher.GoldenMiddle(array);
        }
    }
}