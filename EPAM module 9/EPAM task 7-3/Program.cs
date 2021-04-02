using System;

namespace EPAM_task_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown count = new Countdown();
            RandomSubscriber1 sub1 = new RandomSubscriber1();
            RandomSubscriber2 sub2 = new RandomSubscriber2();
            sub1.Subscribe(count);
            sub2.Subscribe(count);
            count.SimulateSend(400);
        }
    }
}
