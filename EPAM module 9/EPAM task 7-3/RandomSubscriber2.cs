using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EPAM_task_7_3
{
    class RandomSubscriber2
    {
        public RandomSubscriber2()
        {

        }

        public void Subscribe(Countdown subscription)
        {
            subscription.SendMessage += SubMsg;
        }

        private void SubMsg(object sender, int ticks)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Subscriber2 got message");
                Thread.Sleep(ticks);
            }

        }

        public void Unsubscribe(Countdown subscription)
        {
            subscription.SendMessage -= SubMsg;
        }
    }
}
