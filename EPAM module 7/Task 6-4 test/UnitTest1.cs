using NUnit.Framework;
using EPAM_task_6_4;
using System.Linq;
using System.Collections.Generic;

namespace Task_6_4_test
{
    public class Tests
    {

        [TestCase("AAAABBBCCDAABBB", "ABCDAB")]
        [TestCase("ABBCcAD", "ABCcAD")]
        [TestCase("12233", "123")]

        public void TestString(string str, string res)
        {
            var formater = new StringFormater();
            var calc = formater.UniqueInOrder<char>(str);
            Assert.That(Enumerable.SequenceEqual(calc.OrderBy(t => t), res.OrderBy(t => t)));

        }

        private static readonly object[] testSource =
        {
            new object[] {new List<double> { 1.1, 2.2, 2.2, 3.3 }, new List<double> { 1.1, 2.2, 3.3 } }
        };

        [TestCaseSource("testSource")]

        public void TestDecimal(List<double> sec, List<double> res)
        {
            var formater = new StringFormater();
            var calc = formater.UniqueInOrder<double>(sec);
            Assert.That(Enumerable.SequenceEqual(calc.OrderBy(t => t), res.OrderBy(t => t)));

        }

    }
}