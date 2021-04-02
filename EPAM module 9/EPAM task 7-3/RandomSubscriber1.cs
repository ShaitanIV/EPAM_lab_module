using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EPAM_task_7_3
{
    class RandomSubscriber1
    {
        public RandomSubscriber1()
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
                Console.WriteLine("Subscriber1 got message");
                Thread.Sleep(ticks);
            }

        }

        public void Unsubscribe(Countdown subscription)
        {
            subscription.SendMessage -= SubMsg;
        }
    }
}
