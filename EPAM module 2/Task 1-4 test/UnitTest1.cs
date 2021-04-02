using EPAM_task_1_4;
using NUnit.Framework;

namespace Task_1_4_test
{
    public class Tests
    {


        [TestCase("abxd","bsadgew", ExpectedResult ="abxdsgew")]
        [TestCase("abxd", "abxd", ExpectedResult = "abxd")]
        [TestCase("aaAAbxdB", "bsadwW", ExpectedResult = "aAbxdBswW")]
        public string StringUniteTest(string firststr, string secondstr)
        {
            var uniter = new StringConnector();
            return uniter.Unite(firststr, secondstr);
        }
    }
}