using NUnit.Framework;
using EPAM_task_6_5;

namespace Task_6_5_test
{
    public class Tests
    { 


        [TestCase("The greatest victory is that which requires no battle", ExpectedResult = "battle no requires which that is victory greatest The")]
        public string ReverseTest(string rev)
        {
            var reverser = new StringReverser();
            return reverser.Reverse(rev);
        }
    }
}