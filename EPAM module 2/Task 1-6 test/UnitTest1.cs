using EPAM_task_1_6;
using NUnit.Framework;
using System;

namespace Task_1_6_test
{
    public class FilterTests
    {

        [TestCase(new int[] { 1, 2, 3 }, 1, ExpectedResult = new int[] { 1 }, TestName = "FilterDigitTest")]
        [TestCase(new int[] { 87, -22, 0, 25, 40 }, 0, ExpectedResult = new int[] { 0 , 40 }, TestName = "FilterDigitTest")]
        [TestCase(new int[] { 1, 7, 17, 23, 56, 87, 79, 178567 }, 7, ExpectedResult = new int[] { 7,17,87,79,178567}, TestName = "FilterDigitTest")]

        public int[] FilterDigitTest(int[] array, int digit)
        {
            var filter = new Filter();
            return filter.FilterDigit(array, digit);
        }
    }
}