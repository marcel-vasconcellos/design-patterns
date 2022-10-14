using System;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Mediator Pattern Demo***");
            IMediator mediator = new ConcreteMediator();
            Friend friend1 = new Friend(mediator);
            friend1.Name = "Gabriel";
            Friend friend2 = new Friend(mediator);
            friend2.Name = "Henrique";
            Friend friend3 = new Friend(mediator);
            friend3.Name = "Daniel";

            Stranger stranger1 = new Stranger(mediator);
            stranger1.Name = "Someone";

            mediator.Register(friend1);
            mediator.Register(friend2);
            mediator.Register(stranger1);

            mediator.DisplayDetails();
            Console.WriteLine("Communication starts among participants...");
            friend1.SendMessage(friend2, "Hi, Henrique.");
            friend2.SendMessage(friend1, "Hey, Gabriel.");
            stranger1.SendMessage(friend1, "Hello");

            Friend friend4 = new Friend(mediator);
            friend4.Name = "Somename";
            friend4.SendMessage(stranger1, "Hello, stranger");
            friend1.SendMessage(friend4, "Hello, unregistered friend.");
            Stranger stranger2 = new Stranger(mediator);
            stranger2.Name = "Someguy";
            stranger2.SendMessage(stranger1, "Hello, fellow stranger");
            Console.ReadKey();
        }
    }
}
