using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class EmailErrorHandler : Receiver
    {
        bool messagePassedToNextHandler = false;
        public override void HandleMessage(Message message)
        {
            if (message.Text.Contains("email"))
            {
                Console.WriteLine($"FaxErrorHandler processed {message.Priority} priority issue: {message.Text}");
                if (nextReceiver != null && message.Text.Contains("email"))
                {
                    Console.WriteLine("I've fixed email side defect.Now email team needs to work on top of this fix.");

                    nextReceiver.HandleMessage(message);
                    //We'll not pass the message repeatedly to next handler.
                    messagePassedToNextHandler = true;
                }
            }
            if (nextReceiver != null && messagePassedToNextHandler != true)
            {
                nextReceiver.HandleMessage(message);
            }
        }
    }
}
