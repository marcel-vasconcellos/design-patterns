using System;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Strategy Pattern Demo***");
            IChoice ic = null;
            Context cxt = new Context();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nEnter your choice (1 or 2)");
                string c = Console.ReadLine();
                if (c.Equals("1"))
                {
                    ic = new FirstChoice();
                }
                else
                {
                    ic = new SecondChoice();
                }
                cxt.SetChoice(ic);
                cxt.ShowChoice();
            }
            Console.ReadKey();
        }
    }
}
