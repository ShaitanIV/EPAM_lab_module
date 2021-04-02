using NUnit.Framework;
using EPAM_task_6_1;
using System;

namespace Task_6_1_test
{
    public class Tests
    {


        [TestCase("Jhon","+1234",1000,true,true,true, ExpectedResult ="Customer record:Jhon,+1234,1000")]
        [TestCase("Jhon", "+1234", 1000, true, false, true, ExpectedResult = "Customer record:Jhon,1000")]
        [TestCase(null, null, 1000, true, true, true, ExpectedResult = "Customer record:1000")]
        [TestCase("Jhon", "+1234", 1000, false, false, false, ExpectedResult = null)]
        public string Test1(string name, string phone, decimal revenue, bool inname, bool inphone, bool inrev)
        {
            var cust = new Customer(name,phone,revenue);
            return cust.CustomerToString(inname, inphone, inrev);
        }
    }
}