using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ConcreteMediator : IMediator
    {
        List<AbstractFriend> participants = new List<AbstractFriend>();
        public void Register(AbstractFriend friend)
        {
            participants.Add(friend);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Current list of registered participants is as follows:");
            foreach (AbstractFriend friend in participants)
            {
                Console.WriteLine($"{friend.Name}");
            }
        }
        public void Send(AbstractFriend fromFriend, AbstractFriend toFriend, string msg)
        {
            // Verifying if the sender is registered or not
            if (participants.Contains(fromFriend))
            {
                // Verifying if receiver is registered
                if (participants.Contains(toFriend))
                {
                    Console.WriteLine($"\n [{fromFriend.Name}] posts: {msg}. Last message posted {DateTime.Now}");
                    System.Threading.Thread.Sleep(1000);
                    toFriend.ReceiveMessage(fromFriend, msg);
                }
                else
                {
                    Console.WriteLine($"\n {fromFriend.Name}, you cannot send message to {toFriend.Name} because he is not registered.");
                }
            }
            else
            {
                Console.WriteLine($"\nAn outsider named {fromFriend.Name} of [{fromFriend.GetType()}] is trying to send a message to {toFriend.Name}.");
            }
        }

    }
}
