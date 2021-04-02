using EPAM_task_1_2;
using NUnit.Framework;
using System;

namespace Task_1_2_test
{
    [TestFixture]
    public class MaxNumberTest
    {
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 3, TestName ="Test1")]
        [TestCase(new int[] { 87, -22, 0,25,73 }, ExpectedResult = 87, TestName = "Test1")]
        [TestCase(new int[] { 1024, Int32.MaxValue, Int32.MinValue }, ExpectedResult = Int32.MaxValue, TestName = "Test1")]
        [TestCase(new int[] { 6324, 23452, 123 }, ExpectedResult = 23452, TestName = "Test1")]

        public int Test1(int[] array)
        {
        var searcher = new MaxNumberSearcher();
        return searcher.Seek(array);
        }
    }
}