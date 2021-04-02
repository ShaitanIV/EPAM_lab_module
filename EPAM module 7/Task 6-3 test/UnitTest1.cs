using NUnit.Framework;
using EPAM_task_6_3;

namespace Task_6_3_test
{
    public class Tests
    {


        [TestCase("www.example.com", "key","value", ExpectedResult= "www.example.com?key=value")]
        [TestCase("www.example.com?key=value", "key2", "value2", ExpectedResult = "www.example.com?key=value&key2=value2")]
        [TestCase("www.example.com?key=oldValue", "key", "newValue", ExpectedResult = "www.example.com?key=newValue")]
        public string UrlChangerTest(string url, string key, string parameter)
        {
            var changer = new UrlEditor();
            return changer.AddOrChangeUrlParameter(url, key, parameter);
        }
    }
}