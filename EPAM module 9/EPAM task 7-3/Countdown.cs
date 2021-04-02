using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EPAM_task_7_3
{
    class Countdown
    {
        public delegate void SendMessageHandler(object sender, int numberOfTicks);
        public event SendMessageHandler SendMessage;
        protected virtual void OnSendMessage(object sender, int numberOfTicks)
        {
            SendMessage?.Invoke(sender, numberOfTicks);
        }

        public void SimulateSend(int numberOfTicks)
        {
            OnSendMessage(this, numberOfTicks);
        }
    }
}
