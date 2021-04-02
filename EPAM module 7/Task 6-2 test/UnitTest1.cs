using NUnit.Framework;
using EPAM_task_6_2;

namespace Task_6_2_test
{
    public class Tests
    {

        [TestCase("a an the of", "a clash of KINGS", ExpectedResult = "A Clash of Kings")]
        [TestCase("The In", "THE WIND IN THE WILLOWS", ExpectedResult = "The Wind in the Willows")]
        [TestCase(null, "the quick brown fox", ExpectedResult = "The Quick Brown Fox")]

        public string TitleFormaterTest(string wordsToIgnore, string title)
        {
            var formater = new StringFormater();
            return formater.ToTitle(title, wordsToIgnore);
        }
    }
}