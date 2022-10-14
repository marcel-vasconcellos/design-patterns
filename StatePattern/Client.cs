using System;

namespace StatePattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***State Pattern Demo***");
            // Initialization
            TV tv = new TV();
            Console.WriteLine("User is pressing byttons in the following sequence:");
            Console.WriteLine("Off->Mute->On->On->Mute->Mute->Off\n");
            tv.ExecuteOffButton();
            tv.ExecuteMuteButton();
            tv.ExecuteOnButton();
            tv.ExecuteOnButton();
            tv.ExecuteMuteButton();
            tv.ExecuteMuteButton();
            tv.ExecuteOffButton();
            Console.ReadLine();
        }
    }
}
