using EPAM_task_1_1;
using NUnit.Framework;
using System;

namespace Task_1_1_test
{
    [TestFixture]
    public class Task_1_1
    {

        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        public int Test1(int fnumber, int snumber, int i, int j)
        {
            var testUnite = new StringUnite();
            return testUnite.Unite(fnumber, snumber, i, j);
        }
    }
}