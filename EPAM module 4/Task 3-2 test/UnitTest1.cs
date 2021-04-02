using EPAM_task_3_3;
using NUnit.Framework;

namespace Task_3_2_test
{
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            int? a = 1;
            Assert.That(a.isNull() == false);
            int? b = 0;
            Assert.That(b.isNull() == false);
            object c = null;
            Assert.That(c.isNull() == true);
            string d = null;
            Assert.That(d.isNull() == true);
        }
    }
}