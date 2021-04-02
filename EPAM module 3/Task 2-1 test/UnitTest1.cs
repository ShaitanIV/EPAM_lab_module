using EPAM_task_2_1;
using NUnit.Framework;

namespace Task_2_1_test
{
    public class Tests
    {

        [TestCase(1, 5, 0.0001, ExpectedResult = 1.0)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        public double NewtonTest(double number, int root, double acc)
        {
            var finder = new RootFinder();
            return finder.NewtonMethod(number, root, acc);
        }
    }
}